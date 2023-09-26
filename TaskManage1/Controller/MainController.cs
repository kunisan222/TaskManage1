using KT_TaskManage.Data;
using KT_TaskManage.Helper;
using KT_TaskManage.Util;

namespace KT_TaskManage.Controller
{
    internal class MainController : MainForm.IController, IDisposable
    {
        MasterData _masterData;

        public MainController(MasterData masterData)
        {
            this._masterData = masterData;
        }

        public void Dispose()
        {
        }

        public void AddTask(TaskData taskData)
            => TaskDataHelper.AddTask(_masterData, taskData);

        public void DeleteTask(TaskID taskId)
            => TaskDataHelper.DeleteTask(_masterData, taskId);

        public void EditTask(TaskData taskData)
            => TaskDataHelper.EditTask(_masterData, taskData);

        public TaskData GetTaskData(TaskID taskId)
            => TaskDataHelper.GetTaskData(_masterData, taskId);

        public bool IsValidTaskId(TaskID taskId)
            => taskId != TaskID.Invalid;

        List<TaskData> MainForm.IController.GetActiveTaskList()
            => TaskDataHelper.GetActiveTaskList(_masterData);

        List<TaskData> MainForm.IController.GetDeactiveTaskList()
            => TaskDataHelper.GetDeactiveTaskList(_masterData);

        public void SaveData()
            => FileManager.XmlSerialize(@".\test.xml", _masterData);

        public void LoadData()
            => FileManager.XmlDeSerialize(@".\test.xml", out _masterData);

        public bool OpenNewRegistTaskForm(Func<MasterData, bool> func)
            => func(_masterData);

        public bool OpenEditRegistTaskForm(Func<MasterData, TaskID, bool> func, TaskID taskId)
            => func(_masterData, taskId);
    }
}
