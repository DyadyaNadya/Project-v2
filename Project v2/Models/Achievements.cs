using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_v2.Models
{
    [Table("Achievements", Schema = "nba")]
    public class Achievements
    {
        private int _id;
        private string _achievename;
        private int _playerid;
        private int _teamid;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Display(Name = "Название достижения")]
        public string achievename
        {
            get { return _achievename; }
            set { _achievename = value; }
        }

        [Display(Name = "ID Игрока")]
        public int playerid
        {
            get { return _playerid; }
            set { _playerid = value; }
        }

        [Display(Name = "ID Команды")]
        public int teamid
        {
            get { return _teamid; }
            set { _teamid = value; }
        }


        public Achievements() { }

        public Achievements(int id, string achievename, int playerid, int teamid)
        {
            _id = id;
            _achievename = achievename;
            _playerid = playerid;
            _teamid = teamid;
        }

    }
}
