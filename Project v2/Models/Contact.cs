using System.ComponentModel.DataAnnotations;

namespace Project_v2.Models
{
    public class Contact
    {
        private string Name;
        private string Surname;
        private int Age;
        private int Email;
        private string Message;

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Вам нужно ввести имя")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string surname { get; set; }

        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public int age { get; set; }

        [Display(Name = "Почта")]
        [Required(ErrorMessage = "Вам нужно ввести почту")]
        public string email { get; set; }

        [Display(Name = "Сообщение")]
        [Required(ErrorMessage = "Вам нужно ввести сообщение")]
        [StringLength(30, ErrorMessage = "Текст не менее 30 символов")]
        public string message { get; set; }

    }
}
