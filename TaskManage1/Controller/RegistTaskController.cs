using KT_TaskManage.Data;
using KT_TaskManage.Util;

namespace KT_TaskManage.Controller
{
    internal class RegistTaskController : RegistTaskForm.IController, IDisposable
    {
        readonly MasterModel _masterData;
        bool _isEdit = false;

        public RegistTaskController(MasterModel masterData)
        {
            _masterData = masterData;
        }

        public bool IsActiveTask(TaskID taskId)
            => TaskModelHelper.IsActiveTask(_masterData, taskId);

        public int MaxTaskId() => 100;
        public int MinTaskId() => 1;

        public void Dispose()
        {
        }

        public bool CanChangeTaskId(TaskID taskId) => !_isEdit;

        public string GetTaskName(TaskID taskId)
            => TaskModelHelper.GetTaskData(_masterData, taskId).Name;

        public string GetDescription(TaskID taskId)
            => TaskModelHelper.GetTaskData(_masterData, taskId).Description;

        public void SetEdit(bool enable)
            => _isEdit = enable;

        public bool RegistTaskData(TaskModel taskData, out string resultMessage)
        {
            if (string.IsNullOrEmpty(taskData.Name))
            {
                resultMessage = Resource.TaskNameEmptied;
                return false;
            }

            if (!_isEdit && TaskModelHelper.IsDuplicateId(_masterData, taskData.Id))
            {
                resultMessage = Resource.TaskIdDuplicated;
                return false;
            }

            if (_isEdit) TaskModelHelper.EditTask(_masterData, taskData);
            else TaskModelHelper.AddTask(_masterData, taskData);

            resultMessage = Resource.RegistTaskDataSuccessed;
            return true;
        }
    }
}
