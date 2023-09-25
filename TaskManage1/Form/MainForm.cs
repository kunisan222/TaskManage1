using KT_TaskManage.Data;
using KT_TaskManage.Helper;
using KT_TaskManage.Util;
using static KT_TaskManage.Data.TaskData;

namespace KT_TaskManage
{
    public partial class MainForm : Form
    {
        MasterData _masterData = new();

        public MainForm()
        {
            InitializeComponent();

            TaskItemListBox.DisplayMember = "Name";

            UpdateTaskList();
        }

        private void RegistTaskButton_Click(object sender, EventArgs e)
        {
            using (var f = new RegistTaskForm(_masterData))
            {
                f.ShowDialog();
                UpdateTaskList();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateTaskList()
        {
            TaskItemListBox.DataSource = null;
            TaskItemListBox.DataSource = _masterData.TaskData;
        }

        private TaskID GetSelectedTaskId()
        {
            var taskData = TaskItemListBox.SelectedItem as TaskData;
            if (taskData == null) return TaskID.Invalid;

            return taskData.Id;
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            var taskId = GetSelectedTaskId();
            if (taskId == TaskID.Invalid)
            {
                MessageBox.Show("削除アイテム未選択です。", "エラー", MessageBoxButtons.OK);
                return;
            }

            TaskDataHelper.DeleteTask(_masterData, taskId);
            UpdateTaskList();
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            var taskId = GetSelectedTaskId();
            if (taskId == TaskID.Invalid)
            {
                MessageBox.Show("削除アイテム未選択です。", "エラー", MessageBoxButtons.OK);
                return;
            }

            using (var f = new RegistTaskForm(_masterData, taskId))
            {
                f.ShowDialog();
                UpdateTaskList();
            }
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            FileManager.XmlSerialize(@".\test.xml", _masterData);
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            FileManager.XmlDeSerialize(@".\test.xml", out _masterData);
            UpdateTaskList();
        }

        private void TaskItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var taskId = GetSelectedTaskId();
            if (taskId == TaskID.Invalid)
            {
                return;
            }

            TaskItemPropertyGrid.SelectedObject = TaskDataHelper.GetTaskData(_masterData, taskId, TaskType.Active);
        }

        private void TaskItemListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            var taskData = e.ListItem as TaskData;
            if (taskData == null) return;

            e.Value = string.Format($"{taskData.Id}, {taskData.Name}");
        }
    }
}