using KT_TaskManage.Controller;
using KT_TaskManage.Data;
using KT_TaskManage.Util;

namespace KT_TaskManage
{
    public partial class MainForm : Form
    {
        MasterData _masterData = new();
        IController _controller;

        internal interface IController
        {
            internal List<TaskData> GetActiveTaskList();
            internal List<TaskData> GetDeactiveTaskList();
            bool IsValidTaskId(TaskID taskId);
            void AddTask(TaskData taskData);
            void EditTask(TaskData taskData);
            void DeleteTask(TaskID taskId);
            TaskData GetTaskData(TaskID taskId);
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
            ActiveTaskItemListBox.DataSource = _controller.GetActiveTaskList();

            DeactiveTaskItemListBox.DataSource = null;
            DeactiveTaskItemListBox.DataSource = _controller.GetDeactiveTaskList();
        }

        // TODO:Indexで判定するのは良くないような。マジックナンバーだし。
        private ListBox GetActiveListBox()
            => TaskListTabControl.SelectedIndex == 0 ? ActiveTaskItemListBox : DeactiveTaskItemListBox;

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            var taskData = GetActiveListBox().SelectedItem as TaskData;
            if (taskData == null) return;

            if (!_controller.IsValidTaskId(taskData.Id))
            {
                MessageBox.Show(Resource.NoSelectedDeleteTaskId, Resource.Error, MessageBoxButtons.OK);
                return;
            }

            _controller.DeleteTask(taskData.Id);

            UpdateTaskList();
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            var taskData = GetActiveListBox().SelectedItem as TaskData;
            if (taskData == null) return;

            if (!_controller.IsValidTaskId(taskData.Id))
            {
                MessageBox.Show(Resource.NoSelectedEditTaskId, Resource.Error, MessageBoxButtons.OK);
                return;
            }

            using (var f = new RegistTaskForm(_masterData, taskData.Id))
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
            var taskData = GetActiveListBox().SelectedItem as TaskData;
            if (taskData == null) return;

            if (!_controller.IsValidTaskId(taskData.Id)) return;

            TaskItemPropertyGrid.SelectedObject = _controller.GetTaskData(taskData.Id);
        }

        private void TaskItemListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            var taskData = e.ListItem as TaskData;
            if (taskData == null) return;

            e.Value = string.Format($"{taskData.Id}, {taskData.Name}");
        }

        private void EndTaskButton_Click(object sender, EventArgs e)
        {
            var taskData = GetActiveListBox().SelectedItem as TaskData;
            if (taskData == null) return;

            if (!_controller.IsValidTaskId(taskData.Id))
            {
                MessageBox.Show(Resource.NoSelectedDeleteTaskId, Resource.Error, MessageBoxButtons.OK);
                return;
            }

            _controller.EditTask(taskData);

            UpdateTaskList();
        }
    }
}