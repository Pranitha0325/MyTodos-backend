using System.ComponentModel.DataAnnotations;

namespace task.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}