using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_for_path_project.Models
{
    [Table("PHU_INFO")]
    public class PHU :  ModelsInterace
    {
        [Key]
        public int Id { get; set; }
        public string? التخصص { get; set; }
        public string? الكلية { get; set; }
        public string? معدل_القبول { get; set; }
        public int? الساعات { get; set; }
        public int? السعر { get; set; }

      
    }
}
