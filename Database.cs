using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_proekt
{
   
    
    class Database
    {
        public static int n;
        public static int m;
        public struct AccountsData
        {
           
            public string Login;
            public string Password;
            public string Role; 
        }
        public static AccountsData[] User;
        public struct TrainData
        {
            public string number;
            public string pn;
            public string data;
            public string to;
            public string tp;
            public string s;
            public string ob;
            public string pb;

        }
        public static TrainData[] rase;
           

    }
}
