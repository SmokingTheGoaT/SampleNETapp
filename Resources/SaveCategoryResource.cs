using System.ComponentModel.DataAnnotations;

namespace SampleNETapp.Resources
{
    public class SaveCategoryResource
    {
       [Required]
       [MaxLength(30)]
       public string Name { get; set; }
    }
}