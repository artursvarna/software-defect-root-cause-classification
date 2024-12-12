namespace BugzillaBugCategorization.Data
{
    public class Report
    {
        public int Id { get; set; }        
        public string Opening { get; set; }
        public string Reporter { get; set; }
        public string VerificationStatus { get; set; }
        public string ResolutionStatus { get; set; }
        public string RootCauseCategory { get; set; }
        public List<string> Components { get; set; } = new List<string>();
        public List<string> Description { get; set; } = new List<string>();
        public string FullDescription { get; set; }
    }
}
