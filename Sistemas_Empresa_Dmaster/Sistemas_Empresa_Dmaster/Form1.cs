using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using System.Globalization;


namespace Sistemas_Empresa_Dmaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Inicio do programa ao clicar no botão
            string recebedt = calendar.Value.ToString();// Recebe o valor inserido no calendário.
            DateTime hoje = DateTime.Now;
            DateTime dt = DateTime.Parse(recebedt);// Substitui o valor do calendário para o formato de data.


            int date = (hoje - dt).Days;
            int totDias = date;
            if (totDias <= 30)
            {
                MessageBox.Show("A data inicial deve ser superior a 30 dias da data atual.",
                                "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            var ret = MessageBox.Show("Confirma a inativação dos produtos " +
                                      $"com movimentação menor que {dt.ToString("dd/MM/yyyy")} ?",
                                      "inativaçao de produtos",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ret == DialogResult.No)
                return;

            
            atualizar(dt); // Inicio do metodo

        }

        private void calendar_ValueChanged(object sender, EventArgs e)
        {

        }


        private void atualizar(DateTime dt)
        {
            string dtpesquisa = dt.ToString("yyyy/MM/dd");
            // Linha de comando para utilizar as informações do banco de acordo com a data selecionada.
            OperacoesBD banco = new OperacoesBD("Localhost", "Banco", "ID", "Senha");
            // Usando as operações de conexão com o banco.
            string upd = "UPDATE Produto SET [Status] ='W' WHERE [Status] ='A' AND CONVERT(char,Ultima_mov,111) < '" + dtpesquisa + "'";
            int retupt = banco.ExecutaSql(upd);
            if (retupt > 0)
            {
                MessageBox.Show("Foram atualizados "+retupt+" produtos",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Não foram localizados produtos para atualização.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}