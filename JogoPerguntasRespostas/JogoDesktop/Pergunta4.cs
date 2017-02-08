using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class Pergunta4 : Form
    {
        public int id_jogador_banco;

        public Pergunta4(int id_Jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_Jogador;
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {

            //COPIAR DAQUI
            if (rdbResposta3.Checked == true)
            {
                MessageBox.Show("ACERTOU");



                string path = "Server=AME0556342W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes";
                SqlConnection conexao = new SqlConnection(path);

                SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;


                //CRIA A VARIÁVEL DE INSERÇÃO
                string insert = "INSERT INTO tb_perguntas";
                insert += "(pergunta, resposta_correta, id_jogador)";
                insert += " VALUES ";
                insert += " ( ";

                insert += " '" + lblPergunta.Text + "' ,";
                insert += " '" + rdbResposta3.Text + "' ,";
                insert += " '" + id_jogador_banco + "' ";


                insert += " ) ";

                //ABRE A CONEXÃO   
                conexao.Open();

                //PASSA O COMANDO INSERT COMPLETO
                comando.CommandText = insert;

                //EXECUTA O INSERT
                comando.ExecuteNonQuery();

                //FECHA A CONEXÃO
                conexao.Close();

                /*
                //CHAMA A PRÓXIMA PERGUNTA E FECHA A ANTERIOR
                Pergunta3 p3 = new Pergunta3();
                p3.ShowDialog();

                this.Close();
                */


            }



            else
            {
                MessageBox.Show("SEU BURRO");
            }
        }

        private void rdbResposta4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbResposta3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbResposta2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbResposta1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblPergunta_Click(object sender, EventArgs e)
        {
            //COPIAR ATÉ AQUI

          
        }
    }
}
