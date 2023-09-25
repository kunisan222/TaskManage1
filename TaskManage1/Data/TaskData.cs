namespace KT_TaskManage.Data
{
    public class TaskData
    {
        public enum TaskType
        {
            Active,
            Deactive,
            None,
        }

        public TaskID Id { get; set; } = TaskID.Invalid;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskType Type { get; set; } = TaskType.None;
        public static TaskData InvalidData()
        {
            return new TaskData(TaskID.Invalid, string.Empty, string.Empty, TaskType.None);
        }
        public TaskData() { }
        public TaskData(TaskID id, string name, string description, TaskType type)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
        }
    }
}
