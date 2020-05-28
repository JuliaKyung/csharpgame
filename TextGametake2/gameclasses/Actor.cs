using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextGametake2.gameclasses //nested namespace
{
    [Serializable]
    public class Actor : ThingHolder
    {
        private Room _location; //where the actor is currently at

        public Actor(string aName, string aDescription, Room aRoom, ThingList tl) :
            base(aName, aDescription, tl)
        {
            _location = aRoom;
        }

        public Room Location
        {
            get => _location;
            set => _location = value;
        }

        public override string Describe()
        {
            return $"[{Name}] ({Description}) is in {_location.Describe()}";
        }
    }
}
