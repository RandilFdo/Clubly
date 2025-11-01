namespace ClubManager
{
    public class Club
    {
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime NextEventDate { get; set; }
        public int OutstandingTasks { get; set; }
        public int UnpaidDues { get; set; }

        public string Description { get; set; }

        public Club() { }

        public Club(string name, string category, string description, DateTime nextEventDate, int outstandingTasks, int unpaidDues)
        {
            Name = name;
            Category = category;
            Description = description;
            NextEventDate = nextEventDate;
            OutstandingTasks = outstandingTasks;
            UnpaidDues = unpaidDues;
        }
    }
}