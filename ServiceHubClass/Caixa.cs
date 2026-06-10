using Servicehub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceHubClass
{
    public class Caixa
    {
        // propriedades
        public int Id { get; set; }
        public int Usuario_Id { get; set; }
        public DateTime Data_abertura { get; set; }
        public decimal Saldo_Inicial { get; set; }
        public char Status { get; set; }
        // Métodos Construtores

        public Caixa() { }

        public Caixa(DateTime data_abertura, decimal saldo_inicial, char status) 
        {
            Data_abertura = data_abertura;
            Saldo_Inicial = saldo_inicial;
            Status = status;
        }

        public Caixa(int id,int usuario_id,  DateTime data_abertura, decimal saldo_inicial, char status)
        {
            Id = id;
            Usuario_Id = usuario_id;
            Data_abertura = data_abertura;
            Saldo_Inicial = saldo_inicial;
            Status = status;
        }

        public Caixa(int usuario_id, DateTime data_abertura, decimal saldo_inicial, char status)
        {
            Usuario_Id = usuario_id;
            Data_abertura = data_abertura;
            Saldo_Inicial = saldo_inicial;
            Status = status;
        }

        //Métodos

        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open) 
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_caixa_insert";
                cmd.Parameters.AddWithValue("spusuario_id",Usuario_Id);
                cmd.Parameters.AddWithValue("spdata_abertura",Data_abertura);
                cmd.Parameters.AddWithValue("spsaldo_inicial", Saldo_Inicial);
                cmd.Parameters.AddWithValue("spStatus", Status);
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
            cmd.CommandText = "sp_caixa_update";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.Parameters.AddWithValue("spusuario_id",Usuario_Id);
            cmd.Parameters.AddWithValue("spdata_abertura",Data_abertura);
            cmd.Parameters.AddWithValue("spsaldo_inicial",Saldo_Inicial);
            cmd.Parameters.AddWithValue("spstatus",Status);
            if (cmd.ExecuteNonQuery() > 0)
                atualizar = true;
            cmd.Connection.Close();
            return atualizar;
        }

        public static Caixa ObterPorId(int id) 
        {
            Caixa caixa = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from caixas where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                caixa = new
                    (
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetDateTime(2),
                        dr.GetDecimal(3),
                        dr.GetChar(4)
                    );
            }
            dr.Close();
            cmd.Connection.Close();
            return caixa;
        }

        public static List<Caixa> ObetrLista(string busca = "") 
        {
            List<Caixa> caixa = new();
            var cmd = Banco.Abrir();
            if(cmd.Connection.State == ConnectionState.Open) 
            {
                if (busca != "")
                    cmd.CommandText = $"select * from caixas where usuario_id like '%{busca}%'" +
                        $" or id like '%{busca}%' order by nome";
                else
                    cmd.CommandText = $"select * from caixas order by usuario_id";

                cmd.CommandType = CommandType.Text;

                var dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    caixa.Add(new
                        (
                            dr.GetInt32(0),
                            dr.GetInt32(1),
                            dr.GetDateTime(2),
                            dr.GetDecimal(3),
                            dr.GetChar(4)
                        ));
                }
                dr.Close();
                cmd.Connection.Close();
            }
            return caixa;
        }
    }
}
