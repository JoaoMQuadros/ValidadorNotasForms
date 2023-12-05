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
using NovoProjetoValidaNotasForms;

namespace ValidadorNotasForms
{
    public partial class Frm_ValidaNota : Form
    {
        List<Aluno> lstAluno = new List<Aluno>();
        Aluno aluno = new Aluno();
        Notas notas = new Notas();
        
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
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Aluno(AlunoNome) VALUES (@AlunoNome) SELECT SCOPE_IDENTITY() AS AlunoID", conectar))
                {
                    sqlCommand.CommandType = CommandType.Text;

                    // Adicione o parâmetro de entrada para o procedimento armazenado e especifique o que usar como valor.
                    sqlCommand.Parameters.Add(new SqlParameter("@AlunoNome", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@AlunoNome"].Value = txtNomeAluno.Text;

                    // Adicione o parâmetro de saída.
                    sqlCommand.Parameters.Add(new SqlParameter("@AlunoID", SqlDbType.Int));
                    sqlCommand.Parameters["@AlunoID"].Direction = ParameterDirection.Output;

                    try
                    {
                        conectar.Open();

                        //Executa o procedimento armazenado.
                        aluno.AlunoID = Convert.ToInt32(sqlCommand.ExecuteScalar());

                        aluno.AlunoNome = txtNomeAluno.Text;
                        lstAluno.Add(aluno);
                        MessageBox.Show("Nome do aluno registrado");
                        txtNomeAluno.Clear();
                        
                    }
                    catch// (Exception ex) - mostra aonde esta o erro 
                    {
                        MessageBox.Show("Por favor registra o nome");//+ ex.Message);
                    }
                    finally
                    {
                        conectar.Close();
                    }
                }
            }
        }

        private void btnSalvaNota_Click(object sender, EventArgs e)
        {
            using (SqlConnection conectar = new SqlConnection(Properties.Settings.Default.connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Notas(Matematica, Portugues, Artes, Fisica) VALUES (@Matematica, @Portugues, @Artes, @Fisica) SELECT SCOPE_IDENTITY() AS NotasID", conectar))
                {
                    sqlCommand.CommandType = CommandType.Text;


                    // Adicione o parâmetro de entrada para o procedimento armazenado e especifique o que usar como valor.
                    sqlCommand.Parameters.Add(new SqlParameter("@Matematica", SqlDbType.Int, 11));
                    sqlCommand.Parameters["@Matematica"].Value = txtNotaMat.Text;
                    sqlCommand.Parameters.Add(new SqlParameter("@Portugues", SqlDbType.Int, 11));
                    sqlCommand.Parameters["@Portugues"].Value = txtNotaPor.Text;
                    sqlCommand.Parameters.Add(new SqlParameter("@Artes", SqlDbType.Int, 11));
                    sqlCommand.Parameters["@Artes"].Value = txtNotaArt.Text;
                    sqlCommand.Parameters.Add(new SqlParameter("@Fisica", SqlDbType.Int, 11));
                    sqlCommand.Parameters["@Fisica"].Value = txtNotaFis.Text;

                    // Adicione o parâmetro de saída.
                    sqlCommand.Parameters.Add(new SqlParameter("@NotasID", SqlDbType.Int));
                    sqlCommand.Parameters["@NotasID"].Direction = ParameterDirection.Output;

                    try
                    {
                        conectar.Open();

                        notas.NotaID = Convert.ToInt32(sqlCommand.ExecuteScalar());

                        notas.NotaMat = Convert.ToInt32(txtNotaMat.Text);
                        notas.NotaPor = Convert.ToInt32(txtNotaPor.Text);
                        notas.NotaFis = Convert.ToInt32(txtNotaFis.Text);
                        notas.NotaArt = Convert.ToInt32(txtNotaArt.Text);

                        lstAluno[lstAluno.Count - 1].lstNotas.Add(notas);
                        MessageBox.Show("Notas registradas");
                        LimpaNotas();

                    }
                    catch (Exception ex)// Exception ex - mostra aonde esta o erro 
                    {
                        MessageBox.Show("Por favor Insira as Notas" + ex.Message);
                    }
                    finally
                    {
                        conectar.Close();
                    }
                }
            }
        }
        private void btLimpaNome_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Clear();
        }

        private void btnLimpaNota_Click(object sender, EventArgs e)
        {
            LimpaNotas();
        }

        private void btnExibirResul_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void LimpaNotas()
        {
            txtNotaMat.Clear();
            txtNotaPor.Clear();
            txtNotaFis.Clear();
            txtNotaArt.Clear();
        }

    }
}
