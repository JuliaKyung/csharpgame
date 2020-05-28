using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGametake2.gameclasses
{
    [Serializable]
    public class Thing
    {
        private string _name;
        private string _description;
        private bool _cantake;

        public Thing(string aName, string aDescription)
        {
            _name = aName;
            _description = aDescription;
            _cantake = true;
        }

        public Thing(string aName, string aDescription, bool aCanTake)
        {
            _name = aName;
            _description = aDescription;
            _cantake = aCanTake;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public bool CanTake
        {
            get => _cantake;
            set => _cantake = value;
        }

        public virtual string Describe()
        {
            return Name + " " + Description;
        }
    }
}
