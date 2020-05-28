using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGametake2.gameclasses;

namespace TextGametake2
{
    [Serializable]
    public partial class Adventure
    {
        private RoomList _map;
        private Actor _player;

        public Adventure()
        {
            /*
             RoomOne ---- RoomTwo
               |
             RoomThree ----- RoomFour
             */
            _map = new RoomList
            {
                {Rm.RoomOne, new Room("Room One", "HOW MANY TIMES ARE YOU GONNA CHANGE THIS", Rm.NOEXIT, Rm.RoomTwo, Rm.NOEXIT, Rm.RoomThree,
                    new ThingList
                    {
                        new Thing("Tester item", "It is a tester item"),
                        new Thing("Second item", "Second item", false)
                    }) },
                { Rm.RoomTwo, new Room("Room two", "WOWOWOWOWO", Rm.NOEXIT, Rm.NOEXIT, Rm.RoomOne, Rm.NOEXIT, 
                    new ThingList { 
                        new Thing("tester item", "another one")
                    }) },
                { Rm.RoomThree, new Room("Room three", "WOWOWOWOWO", Rm.RoomOne, Rm.NOEXIT, Rm.NOEXIT, Rm.RoomFour, new ThingList()) },
                { Rm.RoomFour, new Room("Room four", "WOWOWOWOWO", Rm.NOEXIT, Rm.NOEXIT, Rm.RoomThree, Rm.NOEXIT, new ThingList())}
            };

            _player = new Actor("You", "The Player", _map.RoomAt(Rm.RoomOne), new ThingList());
        }

        public Actor Player
        {
            get => _player;
        }

        private void MoveActorTo(Actor anActor, Room aRoom)
        {
            anActor.Location = aRoom;
        }

        private Rm MoveTo(Actor anActor, Dir direction)
        {
            Room r = anActor.Location;
            Rm exit;

            switch (direction)
            {
                case Dir.NORTH:
                    exit = r.N;
                    break;

                case Dir.SOUTH:
                    exit = r.S;
                    break;

                case Dir.EAST:
                    exit = r.E;
                    break;

                case Dir.WEST:
                    exit = r.W;
                    break;

                default:
                    exit = Rm.NOEXIT;
                    break;
            }
            if(exit != Rm.NOEXIT)
            {
                MoveActorTo(anActor, _map.RoomAt(exit));
            }
            return exit;
        }

        public string MovePlayerTo(Dir direction)
        {
            string s;
            if (MoveTo(_player, direction) == Rm.NOEXIT)
            {
                s = "You can't go this way dingdong\r\n";
            }
            else
            {
                s = $"You're now in {_player.Location.Name}\r\n";
            }
            return s;
        }

        private void TransferOb(Thing t, ThingList fromlist, ThingList tolist)
        {
            fromlist.Remove(t);
            tolist.Add(t);
        }

        public string TakeOb(string obname)
        {
            Thing t = _player.Location.Things.ThisOb(obname);
            string s = "";
            if(obname == "")
            {
                obname = "unknown object"; //if no object specified??
            }
            if(t == null)
            {
                s = $"yo {obname} is not here bro";
            } else
            {
                if (t.CanTake)
                {
                    TransferOb(t, _player.Location.Things, _player.Things);
                    s = t.Name + " Yoinked";
                } else
                {
                    s = "You can't take this dude";
                }
            }
            return s;
        }

        public string DropOb(string obname)
        {
            Thing t = _player.Things.ThisOb(obname);
            string s = "";
            if(t == null)
            {
                s = "You don't have this dude";
            } else
            {
                TransferOb(t, _player.Things, _player.Location.Things);
                s = t.Name + " yeeted";
            }
            return s;
        }

        public string LookAtOb(string obname)
        {
            Thing t;
            string s = "";
            if(obname == "")
            {
                s = "What do you want to look at dude??";
            } else
            {
                t = _player.Location.Things.ThisOb(obname);
                if(t == null)
                {
                    t = _player.Things.ThisOb(obname);
                }
                if(t == null)
                {
                    s = $"There's no {obname} here yo";
                } else
                {
                    s = t.Description + ".";
                }
            }
            return s;
        }
    }
}
