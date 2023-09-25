using KT_TaskManage.Data;
using KT_TaskManage.Helper;
using KT_TaskManage.Util;

namespace KT_TaskManage
{
    public partial class MainForm : Form
    {
        MasterData _masterData = new();

        public MainForm()
        {
            InitializeComponent();
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
            TaskItemListBox.Items.Clear();
            for (int i = 0; i < TaskDataHelper.GetTaskCount(_masterData); i++)
            {
                TaskItemListBox.Items.Add(TaskDataHelper.GetTaskName(_masterData, i));
            }
        }

        private bool GetTaskName(out string taskName)
        {
            var taskSelIndex = TaskItemListBox.SelectedIndex;
            if (taskSelIndex == -1)
            {
                taskName = string.Empty;
                return false;
            }

            var temp = TaskItemListBox.Items[taskSelIndex].ToString();
            if (temp == null)
            {
                taskName = string.Empty;
                return false;
            }

            taskName = temp;
            return true;
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            if (!GetTaskName(out var taskName))
            {
                MessageBox.Show("削除アイテム未選択です。", "エラー", MessageBoxButtons.OK);
                return;
            }

            TaskDataHelper.DeleteTask(_masterData, taskName);
            UpdateTaskList();
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            if (!GetTaskName(out var taskName))
            {
                MessageBox.Show("編集アイテム未選択です。", "エラー", MessageBoxButtons.OK);
                return;
            }

            using (var f = new RegistTaskForm(_masterData, taskName))
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
    }
}