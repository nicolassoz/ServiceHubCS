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
    }
}
