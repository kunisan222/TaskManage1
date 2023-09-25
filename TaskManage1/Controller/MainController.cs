using KT_TaskManage.Data;
using KT_TaskManage.Helper;

namespace KT_TaskManage.Controller
{
    internal class MainController : MainForm.IController
    {
        MasterData _masterData;
        MainForm _Form;

        public MainController(MasterData masterData, MainForm form)
        {
            this._masterData = masterData;
            this._Form = form;
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
            => taskId != TaskID.Invalid ? true : false;

        List<TaskData> MainForm.IController.GetActiveTaskList()
            => TaskDataHelper.GetActiveTaskList(_masterData);

        List<TaskData> MainForm.IController.GetDeactiveTaskList()
            => TaskDataHelper.GetDeactiveTaskList(_masterData);
    }
}
