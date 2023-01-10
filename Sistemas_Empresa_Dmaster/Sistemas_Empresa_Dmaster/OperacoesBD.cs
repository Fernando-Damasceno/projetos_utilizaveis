using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas_Empresa_Dmaster
{
    class OperacoesBD
    {
        public readonly string StrCon;

        //Este é o construtor da classe ( É executado automaticamente qdo a classe e instanciada])
        //Como instanciar essa classe: OperacoesBd Banco = new OperacoesBd("Localhost","MCDados","MCia","M-34...")
        //Também pode usar var Banco = new OperacoesBd(...)
        public OperacoesBD(string host, string banco = "", string usuario = "", string senha = "")
        {
            this.StrCon = $"Data Source={host};Initial Catalog={banco};User Id={usuario};Password={senha}";
        }

        //Método para executar uma query no banco de dados tipo (select... update... delete... etc. retorna o número de linhas modificadas)
        //Como chamar: int retorno = Banco.ExecutaSql("Update Produto set...")
        public int ExecutaSql(string sql, char sp = '|')
        {
            int ret = 0;

            using (SqlConnection Cnx = new SqlConnection(StrCon))
            {
                String[] Transasoes = sql.Split(sp);
                SqlTransaction Trans;

                try
                {
                    Cnx.Open();
                    Trans = Cnx.BeginTransaction();
                    for (int i = 0; i < Transasoes.Count(); i++)
                    {
                        SqlCommand comando = new SqlCommand(Transasoes[i], Cnx, Trans);
                        comando.CommandTimeout = 0;
                        ret = comando.ExecuteNonQuery();
                    }

                    Trans.Commit();
                }
                catch (Exception ex)
                {
                    //Mostrar excessão
                }
            }

            return ret;
        }

        //Método para executar uma query no banco de dados tipo ("select descrição from tabela where... - retona o conteúdo de algum campo)
        //Como chamar: String retorno = Banco.ExecutaSqlRet("SELECT Descricao FROM Produto where...")
        public string ExecutaSqlRet(string sql)
        {
            object ret = "";

            using (SqlConnection Cnx = new SqlConnection(StrCon))
            {
                try
                {
                    Cnx.Open();
                    SqlCommand comando = new SqlCommand(sql, Cnx);
                    comando.CommandTimeout = 0;
                    ret = comando.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    //Funcoes.EscreverArquivo("Banco-ExecutaSQLRet", $"Ocorreu uma exceção no método de executaSQLRet. Command: {sql}. {Environment.NewLine}{Environment.NewLine}Método que gerou a exceção [ {ex.TargetSite.DeclaringType?.Name} ]. Exceção: {ex.Message}. StackTrace: [ {ex.StackTrace} ]");
                }
            }

            return $"{ret}";
        }

        //Método para executar uma query no banco de dados tipo ("select * from tabela where... - retorna vários registros em forma de tabela)
        //Como chamar: Datatable tabela = Banco.RetornaTable("SELECT * FROM Produto WHERE Estoque < 10")
        public DataTable RetornaTable(string sql)
        {
            DataTable tabela = new DataTable();

            using (SqlConnection Cnx = new SqlConnection(StrCon))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Cnx);
                adaptador.SelectCommand.CommandTimeout = 0;

                try
                {
                    Cnx.Open();
                    adaptador.Fill(tabela);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "DMAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return tabela;
        }

        //Método para executar uma query no banco de dados tipo ("select Nome, Endereco, RTRIM(Idade), RTRIM(DataNascimento) from tabela where... 
        //- retorna vários campos de um único registro. Obs: so aceita String, se o campo for numérico ou data deve ser convertido com RTRIM
        //Como chamar: int retorno = Banco.RetornaReder("Select RTRIM(Cod_prod), Descricao FROM Produto WHERE ...")
        public string RetornaReader(string sql, char sep = '|')
        {
            string dados = "";

            using (SqlConnection Cnx = new SqlConnection(StrCon))
            {
                SqlCommand comando = new SqlCommand(sql, Cnx);
                SqlDataReader Dr;

                try
                {
                    Cnx.Open();
                    comando.CommandTimeout = 0;
                    Dr = comando.ExecuteReader();

                    if (Dr.Read())
                    {
                        for (int i = 0; i < Dr.FieldCount; i++)
                        {
                            if (i > 0) dados += sep;
                            dados += Dr.GetString(i);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "DMAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dados;
        }

    }
}
