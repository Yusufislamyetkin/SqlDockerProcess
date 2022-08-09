using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebAPI.Model
{
    public class User
    {
        [Key]
        public int ıd { get; set; }
        public string name { get; set; }
    }
}
