using KT_TaskManage.Controller;
using KT_TaskManage.Data;
using KT_TaskManage.Helper;
using KT_TaskManage.Util;

namespace KT_TaskManage
{
    public partial class MainForm : Form
    {
        MasterData _masterData = new();
        MainController _controller;

        public interface IController
        {

        }

        public MainForm()
        {
            InitializeComponent();

            _controller = new MainController(_masterData, this);

            ActiveTaskItemListBox.DisplayMember = "Name";
            DeactiveTaskItemListBox.DisplayMember = "Name";

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
            ActiveTaskItemListBox.DataSource = null;
            ActiveTaskItemListBox.DataSource = TaskDataHelper.GetActiveTaskList(_masterData);

            DeactiveTaskItemListBox.DataSource = null;
            DeactiveTaskItemListBox.DataSource = TaskDataHelper.GetDeactiveTaskList(_masterData);
        }

        // TODO:Indexで判定するのは良くないような。マジックナンバーだし。
        private ListBox GetActiveListBox()
            => TaskListTabControl.SelectedIndex == 0 ? ActiveTaskItemListBox : DeactiveTaskItemListBox;

        private TaskID GetSelectedTaskId()
        {
            var taskData = GetActiveListBox().SelectedItem as TaskData;
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

            TaskItemPropertyGrid.SelectedObject = TaskDataHelper.GetTaskData(_masterData, taskId);
        }

        private void TaskItemListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            var taskData = e.ListItem as TaskData;
            if (taskData == null) return;

            e.Value = string.Format($"{taskData.Id}, {taskData.Name}");
        }

        private void EndTaskButton_Click(object sender, EventArgs e)
        {
            var taskId = GetSelectedTaskId();
            if (taskId == TaskID.Invalid)
            {
                MessageBox.Show("完了にするアイテム未選択です。", "エラー", MessageBoxButtons.OK);
                return;
            }

            TaskDataHelper.EndTask(_masterData, taskId);
            UpdateTaskList();
        }
    }
}