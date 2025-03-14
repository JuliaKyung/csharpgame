﻿using System;
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
             Classroom ---- Kitchen
               |
             Park ----- Forest
             */
            _map = new RoomList
            {       //                                                                              N           S           W           E
                {Rm.Classroom, new Room("Classroom", "a deserted classroom. The desks are overturned and there are unintelligible symbols on the whiteboard. \r\n" +
                "Upon closer inspection, you think you can read the symbols. Code?\r\n" +
                "A ghost of a man sits at one of the upright desks. ", Rm.NOEXIT, Rm.Park, Rm.NOEXIT, Rm.Kitchen,
                    new ThingList
                    {
                        new Thing("code", "You look closer at the code haphazardly written all over the whiteboard. You can only make out a small bit of it: [type Msg = Increment | Decrement]", false),
                        new Thing("man", "'Who are you?' you ask the man. \r\n" +
                        "\r\n" +
                        "The man looks up quickly, as if he hadn't noticed your presence. He shuffles a bit in his seat and then smiles.\r\n" +
                        "'Well, my name is Nel! Are you here for morning standup?'\r\n" +
                        "\r\n" +
                        "'I'm sorry, morning what?' You respond. What the hell was that? 'Do ghosts often do these things?'\r\n" +
                        "\r\n" +
                        "At that, Nel looks confused. 'Ghosts? There's ghosts here?'", false)
                    }) },
                { Rm.Kitchen, new Room("Kitchen", "a messy kitchen. It looks like there hasn't been anyone in here in years.\r\n" +
                "You see a small black cat perched atop the counter, knocking over the old, rusted dishes. You wonder why it gives off a strange aura...", Rm.NOEXIT, Rm.NOEXIT, Rm.Classroom, Rm.NOEXIT, 
                    new ThingList { 
                        new Thing("cat", "You walk up slowly to the cat, that has since stopped knocking over dishes in favor of staring at you.\r\n" +
                        "'Hey there, Kitty--' you start, but are abruptly, and shockingly, cut off.\r\n" +
                        "\r\n" +
                        "'Don't /Kitty/ me! I have a name you know. It's Ffej!' The cat snaps. How?\r\n" +
                        "'I bet you're wondering how I can talk, huh?' The cat - Ffej, starts, 'Well I wasn't always like this.'\r\n" +
                        "\r\n" +
                        "'What? What happened?' You ask.\r\n" +
                        "\r\n" +
                        "'Well, I used to be a person, a student here, actually, but I showed up late too many times, I can't remember - all I know is one minute I'm" +
                        " apologizing and the next I wake up here in a broken down building and also a cat.'\r\n" +
                        "\r\n" +
                        "Stunned beyond words, you gape at Ffej for a moment before shaking your head. 'Uh, well I'm kind of lost. If you want, you can come with me? Maybe we can help your... condition.'\r\n" +
                        "\r\n" +
                        "Ffej looks at you for a moment, weighing his options before doing the cat version of a shrug. 'Eh, why not.' He responds")
                    }) },
                { Rm.Park, new Room("Park", "a small park outside of the building. The ground is covered in a layer of fog. Somehow, you don't feel any more safe here than when you were inside. Another ghost sits on one of the dusty benches.\r\n" +
                "Though, instead of the calm blue aura that radiated from Nel, this one was red.", Rm.Classroom, Rm.NOEXIT, Rm.NOEXIT, Rm.Forest, new ThingList { 
                    new Thing("ghost", "You approach the ghost cautiously, though he doesn't seem to notice you while he rants.\r\n" +
                    "\r\n" +
                    "'I can't believe it! I can't believe he took my power!!' he screamed into the void.\r\n" +
                    "\r\n" +
                    "'Who took your power?' You ask. The ghost finally seems to notice you, glaring fiercely.\r\n" +
                    "\r\n" +
                    "'ROGER! I just don't understand! How can one man have so much power!?'\r\n" +
                    "\r\n" +
                    "'Roger?' You ask, 'What did Roger do? Where is he?'\r\n" +
                    "\r\n" +
                    "'I taught him everything I know, and he BETRAYED me! Led this land to ruin!' The ghost shoves up to your face; you can almost feel his breath tickle your nose.\r\n" +
                    "'If you see that man, fight him. And win. Tell him Vic sent you!'", false)
                    }) },
                { Rm.Forest, new Room("Forest", "an opening to a forest. The trees don't look quite right, but you can't put your finger on why.\r\n" +
                "You see a crumpled piece of paper on the forest floor, strangely untouched. What could that paper be?", Rm.NOEXIT, Rm.NOEXIT, Rm.Park, Rm.NOEXIT, new ThingList { 
                    new Thing("paper", "You bend down to pick up the piece of paper. It looks to be the start of a letter, though many of the words are smudged. You try to read what you can make out:\r\n" +
                    "'A C T I V A T E W I N D O W S ™'")
                    })}
            };

            _player = new Actor("You", "The Player", _map.RoomAt(Rm.Classroom), new ThingList());
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
                s = $"You're now in {_player.Location.Name}. It is {_player.Location.Description}\r\n";

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
