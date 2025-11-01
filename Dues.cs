using System;

namespace ClubManager
{
    public class Dues
    {
        public int DueId { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsPaid { get; set; }
        public string Description { get; set; }

        public Dues() { }

        public Dues(int clubId, decimal amount, DateTime dueDate, string description)
        {
            ClubId = clubId;
            Amount = amount;
            DueDate = dueDate;
            Description = description;
            IsPaid = false;
        }
    }
}