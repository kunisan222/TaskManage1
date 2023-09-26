namespace KT_TaskManage.Data
{
    public record TaskID
    {
        const int InvalidId = -1;
        public int ID { get; set; }

        public static TaskID Invalid = new(InvalidId);
        public TaskID() { }
        public TaskID(int id)
        {
            ID = id;
        }
        public decimal ToDecimal()
        {
            return Convert.ToDecimal(ID);
        }
        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
