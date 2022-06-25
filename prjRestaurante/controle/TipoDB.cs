using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRestaurante.controle
{
    class TipoDB
    {
        string con = Conexao.Open("localhost", "restaurantedb", "root", "minas");

        public object SelectAll()
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;

                var query = from linhas in banco.tipo
                            orderby linhas.idtipo
                            select linhas;
                return query.ToList();
            }
        }
        public void Inserir(modelo.tipo reg)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                banco.tipo.Add(reg);
                banco.SaveChanges();
            }
        }
        public void Editar(modelo.tipo reg)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                modelo.tipo velho = banco.tipo.First(i => i.idtipo == reg.idtipo);
                banco.Entry(velho).CurrentValues.SetValues(reg);
                banco.SaveChanges();
            }
        }
        public void Excluir(int codigo)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                modelo.tipo reg = banco.tipo.First(i => i.idtipo == codigo);
                banco.tipo.Remove(reg);
                banco.SaveChanges();
            }
        }
        public int ProximoCodigo()
        {
            int cod = 0;
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                try
                {
                    return banco.tipo.Max(i => i.idtipo) + 1;
                }
                catch (Exception)
                {
                    cod = 1;
                }
                return cod;
            }
        }
    }
}
