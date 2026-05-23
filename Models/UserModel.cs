using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStoreProject.Models
{
    public class UserModel
    {

        public string Role { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public string FullName => $"{Surname} {Name} {Patronymic}";
    }
}
