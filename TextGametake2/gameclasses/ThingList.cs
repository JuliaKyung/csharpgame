﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGametake2.gameclasses
{
    [Serializable]
    public class ThingList : List<Thing>
    {
        public string Describe()
        {
            string s = "";
            if(this.Count == 0)
            {
                s = "There's nothing here\r\n";
            } else
            {
                foreach(Thing t in this)
                {
                    s = s + t.Name + "; ";
                }
            }
            return s;
        }

        public Thing ThisOb(string aName)
        {
            Thing athing = null;
            string thingName = "";
            string aNameLowCase = aName.Trim().ToLower();
            foreach(Thing t in this)
            {
                thingName = t.Name.Trim().ToLower();
                if (thingName.Equals(aNameLowCase))
                {
                    athing = t;
                }
            }
            return athing;
        }
    }
}
