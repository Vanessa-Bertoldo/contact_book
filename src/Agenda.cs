using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    public class Agenda
    {
        SqlCommand comandoSql = new SqlCommand();
        StringBuilder sql = new StringBuilder(); //armazena os comandos sql
        DataTable dadosTabela = new DataTable(); //armazena dados vindos do banco de dados

        //LISTANDO DADOS
        public DataTable Listar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM contatos");
                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;

                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;


                }
            }
            catch (Exception)
            {

                throw new Exception("erro ao listar dados");
            }

        }
        //DELETANDO DADOS
        public void Deletar(int id)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("DELETE FROM contatos WHERE (id=@id)");

                    comandoSql.Parameters.Add(new SqlParameter("@id", id));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw new Exception("Erro ao excluir dados");
            }
        }

        //INSERINDO DADOS
        public void Salvar(string nome, string email, string telefone)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao)) //instancia da classe conexão para conexão om banco de dados
                {
                    conexao.Open(); //Abre a conexão
                    //comandos de inserção de dados na tabela
                    sql.Append("INSERT INTO contatos(nome, email,telefone) VALUES (@nome, @email, @telefone)");

                    //Indicamos o valor e com qual parametro será relacionado
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@email", email));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));

                    comandoSql.CommandText = sql.ToString(); //instruções passadas ao comando sql
                    comandoSql.Connection = conexao; //conexao relacionada ao comando 
                    comandoSql.ExecuteNonQuery(); //Executa os comandos
                }
            }
            catch (Exception)
            {

                throw new Exception("Erro ao inserir dados");
            }
        }

        //ALTERANDO DADOS
        public void Alterar(int id, string nome, string email, string telefone)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE contatos SET nome = @nome, email = @email, telefone=@telefone WHERE (id = @id)");

                    comandoSql.Parameters.Add(new SqlParameter("@id", id));
                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
                    comandoSql.Parameters.Add(new SqlParameter("@email", email));
                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }

            catch (Exception)
            {

                throw new Exception("Erro ao atualizar dados");
            }
        }

        //METODOS DE PESQUISA=========================================


        //Pesquisa por nome
        public DataTable PesquisaNome(string nome)
        {
            dadosTabela = new DataTable();
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM contatos WHERE ( nome LIKE '%'+@nome+'%')");

                    comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());

                    return dadosTabela;
                }
            }
            catch (Exception)
            {

                throw new Exception("Erro ao pesquisar por nome");
            }         
        }
        //Pesquisa por email
        public DataTable PesquisaEmail(string email)
        {
            dadosTabela = new DataTable();
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM contatos WHERE ( email LIKE '%'+@email+'%')");

                    comandoSql.Parameters.Add(new SqlParameter("@email", email));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());

                    return dadosTabela;
                }
            }
            catch (Exception)
            {

                throw new Exception("Erro ao pesquisar por Email");
            }
        }

        //Pesquisar pot telefone
        public DataTable PesquisaTelefone(string telefone)
        {
            dadosTabela = new DataTable();
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM contatos WHERE ( telefone LIKE '%'+@telefone+'%')");

                    comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());

                    return dadosTabela;
                }
            }
            catch (Exception)
            {

                throw new Exception("Erro ao pesquisar por Email");
            }
        }

        //PESQUISA POR ID
        public DataTable PesquisaId(string sinal, string valor)
        {
            dadosTabela = new DataTable();
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT * FROM contatos WHERE id " +sinal+" @valor");

                    comandoSql.Parameters.Add(new SqlParameter("@valor", valor));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());

                    return dadosTabela;
                }
            }
            catch (Exception)
            {

                throw new Exception("Erro ao pesquisar por ID");
            }
        }


    }
   
}
