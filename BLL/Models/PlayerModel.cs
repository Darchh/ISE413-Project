using BLL.DAL;
using System.ComponentModel;

namespace BLL.Models
{
    public class PlayerModel
    {
        public Player Record { get; set; }

        public string Name => Record.Name;

        public string Surname => Record.Surname;

        [DisplayName("Female")]
        
        public string IsFemale => Record.IsFemale ? "Yes" : "No";

        [DisplayName("Birth Date")]
        public string Birthdate => !Record.Birthdate.HasValue ? string.Empty : Record.Birthdate.Value.ToString("MM/dd/yyyy");
        public string Team => Record.Team?.Name;

    }
}
