using KT_TaskManage.Data;
using KT_TaskManage.Helper;
using static KT_TaskManage.Data.TaskData;

namespace KT_TaskManage
{
    public partial class RegistTaskForm : Form
    {
        readonly MasterData _masterData;
        bool isEdit = false;

        public RegistTaskForm(MasterData data)
        {
            InitializeComponent();

            _masterData = data;

            radioButton1.Checked = true;
            radioButton2.Checked = false;

            TaskIdNumericUpDown.Minimum = 0;
            TaskIdNumericUpDown.Maximum = 100;
        }

        public RegistTaskForm(MasterData masterData, TaskID taskId) : this(masterData)
        {
            isEdit = true;

            var editTaskData = TaskDataHelper.GetTaskData(masterData, taskId);

            if (editTaskData != null)
            {
                TaskIdNumericUpDown.Value = editTaskData.Id.ToDecimal();
                TaskNameTextBox.Text = editTaskData.Name;
                DescriptionTextBox.Text = editTaskData.Description;
                if (editTaskData.Type == TaskType.Active)
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
                new TaskID(decimal.ToInt32(TaskIdNumericUpDown.Value)),
                TaskNameTextBox.Text,
                DescriptionTextBox.Text,
                radioButton1.Checked ? TaskType.Active : TaskType.Deactive);

            if (!isEdit)
            {
                TaskDataHelper.AddTask(_masterData, taskData);
            }
            else
            {
                TaskDataHelper.EditTask(_masterData, taskData);
            }

            MessageBox.Show("タスク登録に成功", "成功", MessageBoxButtons.OK);
            this.Close();
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
                var taskId = new TaskID(decimal.ToInt32(TaskIdNumericUpDown.Value));
                if (!TaskDataHelper.IsDuplicateId(_masterData, taskId, out message))
                {
                    return false;
                }
            }

            message = string.Empty;
            return true;
        }
    }
}
