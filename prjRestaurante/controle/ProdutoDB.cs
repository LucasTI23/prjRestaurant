using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRestaurante.controle
{
    class ProdutoDB
    {
        string con = Conexao.Open("localhost", "restaurantedb", "root", "minas");
        public object SelectAll()
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;

                var query = from linhas in banco.produto.Include("tipo")
                            orderby linhas.idproduto
                            select linhas;
                return query.ToList();
            }
        }
        public void Inserir(modelo.produto reg)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                banco.produto.Add(reg);
                banco.SaveChanges();
            }
        }
        public void Editar(modelo.produto reg)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                modelo.produto velho = banco.produto.First(i => i.idproduto == reg.idproduto);
                banco.Entry(velho).CurrentValues.SetValues(reg);
                banco.SaveChanges();
            }
        }
        public void Excluir(int codigo)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                modelo.produto reg = banco.produto.First(i => i.idproduto == codigo);
                banco.produto.Remove(reg);
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
                    return banco.produto.Max(i => i.idproduto) + 1;
                }
                catch (Exception)
                {
                    
                    cod = 1;
                }
                return cod;
            }
        }
        public modelo.produto pesquisar(int cod)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                var query = (from linha in banco.produto.Include("tipo")
                             where linha.idproduto == cod
                             select linha).First();
                return (modelo.produto)query;
            }
        }

        public object pesquisarnome(string texto)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                var query = from linhas in banco.produto
                            where linhas.nome.StartsWith(texto)
                            select new 
                            {
                                codigo = linhas.idproduto,
                                Descricao = linhas.nome
                            };
                
                return query.ToList();
            }
        }
    }
}
