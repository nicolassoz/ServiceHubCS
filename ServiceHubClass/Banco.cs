using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ServiceHubClass;

namespace Servicehub
{
    public static class Banco
    {
        //string de conexão com o banco de dados (Mariadb)
        public static string? StrConn { get; set; }

        //método para abrir conexão com o banco - entrega uma conexão aberta,
        //no objeto de comandos Sql (um objeto do tipo MySqlCommand)
        public static MySqlCommand Abrir(string strconn = "")
        {
            MySqlCommand cmd = new MySqlCommand(); //pode ser apenas new()
            StrConn = strconn;
            if (StrConn == string.Empty)
                //StrConn = $@"server=10.91.47.41;database=servicehubdb01;user=root;password=P@ssw0rd";
            StrConn = $@"server=10.91.47.41;database=comecialti101;user=root;password=P@ssw0rd";

            MySqlConnection cn = new(StrConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }
    }
}
