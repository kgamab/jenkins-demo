using System.ComponentModel.DataAnnotations;

namespace JenkinsTryOut.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}