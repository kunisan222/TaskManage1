namespace KT_TaskManage.Data
{
    public record MasterModel
    {
        public List<TaskModel> TaskData { get; set; } = new();
    }
}
