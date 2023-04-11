using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_Character_Creation
{
    public class Classes
    {
        private string _barbarian;
        private string _bard;
        private string _cleric;

        public Classes()
        {
            _barbarian = "";
            _bard = "";
            _cleric = "";
        }

        public void SetBarbarian(string barbarian)
        {
            _barbarian = barbarian;

        }

        public string GetBarbarian()
        {
            return _barbarian;
        }

        public void SetBard(string bard)
        {
            _bard = bard;
        }
        public string GetBard()
        {
            return _bard;
        }
        public void SetCleric(string cleric) 
        { 
            _cleric = cleric;
        }
        public string GetCleric()
        {
            return _cleric;
        }
    }
}
