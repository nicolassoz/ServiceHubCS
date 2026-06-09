using Servicehub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceHubClass
{
    public class Usuario
    {
        // propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Nivel { get; set; }
        public bool Ativo { get; set; }

        // Métodos Construtores

        public Usuario() { }

        public Usuario(string nome, string email, string senha, int nivel) 
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }

        public Usuario(int id, string nome, string email, string senha, int nivel)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }

        public Usuario(int id, string nome, string email, string senha, int nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        //Métodos

        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_usuario_insert";
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spemail", Email);
                cmd.Parameters.AddWithValue("spsenha", Senha);
                cmd.Parameters.AddWithValue("spnivel", Nivel);
                cmd.Parameters.AddWithValue("spativo", Ativo);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        }

        public bool Atualizar() 
        {
            bool atualizar = false;
            if (Id < 1)
                return atualizar;

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.Parameters.AddWithValue("spnome",Nome);
            cmd.Parameters.AddWithValue("spemail",Email);
            cmd.Parameters.AddWithValue("spsenha",Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel);
            if (cmd.ExecuteNonQuery() > 0)
                atualizar = true;
            cmd.Connection.Close();
            return atualizar;
        }

        public static Usuario ObterPorId(int id) 
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new
                    (dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetInt32(4),
                    dr.GetBoolean(5));
            }
            dr.Close();
            cmd.Connection.Close();
            return usuario;
        }

        public static List<Usuario> ObterLista(string busca = "") 
        {
            List<Usuario> usuario = new();
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open) 
            {
                if (busca != "")
                    cmd.CommandText = $"select * from usuarios where nome like '%{busca}%' or id like '%{busca}%' order by nome";
                else
                    cmd.CommandText = $"select * from usuarios order by nome";

                    cmd.CommandType = CommandType.Text;
                
                var dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    usuario.Add(new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetInt32(4),
                        dr.GetBoolean(5))
                        );
                }
                dr.Close();
                cmd.Connection.Close();
            }
            return usuario;
        }

        public void excluir() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_delete";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
