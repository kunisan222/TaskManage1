using KT_TaskManage.Data;

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
            DeleteTask(masterData, taskData.Id);
            AddTask(masterData, taskData);
        }

        public static void DeleteTask(MasterData masterData, TaskID taskId)
        {
            masterData.TaskData.RemoveAll(v => v.Id == taskId);
        }

        public static int GetTaskCount(MasterData masterData)
        {
            return masterData.TaskData.Count;
        }

        public static TaskData GetTaskData(MasterData masterData, TaskID taskId)
        {
            var taskData = masterData.TaskData.Where(v => v.Id == taskId).FirstOrDefault();
            if (taskData == null) return TaskData.InvalidData();

            return taskData;
        }

        public static string GetTaskName(MasterData masterData, int index)
        {
            return masterData.TaskData[index].Name;
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
