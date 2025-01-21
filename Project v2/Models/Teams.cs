using System.ComponentModel.DataAnnotations;

namespace Project_v2.Models
{
    public class Teams
    {
        private int _id;
        private string _name;

        [Key]
        public int id {
            get { return _id; }
            set { _id = value; }
        }

        [Display(Name = "Название команды")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Teams() { }

        public Teams(int id, string name) 
        { 
            _id = id;
            _name = name;
        }
    }
}
