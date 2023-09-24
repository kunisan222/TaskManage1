using KT_TaskManage.Data;

namespace KT_TaskManage
{
    public partial class RegistTaskForm : Form
    {
        readonly TaskDataManager _data;

        public RegistTaskForm(TaskDataManager data)
        {
            InitializeComponent();

            _data = data;

            radioButton1.Checked = true;
            radioButton2.Checked = false;

            TaskIdNumericUpDown.Minimum = 0;
            TaskIdNumericUpDown.Maximum = 100;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistButton_Click(object sender, EventArgs e)
        {
            if (!CheckValid(out var message))
            {
                MessageBox.Show(message, "エラー", MessageBoxButtons.OK);
                return;
            }

            var taskData = new TaskData(
                decimal.ToInt32(TaskIdNumericUpDown.Value),
                TaskNameTextBox.Text,
                DescriptionTextBox.Text,
                radioButton1.Checked ? TaskData.TaskType.Active : TaskData.TaskType.Deactive);

            _data.AddTask(taskData);

            MessageBox.Show("タスク登録に成功", "成功", MessageBoxButtons.OK);
        }

        private bool CheckValid(out string message)
        {
            if (string.IsNullOrEmpty(TaskNameTextBox.Text))
            {
                message = "名前が入力されていません。";
                return false;
            }

            var id = decimal.ToInt32(TaskIdNumericUpDown.Value);
            if (!_data.IsDuplicateId(id, out message))
            {
                return false;
            }

            message = string.Empty;
            return true;
        }
    }
}
