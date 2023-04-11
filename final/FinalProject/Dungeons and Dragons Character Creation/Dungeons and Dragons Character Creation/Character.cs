using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_Character_Creation
{
    abstract class Character
    {
        private string _name;
        private string _background;
        private int _level;
        private string _alignment;
        private string _class;
        private string _race;
        private int _xp;

        public Character()
        {
            _name = "";
            _background = "";
            _level = 0;
            _alignment = " ";
            _class = " ";
            _race = " ";
            _xp = 0;
        }

    }
}
