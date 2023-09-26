using KT_TaskManage.Data;
using static KT_TaskManage.Data.TaskModel;

namespace KT_TaskManage
{
    public partial class RegistTaskForm : Form
    {
        IController _controller;

        public interface IController
        {
            bool IsActiveTask(TaskID taskId);
            int MinTaskId();
            int MaxTaskId();
            void SetEdit(bool enable);
            bool CanChangeTaskId(TaskID taskId);
            string GetTaskName(TaskID taskId);
            string GetDescription(TaskID taskId);
            bool RegistTaskData(TaskModel taskData, out string resultMessage);
        }

        public RegistTaskForm(IController controller)
        {
            InitializeComponent();

            _controller = controller;

            TaskIdNumericUpDown.Minimum = _controller.MinTaskId();
            TaskIdNumericUpDown.Maximum = _controller.MaxTaskId();
        }

        public RegistTaskForm(IController controller, TaskID taskId) : this(controller)
        {
            _controller.SetEdit(true);

            TaskIdNumericUpDown.Value = taskId.ToDecimal();
            TaskNameTextBox.Text = _controller.GetTaskName(taskId);
            DescriptionTextBox.Text = _controller.GetDescription(taskId);
            radioButton1.Checked = _controller.IsActiveTask(taskId);
            radioButton2.Checked = !_controller.IsActiveTask(taskId);
            TaskIdNumericUpDown.Enabled = _controller.CanChangeTaskId(taskId);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistButton_Click(object sender, EventArgs e)
        {
            var taskData = new TaskModel(
                new TaskID(decimal.ToInt32(TaskIdNumericUpDown.Value)),
                TaskNameTextBox.Text,
                DescriptionTextBox.Text,
                radioButton1.Checked ? TaskType.Active : TaskType.Deactive);

            if (!_controller.RegistTaskData(taskData, out var resultMessage))
            {
                MessageBox.Show(resultMessage, Resource.MessageBoxTitle, MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show(resultMessage, Resource.MessageBoxTitle, MessageBoxButtons.OK);
            this.Close();
        }
    }
}
