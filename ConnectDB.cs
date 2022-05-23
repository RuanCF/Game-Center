using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Game_Center
{
    class ConnectDB
    {
        #region Declaração
        public SQLiteConnection conn = new("Data Source=UserCenter.sdb");
        #endregion

        public void Conectar()
        {
            conn.Open();
        }

        public void Desconectar()
        {
            conn.Close();
        }
    }
}
        

    
    
   
    

