using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp
{
    internal class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ArtistID { get; set; }
        public int AlbumId { get; set; }
        public int ViewCount { get; set; }
        public Song()
        {

        }
        public Song(int id, string title, int artistID, int albumId, int viewCount)
        {
            Id = id;
            Title = title;
            ArtistID = artistID;
            AlbumId = albumId;
            ViewCount = viewCount;
        }
        public void Display()
        {
            Console.WriteLine($"Ma bai hat: {this.Id}\n" +
                $"Ten bai hat: {this.Title}\n" +
                $"Ma Nghe si: {this.ArtistID}\n" +
                $"Ma album: {this.AlbumId}\n" +
                $"View: {this.ViewCount}");
        }
    }
}
