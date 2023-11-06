using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleBleue
{
    public class Jeu
    {
        List<Room>? rooms;
        Room currentRoom;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        public static string nextRoom = "";
        public static bool HasRedKey = false;
        public static bool HasBlueKey = false;

        public Jeu()
        {
            this.rooms = new List<Room>();
        }

        internal void Add(Room room)
        {
            if (rooms == null)
            {
                return;
            }

            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
            }
        }

        public void SetCurrentRoom(Room room)
        {
            currentRoom = room;
        }

        internal void CurrentRoomDescription() 
        {
            currentRoom.ViewDescription();
        }

        internal void ReceiveChoice(string choice)
        {
            currentRoom.ReceiveChoice(choice);
            CheckTransition();
        }

        internal static void Finish()
        {
            isFinished = true;
        }

        internal void CheckTransition()
        {
            if (rooms != null && rooms.Count != 0)
            {
                foreach (var room in rooms)
                {
                    if (room.GetType().Name == /*room.nextRoomToGo*/ nextRoom)
                    {
                        nextRoom = "";
                        currentRoom = room;
                        break;
                    }
                }
            }
        }
    }
}
  
