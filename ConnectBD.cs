using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Game_Center
{
    class ConnectBD

    {
       public SQLiteConnection conn = new SQLiteConnection("Data Source=UserCase.sdb");

        public void conectar()
        {
            conn.Open();
        }

        public void desconectar()
        {
            conn.Close();
        }
    }
   }
        

    
    
   
    

