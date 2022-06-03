using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Game_Center;
using Game_Center.Games.Pong;
using Game_Center.Games;

namespace Game_Center
{
    class ConnectDB
    {
        int score;
        Pong2Players pong2 = new();
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

        public void Update()
        {
            int total = 100;
            score += total;
            conn.Open();
            SQLiteCommand comm = new(conn);
            {
                comm.CommandText = "SELECT NickName FROM UserData";
                var UserDataId = comm.ExecuteScalar();
                if (UserDataId != null && UserDataId != DBNull.Value)
                {
                    comm.CommandText = "UPDATE UserData SET Score = '" + score + "' WHERE NickName = @NickName";
                    comm.Parameters.AddWithValue("@NickName", UserDataId);
                    comm.ExecuteNonQuery();
                }
            }
        }
    }
}
        

    
    
   
    

