using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextGametake2.gameclasses
{
    [Serializable]
    public class RoomList : Dictionary<Rm, Room>
    {
        protected RoomList(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            //constructor for serialization
        }
        public RoomList()
        {

        }

        public Room RoomAt(Rm id)
        {
            return this[id];
        }

        public string Describe() //don't need to override because it is not a descendant of Thing
        {
            string s = "";
            if(this.Count == 0)
            {
                s = "Nothing in roomlist";
            } else
            {
                foreach(KeyValuePair<Rm, Room> kv in this)
                {
                    s = s + kv.Value.Describe() + "\r\n";
                }
            }
            return s;
        }
    }
}
