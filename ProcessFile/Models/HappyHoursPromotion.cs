namespace ProcessFile.Models
{
    public class HappyHoursPromotion
    {
        public TimeSpan BeginHour { get; set; }   // 9:30
        public TimeSpan EndHour { get; set; }     // 16:00

        public HappyHoursPromotion()
        {
            BeginHour = TimeSpan.Parse("9:30");
            EndHour = TimeSpan.Parse("16:00");

            TimeSpan duration = TimeSpan.FromSeconds(30);
        }
    }
}
