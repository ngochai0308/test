using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Huong doi tuong trong C#");

            //Khai bao doi tuong
            Album album=new Album();
            Album album1= new Album(90,"Nga tu khong den",1);
            Console.WriteLine("Tieu de bai hat la: "+ album.Title);
            Console.WriteLine("Tieu de bai hat 1 la: " + album1.Title);
            Artist artist=new Artist(1,"Nguyen Anh Tu","Mot ca nhac si");
            artist.Display();
            Console.WriteLine("Nhap nghe si tu ban phim");
            Artist artist1 = new Artist();
            Console.Write("Nhap id: ");
            artist1.Id =Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten: ");
            artist1.Name=Convert.ToString(Console.ReadLine());
            Console.Write("Tieu su: ");
            artist1.Bio=Console.ReadLine();
            artist1.Display();
            //playlist Song
            PlaylistSong playlist=new PlaylistSong();
            playlist.SongId = 5;
            playlist.PlaylistId = 6;
            Console.WriteLine($"SongId: {playlist.SongId},playlistID: {playlist.PlaylistId}");

            //Day la thay doi nhe
            Song song=new Song(1,"Tim duoc nhau kho the nao",1,1,10000);
            song.Display();
            

            Console.ReadLine();
        }
    }
}
