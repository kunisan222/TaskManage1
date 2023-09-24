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

        private void DeketeTaskButton_Click(object sender, EventArgs e)
        {
            var taskSelIndex = TaskItemListBox.SelectedIndex;
            if (taskSelIndex == -1)
            {
                MessageBox.Show("削除アイテム未選択です。", "エラー", MessageBoxButtons.OK);
                return;
            }

            var taskName = TaskItemListBox.Items[taskSelIndex].ToString();
            if (taskName != null)
            {
                _data.DeleteTask(taskName);
                UpdateTaskList();
            }
        }
    }
}