using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Servicehub;
using System.Data;

namespace ServiceHubClass
{
    public class Categoria
    {
        // atributos (Campos)
        /*private readonly int id;
        private string? nome;
        private string? sigla;*/

        //propriedades
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        // construtores (Métodos)
        public Categoria() 
        {
            Id = 0;
        }
        // Métodos (Fucionalidades RFs) = inserir, atualizar, listar, obterPorId(id)
        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open) 
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_categoria_insert";
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsigla", Sigla);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        }

        public static Categoria ObterPorId(int id) 
        {
            Categoria cat = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from cetegoriras where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                cat = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
            cmd.Connection.Close ();
        }
    }
}
