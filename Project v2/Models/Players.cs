using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_v2.Models
{

    [Table("Players", Schema = "nba")]
    public class Players
    {
        private int _id;
        private string _name;

        [Key]
        public int id { get { return _id; } set { _id = value; } }

        [Required(ErrorMessage ="Имя игрока обязательно")]
        [StringLength(20, ErrorMessage = "Длина имени не должна превышать 20 символов")]
        [Display (Name = "Имя игрока")]
        public string name { get { return _name; } set { _name = value; } }


        public Players() { }

        public Players(int id, string name) 
        {
            _id = id;
            _name = name;
        }

    }
}
