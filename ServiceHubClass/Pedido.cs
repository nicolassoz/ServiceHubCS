using Google.Protobuf.WellKnownTypes;
using Servicehub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceHubClass
{
    public class Pedido
    {
        // propriedades
        public int Id { get; set; }
        public int Usuario_Id { get; set; }
        public int Cliente_Id { get; set; }
        public DateTime Data { get; set; }
        public char Status { get; set; }
        public decimal Desconto { get; set; }

        // Métodos Construtores

        public Pedido() { }

        public Pedido(DateTime data, char status, decimal desconto) 
        {
            Data = data;
            Status = status;
            Desconto = desconto;
        }

        public Pedido(int id, int usuario_id, int cliente_id, DateTime data, char status, decimal desconto)
        {
            Id = id;
            Usuario_Id = usuario_id;
            Cliente_Id = cliente_id;
            Data = data;
            Status = status;
            Desconto = desconto;
        }

        //Métodos

        public static List<Pedido> ObterLista(string busca) 
        {
            List<Pedido> pedido = new();
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open) 
            {
                    cmd.CommandText = $"select * from pedidos where id like '%{busca}%' or id like '%{busca}%' order by id";

                    cmd.CommandText = $"select * from pedidos order by id";

                    cmd.CommandType = CommandType.Text;

                var dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    pedido.Add(new(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetInt32(2),
                        dr.GetDateTime(3),
                        dr.GetChar(4),
                        dr.GetDecimal(5))
                        );
                }
                dr.Close();
                cmd.Connection.Close();
            }
            return pedido;
        }
    }
}
