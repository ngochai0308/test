using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public int UserID { get; set; }

        public Playlist() { }
        public Playlist(int id, string title,int userID) 
        { 
            Id= id;
            Title= title;
            UserID= userID;
        }
        public void Display()
        {
            Console.WriteLine($"id: {Id},Title: {Title}, User id:{UserID}");
        }
    }
}
