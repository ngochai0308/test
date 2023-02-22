using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp
{
    internal class FavouriteSong
    {
        public int SongId { get; set; }
        public int UserId { get; set; }
        public FavouriteSong() { }
        public FavouriteSong(int songId,int userID)
        {
            SongId = songId;
            UserId=userID;
        }
    }
}
