using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp
{
    internal class Artist
    {
        private int _id;
        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _bio;
        public string Bio
        {
            get { return _bio; }
            set { _bio = value; }
        }
        public Artist()
        {

        }
        public Artist(int id,string name,string bio)
        {
            _id = id;
            _name = name;
            _bio = bio;
        }
        public void Display()
        {
            Console.WriteLine($"id: {_id},Ten ca si: {_name},Tieu su: {_bio}");
        }

    }
}
