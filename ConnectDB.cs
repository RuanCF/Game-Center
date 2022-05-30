using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Game_Center.Games;

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

        public void Update()
        {
            GameLobby gameLobby = new();
            int score = gameLobby.total;
            conn.Open();
            SQLiteCommand comm = new(conn);
            {
                comm.CommandText = "SELECT Id FROM UserData";
                var UserDataId = comm.ExecuteScalar();
                if (UserDataId != null && UserDataId != DBNull.Value)
                {
                    comm.CommandText = "UPDATE UserData SET Score = +'" + score + "' WHERE Id = @Id";
                    comm.Parameters.AddWithValue("@Id", UserDataId);
                    comm.ExecuteNonQuery();
                }
            }
        }
    }
}
        

    
    
   
    

