﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGametake2.gameclasses
{
    [Serializable]
    public class ThingHolder : Thing
    {
        private ThingList _things = new ThingList();

        public ThingHolder(string aName, string aDescription, ThingList tl)
            : base(aName, aDescription)
        {
            _things = tl;
        }

        public ThingList Things
        {
            get => _things;
            set => _things = value;
        }

        public void AddThing(Thing aThing)
        {
            _things.Add(aThing);
        }

        public void AddThings(ThingList aThingList)
        {
            _things.AddRange(aThingList);
        }

        public override string Describe()
        {
            return $"Name: {Name} Description: {Description} - It's got {_things.Describe()}";
        }
    }
}
