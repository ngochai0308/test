using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp
{
    internal class PlaylistSong
    {
        public int SongId { get; set; }
        public int PlaylistId { get; set; }

        public PlaylistSong() { }
        public PlaylistSong(int songId,int playlistID)
        {
            SongId = songId;
            PlaylistId = playlistID;
        }
    }
}
