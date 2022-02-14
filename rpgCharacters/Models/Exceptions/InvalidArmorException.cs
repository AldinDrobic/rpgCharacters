using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models.Exceptions
{
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException()
        {
        }
        public InvalidArmorException(string message) : base(message)
        {
        }
        public override string Message => "You can't equip that armor!";
    }
}
