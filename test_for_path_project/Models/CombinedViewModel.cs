namespace test_for_path_project.Models
{
    public class CombinedViewModel
    {
        public IEnumerable<AAU> ? AAU { get; set; }
        public IEnumerable<PHU>? PHU{ get; set; }
        public IEnumerable<MEU>? MEU { get; set; }

        public IEnumerable<University>? UniesList { get; set; }
    }
}
