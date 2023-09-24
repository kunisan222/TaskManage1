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
            listBox1.Items.Clear();
            for (int i = 0; i < _data.GetTaskCount(); i++)
            {
                listBox1.Items.Add(_data.GetTaskName(i));
            }
        }
    }
}