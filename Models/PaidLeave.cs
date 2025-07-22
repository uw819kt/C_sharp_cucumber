using cucumber.Models.Enums;

namespace cucumber.Models
{
    public class PaidLeave
    {   public long Id { get; set; }
        public DateTime BaseDate { get; set; }
        public bool PartTime { get; set; } = false;
        public ClassificationType Classification { get; set; } = ClassificationType.Default;
        public long UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
