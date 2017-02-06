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

namespace JogoDesktop
{
    public partial class Pergunta1 : Form
    {
        public int id_jogador_banco;
        public Pergunta1(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (rdbResposta4.Checked == true)
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
                insert += " '" + rdbResposta4.Text + "' ,";
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


                
             }
                
                    

            else
            {
                MessageBox.Show("SEU BURRO");
            }
        }
    }
}
