using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ContactAdd
{
    public partial class frmAddCont : Form
    {
        //conexao com o bando de dados
        const string cad = "Server = localhost; user id = root; database = db_contactadd; password = ''";
        MySqlConnection conectar = new MySqlConnection(cad);        

        MySqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados 
        MySqlCommandBuilder cmd; //este carinha é quem monta os codigos SQL do MySQL para enviar para o banco
        DataTable datb; //datatable é quem vai receber os dados do adpter

        string nome, email, sexo, datNas, cidade, estado, end, tel, cel, obs, nomeFoto, fotoPadrao, fotoCopiar;

        public frmAddCont()
        {
            
            InitializeComponent();
        
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            Bitmap imagens = new Bitmap(openFileDialog1.FileName);
            pbImagem.Image = imagens;
            this.Validate();
        }

        private void btnLimparImg_Click(object sender, EventArgs e)
        {
            pbImagem.Image = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            const string message = "Você Realmente deseja sair?";
            const string caption = "Sair!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtEnd.Text = "";
            txtCidade.Text = "";
            txtObs.Text = "";
            cbEstado.Text = "";
            cbSexo.Text = "";
            txtDatNas.Text = "";
            txtCel.Text = "";
            txtTel.Text = "";
            pbImagem.Image = null;
            txtNome.Focus();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnCads_Click(object sender, EventArgs e)
        {

            nome = txtNome.Text;
            email = txtEmail.Text;
            sexo = cbSexo.Text;
            datNas = txtDatNas.Text;
            cidade = txtCidade.Text;
            estado = cbEstado.Text;
            end = txtEnd.Text;
            tel = txtTel.Text;
            cel = txtCel.Text;
            obs = txtObs.Text;

            try
            {
                conectar.Open();
                MySqlCommand salvar = new MySqlCommand();

                if (txtNome.TextLength == 0 || txtEmail.TextLength == 0)
                {
                    MessageBox.Show("Há campos obrigatórios em branco, preenche-los!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conectar.Close();
                }
                else
                {
                    if (pbImagem.Image == null)
                    {
                        nomeFoto = Application.StartupPath.ToString() + "\\imagensPerfil\\" + "User.png";
                        salvar.CommandText = "Insert into contato(Nome_Cont,Email_Cont,Sexo_Cont,DataNas_Cont,Cidade_Cont,Estado_Cont,Endereco_Cont,Tel_Cont,Cel_Cont,Obs_Cont,Foto_Cont)values('" + nome + "','" + email + "','" + sexo + "','" + datNas + "','" + cidade + "','" + estado + "','" + end + "','" + tel + "','" + cel + "','" + obs + "','" + nomeFoto.Replace(@"\", @"\\") + "')";
                        salvar.Connection = conectar;
                        salvar.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Seus dados foram salvos com sucesso !!", " CONFIRMAÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        MessageBox.Show("IMPORTANTE!!! CONSULTE O CONTATO EM QUE VOCÊ ACABOU DE CADASTRAR E CLIQUE EM ALTERAR, PARA QUE A FOTO SEJA SALVA CORRETAMENTE!!!", "!!! IMPORTANTE !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        pbImagem.Image.Save(Application.StartupPath.ToString() + "\\imagensPerfil\\" + nome + ".png", System.Drawing.Imaging.ImageFormat.Png);
                        nomeFoto = Application.StartupPath.ToString() + "\\imagensPerfil\\" + nome + ".png";
                        salvar.CommandText = "Insert into contato(Nome_Cont,Email_Cont,Sexo_Cont,DataNas_Cont,Cidade_Cont,Estado_Cont,Endereco_Cont,Tel_Cont,Cel_Cont,Obs_Cont,Foto_Cont)values('" + nome + "','" + email + "','" + sexo + "','" + datNas + "','" + cidade + "','" + estado + "','" + end + "','" + tel + "','" + cel + "','" + obs + "','" + nomeFoto.Replace(@"\", @"\\") + "')";
                        salvar.Connection = conectar;
                        salvar.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Seus dados foram salvos com sucesso", " CONFIRMAÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        MessageBox.Show("IMPORTANTE!!! CONSULTE O CONTATO EM QUE VOCÊ ACABOU DE CADASTRAR E CLIQUE EM ALTERAR, PARA QUE A FOTO SEJA SALVA CORRETAMENTE!!!", "!!! IMPORTANTE !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                txtNome.Text = "";
                txtEmail.Text = "";
                txtEnd.Text = "";
                txtCidade.Text = "";
                txtObs.Text = "";
                cbEstado.Text = "";
                cbSexo.Text = "";
                txtDatNas.Text = "";
                txtCel.Text = "";
                txtTel.Text = "";
                pbImagem.Image = null;
                txtNome.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel salvar o seu cadastro, tente novamente mais tarde!" + "\n" + "\n" + "\n" + Convert.ToString(ex), "!!! ERRO DE CONEXÂO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultar vemConsul = new frmConsultar();
            this.Hide();
            vemConsul.ShowDialog();
            this.Close();
        }

      

       

        

        

                      

       

        

    }

        
}
