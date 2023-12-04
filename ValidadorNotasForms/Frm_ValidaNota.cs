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

namespace ValidadorNotasForms
{
    public partial class Frm_ValidaNota : Form
    {
        List<Aluno> lstAluno = new List<Aluno>();
        Aluno aluno = new Aluno();
        Notas notas = new Notas();
        private int analisaID;

        public Frm_ValidaNota()
        {
            InitializeComponent();
        }
        // Cria um novo cliente chamando o procedimento armazenado
        private void btnSalvaNome_Click(object sender, EventArgs e)
        {
            // Cria a conexão.
            using (SqlConnection conectar = new SqlConnection(Properties.Settings.Default.connString))
            {
                // Crie um SqlCommand e identifique-o como um procedimento armazenado.
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Aluno(AlunoNome) VALUES (@AlunoNome)", conectar))
                {
                    sqlCommand.CommandType = CommandType.Text;

                    // Adicione o parâmetro de entrada para o procedimento armazenado e especifique o que usar como valor.
                    sqlCommand.Parameters.Add(new SqlParameter("@AlunoNome", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@AlunoNome"].Value = txtNomeAluno.Text;

                    // Adicione o parâmetro de saída.
                    sqlCommand.Parameters.Add(new SqlParameter("@AlunoID", SqlDbType.Int));
                    sqlCommand.Parameters["@AlunoID"].Direction = ParameterDirection.Output;         

                    try
                    {
                        conectar.Open();

                        //Executa o procedimento armazenado.
                        sqlCommand.ExecuteNonQuery();

                        // ID do cliente é um valor IDENTITY do banco de dados.
                        analisaID = (int)sqlCommand.Parameters["@AlunoID"].Value;
                        aluno.NomeAluno = txtNomeAluno.Text;


                        //// Coloque o valor do ID do cliente na caixa de texto somente leitura.
                        //this.txtCustomerID.Text = Convert.ToString(analisadoCustomerID);

                        lstAluno.Add(aluno);

                        MessageBox.Show("Nome do aluno registrado");               
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show("Não deu certo " + ex.Message);
                    }
                    finally
                    {
                        conectar.Close();
                    }
                }
            }
        }
    }
}
