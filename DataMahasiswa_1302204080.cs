using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal6
{
    public class DataMahasiswa_1302204080
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public address address { get; set; }
        public List<courses> courses { get; set; }



        public DataMahasiswa_1302204080() { }
        public DataMahasiswa_1302204080(string nama1, string nama2, string kelamin, int umur)
        {
            firstName = nama1;
            lastName = nama2;   
            gender = kelamin;
            age = umur;
        }



    }

    public class address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public address() { }
    }

    public class courses
    {
        public string code { get; set; }
        public string name { get; set; }

        public courses() { }

    }

}
