using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue
{
    public abstract class Room
    {
        public string nextRoomToGo ="";
        internal abstract void ViewDescription();
        internal abstract void ReceiveChoice(string choice);
    }
}
