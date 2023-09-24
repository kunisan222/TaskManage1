using KT_TaskManage.Data;

namespace KT_TaskManage
{
    public partial class MainForm : Form
    {
        readonly TaskDataManager _data = new();

        public MainForm()
        {
            InitializeComponent();
            UpdateTaskList();
        }

        private void RegistTaskButton_Click(object sender, EventArgs e)
        {
            using (var f = new RegistTaskForm(_data))
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
            for (int i = 0; i < _data.GetTaskCount(); i++)
            {
                TaskItemListBox.Items.Add(_data.GetTaskName(i));
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

            _data.DeleteTask(taskName);
            UpdateTaskList();
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            if (!GetTaskName(out var taskName))
            {
                MessageBox.Show("編集アイテム未選択です。", "エラー", MessageBoxButtons.OK);
                return;
            }

            using (var f = new RegistTaskForm(_data, taskName))
            {
                f.ShowDialog();
                UpdateTaskList();
            }
        }
    }
}