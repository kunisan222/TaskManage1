using KT_TaskManage.Data;

namespace KT_TaskManage
{
    public partial class RegistTaskForm : Form
    {
        readonly TaskDataManager _data;
        bool isEdit = false;

        public RegistTaskForm(TaskDataManager data)
        {
            InitializeComponent();

            _data = data;

            radioButton1.Checked = true;
            radioButton2.Checked = false;

            TaskIdNumericUpDown.Minimum = 0;
            TaskIdNumericUpDown.Maximum = 100;
        }

        public RegistTaskForm(TaskDataManager data, string taskName) : this(data)
        {
            isEdit = true;

            var editTaskData = _data.GetTaskData(taskName);

            if (editTaskData != null)
            {
                TaskIdNumericUpDown.Value = Convert.ToDecimal(editTaskData.Id);
                TaskNameTextBox.Text = editTaskData.Name;
                DescriptionTextBox.Text = editTaskData.Description;
                if (editTaskData.Type == TaskData.TaskType.Active)
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }

                TaskIdNumericUpDown.Enabled = false;
            }
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

            if(!isEdit)
            {
                _data.AddTask(taskData);
            }
            else
            {
                _data.EditTask(taskData);
            }

            MessageBox.Show("タスク登録に成功", "成功", MessageBoxButtons.OK);
        }

        private bool CheckValid(out string message)
        {
            if (string.IsNullOrEmpty(TaskNameTextBox.Text))
            {
                message = "名前が入力されていません。";
                return false;
            }

            // TODO:条件が複雑化している。
            if (!isEdit)
            {
                var id = decimal.ToInt32(TaskIdNumericUpDown.Value);
                if (!_data.IsDuplicateId(id, out message))
                {
                    return false;
                }
            }

            message = string.Empty;
            return true;
        }
    }
}
