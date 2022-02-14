using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models.Exceptions
{
    public class InvalidWeaponException: Exception
    {
        public InvalidWeaponException()
        {
        }
        public InvalidWeaponException(string message) : base(message)
        {
        }
        public override string Message => "You can't equip that weapon!";
    }
}
