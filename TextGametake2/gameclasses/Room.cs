using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGametake2.gameclasses
{
    [Serializable]
    public class Room : ThingHolder
    {
        private Rm _n, _s, _e, _w;

        public Room(string aName, string aDescription, Rm aN, Rm aS, Rm aW, Rm aE, ThingList tl)
            : base(aName, aDescription, tl)
        {
            _n = aN;
            _s = aS;
            _e = aE;
            _w = aW;
        }
        
        public Rm N
        {
            get => _n;
            set => _n = value;
        }

        public Rm S
        {
            get => _s;
            set => _s = value;
        }

        public Rm E
        {
            get => _e;
            set => _e = value;
        }

        public Rm W
        {
            get => _w;
            set => _w = value;
        }

        public override string Describe()
        {
            return $"[{Name}] this is {Description} " + Things.Describe();
        }
    }
}
