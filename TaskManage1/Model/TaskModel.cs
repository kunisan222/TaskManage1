using System.ComponentModel;

namespace KT_TaskManage.Data
{
    public record TaskModel
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
        [ReadOnly(true)]
        public TaskType Type { get; set; } = TaskType.None;
        public static TaskModel InvalidData()
        {
            return new TaskModel(TaskID.Invalid, string.Empty, string.Empty, TaskType.None);
        }
        public TaskModel() { }
        public TaskModel(TaskID id, string name, string description, TaskType type)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
        }
    }
}
