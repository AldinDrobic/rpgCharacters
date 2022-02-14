using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgCharacters.Models.Exceptions
{
    public class InvalidItemException : Exception
    {
        public InvalidItemException()
        {
        }
        public InvalidItemException(string message) : base(message)
        {
        }
        public override string Message => "You can't equip this item, you already have one equipped!";
    }
}
