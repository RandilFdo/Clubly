
using System;

namespace ClubManager
{
    public class UserTask
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
        public string Status { get; set; } // "To Do", "In Progress", "Done"

        public UserTask() { }

        public UserTask(string description, DateTime dueDate, string priority, int clubId)
        {
            Description = description;
            DueDate = dueDate;
            Priority = priority;
            ClubId = clubId;
            Status = "To Do"; // Default status
        }
    }
}
