using System.ComponentModel.DataAnnotations;

namespace EntityModeler.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}