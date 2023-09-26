using KT_TaskManage.Controller;
using KT_TaskManage.Data;

namespace KT_TaskManage
{
    public partial class MainForm : Form
    {
        IController _controller;

        public interface IController
        {
            internal List<TaskModel> GetActiveTaskList();
            internal List<TaskModel> GetDeactiveTaskList();
            bool IsValidTaskId(TaskID taskId);
            void AddTask(TaskModel taskData);
            void EditTask(TaskModel taskData);
            void DeleteTask(TaskID taskId);
            void ChangeActiveTask(TaskID taskId);
            TaskModel GetTaskData(TaskID taskId);
            void SaveData();
            void LoadData();
            bool OpenNewRegistTaskForm(Func<MasterModel, bool> func);
            bool OpenEditRegistTaskForm(Func<MasterModel, TaskID, bool> func, TaskID taskId);
        }

        public MainForm(IController controller)
        {
            InitializeComponent();

            _controller = controller;

            ActiveTaskItemListBox.DisplayMember = "Name";
            DeactiveTaskItemListBox.DisplayMember = "Name";

            UpdateTaskList();
        }

        private void RegistTaskButton_Click(object sender, EventArgs e)
        {
            _controller.OpenNewRegistTaskForm(masterData =>
            {
                using (var c = new RegistTaskController(masterData))
                using (var f = new RegistTaskForm(c))
                {
                    f.ShowDialog();
                    UpdateTaskList();
                }

                return true;
            });
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
            var taskData = GetActiveListBox().SelectedItem as TaskModel;
            if (taskData == null ||
                !_controller.IsValidTaskId(taskData.Id))
            {
                MessageBox.Show(Resource.NoSelectedDeleteTaskId, Resource.Error, MessageBoxButtons.OK);
                return;
            }

            _controller.DeleteTask(taskData.Id);

            UpdateTaskList();
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            var taskData = GetActiveListBox().SelectedItem as TaskModel;
            if (taskData == null ||
                !_controller.IsValidTaskId(taskData.Id))
            {
                MessageBox.Show(Resource.NoSelectedEditTaskId, Resource.Error, MessageBoxButtons.OK);
                return;
            }

            _controller.OpenEditRegistTaskForm((masterData, taskId) =>
            {
                using (var c = new RegistTaskController(masterData))
                using (var f = new RegistTaskForm(c, taskId))
                {
                    f.ShowDialog();
                    UpdateTaskList();
                }

                return true;
            }, taskData.Id);
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            _controller.SaveData();
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            _controller.LoadData();
            UpdateTaskList();
        }

        private void TaskItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var taskData = GetActiveListBox().SelectedItem as TaskModel;
            if (taskData == null ||
                !_controller.IsValidTaskId(taskData.Id)) return;

            TaskItemPropertyGrid.SelectedObject = _controller.GetTaskData(taskData.Id);
        }

        private void TaskItemListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            var taskData = e.ListItem as TaskModel;
            if (taskData == null) return;

            e.Value = string.Format($"{taskData.Id}, {taskData.Name}");
        }

        private void EndTaskButton_Click(object sender, EventArgs e)
        {
            var taskData = GetActiveListBox().SelectedItem as TaskModel;
            if (taskData == null ||
                !_controller.IsValidTaskId(taskData.Id))
            {
                MessageBox.Show(Resource.NoSelectedDeleteTaskId, Resource.Error, MessageBoxButtons.OK);
                return;
            }

            _controller.ChangeActiveTask(taskData.Id);

            UpdateTaskList();
        }

        private void SaveMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test", "test", MessageBoxButtons.OK);
        }
    }
}