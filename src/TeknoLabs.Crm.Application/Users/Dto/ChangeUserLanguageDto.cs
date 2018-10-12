using System.ComponentModel.DataAnnotations;

namespace TeknoLabs.Crm.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}