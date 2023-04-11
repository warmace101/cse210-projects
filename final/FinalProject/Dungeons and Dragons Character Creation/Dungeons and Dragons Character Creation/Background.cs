using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace Dungeons_and_Dragons_Character_Creation
{
  public class Background
    {
        private string _background;

        public Background()
        {

            _background = "";


        }

        public void SetBackground(string background)
        {
            _background = background;
        }
        public string GetBackground()
        { return _background; }
    }
}
