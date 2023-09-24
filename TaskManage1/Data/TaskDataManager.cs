namespace KT_TaskManage.Data
{
    public class TaskDataManager
    {
        readonly List<TaskData> _taskData = new();
        public void AddTask(TaskData data)
        {
            _taskData.Add(data);
        }

        public void DeleteTask(string taskName)
        {
            _taskData.RemoveAll(v => v.Name == taskName);
        }

        public int GetTaskCount()
        {
            return _taskData.Count;
        }

        public string GetTaskName(int index)
        {
            return _taskData[index].Name;
        }

        public bool IsDuplicateId(int id, out string message)
        {
            if (_taskData.Any(n => n.Id == id))
            {
                message = "重複IDがあります。";
                return false;
            }

            message = string.Empty;
            return true;
        }
    }
    public class TaskData
    {
        public enum TaskType
        {
            Active,
            Deactive,
            None,
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskType Type { get; set; }
        public TaskData(int id, string name, string description, TaskType type)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
        }
    }
}
