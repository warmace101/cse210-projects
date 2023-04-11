using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_Character_Creation
{
    abstract class Equipment
    {
        private string _armour;
        private string _weapon;
        public Equipment() 
        {
            _armour = "";
            _weapon = "";
        }

        public void SetWeapon(string weapon)
        {
            _weapon= weapon;
        }
        public string GetWeapon()
        {
            return _weapon;
        }
        public void SetArmour(string armour)
        {
            _armour = armour;
        }
        public string GetArmour()
        {
            return _armour;
        }
    }
}
