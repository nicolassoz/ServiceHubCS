using Servicehub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace ServiceHubClass
{
    internal class Nivel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Nivel() 
        {
            Id = 0;
        }

        public Nivel(int id) 
        {
            Id = id;
        }

        public Nivel(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public Nivel(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            if(cmd.Connection.State == ConnectionState.Open) 
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_nivel_insert";
                cmd.Parameters.AddWithValue("spnome",Nome);
                cmd.Parameters.AddWithValue("spSigla",Sigla);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        }

        public static Nivel ObterPorId(int id) 
        {
            Nivel cat = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from nivel where id = {id}";
        }
    }
}
