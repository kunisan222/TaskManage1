using System.Xml.Serialization;

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

        [XmlIgnore]
        const int InvalidTaskId = -1;

        public int Id { get; set; } = InvalidTaskId;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskType Type { get; set; } = TaskType.None;
        public static TaskData InvalidData()
        {
            return new TaskData(InvalidTaskId, string.Empty, string.Empty, TaskType.None);
        }
        public TaskData() { }
        public TaskData(int id, string name, string description, TaskType type)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
        }
    }
}
