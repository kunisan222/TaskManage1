using KT_TaskManage.Data;
using KT_TaskManage.Helper;

namespace KT_TaskManage.Controller
{
    internal class RegistTaskController : RegistTaskForm.IController, IDisposable
    {
        readonly MasterData _masterData;
        bool _isEdit = false;

        public RegistTaskController(MasterData masterData)
        {
            _masterData = masterData;
        }

        public bool IsActiveTask(TaskID taskId)
            => TaskDataHelper.IsActiveTask(_masterData, taskId);

        public int MaxTaskId() => 100;
        public int MinTaskId() => 1;

        public void Dispose()
        {
        }

        public bool CanChangeTaskId(TaskID taskId) => !_isEdit;

        public string GetTaskName(TaskID taskId)
            => TaskDataHelper.GetTaskData(_masterData, taskId).Name;

        public string GetDescription(TaskID taskId)
            => TaskDataHelper.GetTaskData(_masterData, taskId).Description;

        public void SetEdit(bool enable)
            => _isEdit = enable;

        public bool RegistTaskData(TaskData taskData, out string resultMessage)
        {
            if (string.IsNullOrEmpty(taskData.Name))
            {
                resultMessage = Resource.TaskNameEmptied;
                return false;
            }

            if (!_isEdit && TaskDataHelper.IsDuplicateId(_masterData, taskData.Id))
            {
                resultMessage = Resource.TaskIdDuplicated;
                return false;
            }

            if (_isEdit) TaskDataHelper.EditTask(_masterData, taskData);
            else TaskDataHelper.AddTask(_masterData, taskData);

            resultMessage = Resource.RegistTaskDataSuccessed;
            return true;
        }
    }
}
