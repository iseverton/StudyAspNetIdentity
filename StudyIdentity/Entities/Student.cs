namespace StudyIdentity.Entities
{
    public class Student
    {
        public int Id { get; set; }

        private int UserId { get; set; }
        private User User { get; set; }
    }
}
