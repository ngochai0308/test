using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp
{
    internal class Album
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        private int _atistID;
        public int AtistID
        {
            get
            {
                return _atistID;
            }
            set
            { 
                _atistID = value;
            }
        }
        public Album()
        {
            _id= 01;
            _title= "Gap duoc nhau kho the nao";
            _atistID= 01;
        }
        public Album(int id,string title,int artistID)
        {
            _id = id;
            _title = title;
            _atistID= artistID;
        }
    }
}
