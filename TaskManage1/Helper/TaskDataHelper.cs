using KT_TaskManage.Data;
using static KT_TaskManage.Data.TaskData;

namespace KT_TaskManage.Helper
{
    internal static class TaskDataHelper
    {
        public static void AddTask(MasterData masterData, TaskData taskData)
        {
            masterData.TaskData.Add(taskData);
        }

        public static void EditTask(MasterData masterData, TaskData taskData)
        {
            masterData.TaskData
                .Where(v => v.Id == taskData.Id)
                .ToList()
                .ForEach(v =>
                {
                    v = taskData;
                });
        }

        public static void DeleteTask(MasterData masterData, TaskID taskId)
        {
            masterData.TaskData.RemoveAll(v => v.Id == taskId);
        }

        public static void EndTask(MasterData masterData, TaskID taskId)
        {
            masterData.TaskData
                .Where(v => v.Id == taskId)
                .ToList()
                .ForEach(v =>
                {
                    v.Type = TaskType.Deactive;
                });
        }

        public static TaskData GetTaskData(MasterData masterData, TaskID taskId)
        {
            var taskData = masterData.TaskData
                .Where(v => v.Id == taskId)
                .FirstOrDefault();
            if (taskData == null) return TaskData.InvalidData();

            return taskData;
        }

        public static List<TaskData> GetActiveTaskList(MasterData masterData)
        {
            return masterData.TaskData
                .Where(v => v.Type == TaskType.Active)
                .Select(n => n).ToList();
        }

        public static List<TaskData> GetDeactiveTaskList(MasterData masterData)
        {
            return masterData.TaskData
                .Where(v => v.Type == TaskType.Deactive)
                .Select(n => n).ToList();
        }

        public static bool IsDuplicateId(MasterData masterData, TaskID id, out string message)
        {
            if (masterData.TaskData.Any(n => n.Id == id))
            {
                message = "重複IDがあります。";
                return false;
            }

            message = string.Empty;
            return true;
        }
    }
}
