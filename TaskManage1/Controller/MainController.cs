using KT_TaskManage.Data;
using KT_TaskManage.Util;

namespace KT_TaskManage.Controller
{
    internal class MainController : MainForm.IController, IDisposable
    {
        MasterModel _masterData;

        public MainController(MasterModel masterData)
        {
            this._masterData = masterData;
        }

        public void Dispose()
        {
        }

        public void AddTask(TaskModel taskData)
            => TaskModelHelper.AddTask(_masterData, taskData);

        public void DeleteTask(TaskID taskId)
            => TaskModelHelper.DeleteTask(_masterData, taskId);

        public void EditTask(TaskModel taskData)
            => TaskModelHelper.EditTask(_masterData, taskData);

        public TaskModel GetTaskData(TaskID taskId)
            => TaskModelHelper.GetTaskData(_masterData, taskId);

        public bool IsValidTaskId(TaskID taskId)
            => taskId != TaskID.Invalid;

        List<TaskModel> MainForm.IController.GetActiveTaskList()
            => TaskModelHelper.GetActiveTaskList(_masterData);

        List<TaskModel> MainForm.IController.GetDeactiveTaskList()
            => TaskModelHelper.GetDeactiveTaskList(_masterData);

        public void SaveData()
            => FileManager.XmlSerialize(@".\test.xml", _masterData);

        public void LoadData()
            => FileManager.XmlDeSerialize(@".\test.xml", out _masterData);

        public bool OpenNewRegistTaskForm(Func<MasterModel, bool> func)
            => func(_masterData);

        public bool OpenEditRegistTaskForm(Func<MasterModel, TaskID, bool> func, TaskID taskId)
            => func(_masterData, taskId);
    }
}
