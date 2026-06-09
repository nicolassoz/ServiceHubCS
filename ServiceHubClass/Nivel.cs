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
    public class Nivel
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
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cat = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
            cmd.Connection.Close();
            return cat;
        }

        public static List<Nivel> ObterLista(string busca = "") 
        {
            List<Nivel> nivel = new List<Nivel>();
            var cmd = Banco.Abrir();
            if(cmd.Connection.State == ConnectionState.Open) 
            {
                if (busca != "") 
                {
                    cmd.CommandText = $"select * from niveis where nome like '%{busca}%' or id like '%{busca}%' order by nome";
                }
                else 
                {
                    cmd.CommandText = "Select * from niveis order by nome";
                }
                    cmd.CommandType = CommandType.Text;

                var dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    nivel.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
                }
                dr.Close();
                cmd.Connection.Close();
            }
            return nivel;
        }

        public bool Atualizar() 
        {
            // como este método não é estático, precisamos considerar que as propriedades
            // já possuam valores atribuídos antes de chamá-lo
            bool atualizado = false;
            if (Id < 1)
                return atualizado;

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "sp_nivel_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            if (cmd.ExecuteNonQuery() > 0) atualizado = true;
            cmd.Connection.Close();
            return atualizado;
        }

        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
