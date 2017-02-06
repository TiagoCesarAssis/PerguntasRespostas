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
        public Pergunta1()
        {
            InitializeComponent();
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

                string insert = "INSERT INTO tb_perguntas";
                insert += "(pergunta, resposta_correta)";
                insert += " VALUES ";
                insert += " ( ";

                insert += " '" + lblPergunta.Text + "' ,";
                insert += " '" + rdbResposta4.Text + "' ";

                insert += " ) ";

                    
                conexao.Open();
                comando.CommandText = insert;
                comando.ExecuteNonQuery();
                conexao.Close();


                
             }
                
                    

            else
            {
                MessageBox.Show("SEU BURRO");
            }
        }
    }
}
