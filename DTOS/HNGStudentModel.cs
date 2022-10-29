namespace HNGProjectTaskOneAPI.DTOS
{
    public class HNGStudentModel
    {
        public int Id { get; set; }
        public string? slackUsername { get; set; }
        public bool backend { get; set; }
        public int age { get; set; }
        public string? bio { get; set; }
    }
}
