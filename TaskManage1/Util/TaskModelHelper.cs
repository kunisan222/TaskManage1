using KT_TaskManage.Data;
using static KT_TaskManage.Data.TaskModel;

namespace KT_TaskManage.Util
{
    internal static class TaskModelHelper
    {
        public static void AddTask(MasterModel masterData, TaskModel taskData)
        {
            masterData.TaskData.Add(taskData);
        }

        public static void EditTask(MasterModel masterData, TaskModel taskData)
        {
            masterData.TaskData
                .Where(v => v.Id == taskData.Id)
                .ToList()
                .ForEach(v =>
                {
                    v = taskData;
                });
        }

        public static void DeleteTask(MasterModel masterData, TaskID taskId)
        {
            masterData.TaskData.RemoveAll(v => v.Id == taskId);
        }

        public static void EndTask(MasterModel masterData, TaskID taskId)
        {
            masterData.TaskData
                .Where(v => v.Id == taskId)
                .ToList()
                .ForEach(v =>
                {
                    v.Type = TaskType.Deactive;
                });
        }

        public static TaskModel GetTaskData(MasterModel masterData, TaskID taskId)
        {
            if (!IsExistTaskId(masterData, taskId)) return InvalidData();

            return masterData.TaskData
                .Where(v => v.Id == taskId)
                .Single();
        }
        public static bool IsActiveTask(MasterModel masterData, TaskID taskId)
        {
            if (!IsExistTaskId(masterData, taskId)) return false;

            return GetTaskData(masterData, taskId).Type == TaskType.Active;
        }

        public static List<TaskModel> GetActiveTaskList(MasterModel masterData)
        {
            return masterData.TaskData
                .Where(v => v.Type == TaskType.Active)
                .Select(n => n).ToList();
        }

        public static List<TaskModel> GetDeactiveTaskList(MasterModel masterData)
        {
            return masterData.TaskData
                .Where(v => v.Type == TaskType.Deactive)
                .Select(n => n).ToList();
        }

        public static bool IsExistTaskId(MasterModel masterData, TaskID id)
            => masterData.TaskData.Any(n => n.Id == id);

        public static bool IsDuplicateId(MasterModel masterData, TaskID id)
            => IsExistTaskId(masterData, id);
    }
}
