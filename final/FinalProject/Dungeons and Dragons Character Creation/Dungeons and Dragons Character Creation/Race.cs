using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_Character_Creation
{
    internal class Race
    {
        private string _dwarf;
        private string _elf;
        private string _halfling;
        private string _human;
        private string _dragonborn;
        private string _gnome;
        private string _halfElf;
        private string _halfOrc;
        private string _tiefling;

        public Race()
        {
            _dwarf = ""; 
            _elf = ""; 
            _halfling = "";
            _human = "";
            _dragonborn = "";
            _gnome = "";
            _halfElf = "";
            _halfOrc = "";
            _tiefling = "";

        }
        public void SetTiefling(string race)
        {
            race = _tiefling;
        }
        public string GetTiefling()
        {
            return _tiefling;
        }
        public void SetHalfOrc(string cRace)
        {
            cRace = _halfOrc;
        }
        public string GetHalfOrc()
        {
            return _halfOrc;
        }
        public void SetHalfElf(string cRace)
        {
            cRace = _halfElf;
        }
        public string GetHalfElf()
        {
            return _halfElf;
        }
        public void SetGnome(string cRace)
        {
            cRace = _gnome;
        }
        public string GetGnome()
        {
            return _gnome;
        }
        public void  SetDragonborn(string cRace)
        {
            cRace = _dragonborn;
        }
        public string GetDragonborn()
        {
            return _dragonborn;
        }
        public void SetHuman(string cRace)
        {
            cRace = _human;
        }
        public string GetHuman()
        {
            return _human;
        }
        public void SetHalfling(string cRace)
        {
            cRace = _halfling;
        }
        public string GetHalfling()
        {
            return _halfling;
        }
        public void SetElf(string cRace)
        {
            cRace = _elf;
        }
        public string GetElf()
        {
            return _elf;
        }
        public void SetDwarf(string cRace)
        {
            cRace = _dwarf;
        }
        public string GetDwarfRace()
        {
            return _dwarf;
        }

    }
}
