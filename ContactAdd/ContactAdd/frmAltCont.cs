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
    public partial class frmAltCont : Form
    {
        //conexao com o bando de dados
        const string cad = "Server = localhost; user id = root; database = db_contactadd; password = ''";
        MySqlConnection conectar = new MySqlConnection(cad);

        private int codigo;

        MySqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados 
        MySqlCommandBuilder cmd; //este carinha é quem monta os codigos SQL do MySQL para enviar para o banco
        DataTable datb; //datatable é quem vai receber os dados do adpter

        string nome, email, sexo, datNas, cidade, estado, end, tel, cel, obs, nomeFoto, fotoPadrao;


        public frmAltCont(cadastro cad)
        {
            InitializeComponent();
            codigo = cad.cod;
            lblCod.Text = Convert.ToString(codigo);
            txtNome.Text = cad.nome;
            txtEmail.Text = cad.email;
            cbSexo.Text = cad.sexo;
            txtDatNas.Text = cad.datNas;
            txtCidade.Text = cad.cidade;
            cbEstado.Text = cad.estado;
            txtEnd.Text = cad.end;
            txtTel.Text = cad.tel;
            txtCel.Text = cad.cel;
            txtObs.Text = cad.obs;
            nomeFoto = cad.foto;
            pbImagem.ImageLocation = nomeFoto;      
        
        }               

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultar vemConsul = new frmConsultar();
            this.Hide();
            vemConsul.ShowDialog();
            this.Close();
        }

        private void btnAlt_Click(object sender, EventArgs e)
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
                MySqlCommand alterar = new MySqlCommand();

                if (txtNome.TextLength == 0 || txtEmail.TextLength == 0)
                {
                    MessageBox.Show("Há campos obrigatórios em branco, preenche-los!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conectar.Close();
                }
                    else
                    {if (codigo == 0)
                    {
                        MessageBox.Show("Não existe nenhum cadastro com esse ID!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        conectar.Close();
                    }
                    else
                    {
                        if (pbImagem.Image == null)
                        {
                            nomeFoto = Application.StartupPath.ToString() + "\\imagensPerfil\\" + "User.png";
                            alterar.CommandText = "Update contato set Nome_Cont= '" + nome + "', Email_Cont= '" + email + "', Sexo_Cont= '" + sexo + "', DataNas_Cont= '" + datNas + "', Cidade_Cont= '" + cidade + "', Estado_Cont= '" + estado + "', Endereco_Cont= '" + end + "', Tel_Cont= '" + tel + "', Cel_Cont= '" + cel + "', Obs_Cont= '" + obs + "', Foto_Cont= '" + nomeFoto.Replace(@"\", @"\\") + "' Where Cod_Cont = " + codigo;

                            


                            frmConsultar vemConsult = new frmConsultar();
                            vemConsult.dgvConsulta.Refresh();

                            alterar.Connection = conectar;
                            alterar.ExecuteNonQuery();
                            conectar.Close();
                            pbImagem.ImageLocation = nomeFoto;
                            MessageBox.Show("Seus dados foram alterados com sucesso", " CONFIRMAÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                        else
                        {
                            fotoPadrao = Application.StartupPath.ToString() + "\\imagensPerfil\\" + "User.png";
                            if (pbImagem.ImageLocation == fotoPadrao)
                            {
                                pbImagem.Image.Save(Application.StartupPath.ToString() + "\\imagensPerfil\\" + codigo + ".png", System.Drawing.Imaging.ImageFormat.Png);
                                nomeFoto = Application.StartupPath.ToString() + "\\imagensPerfil\\" + codigo + ".png";

                                alterar.CommandText = "Update contato set Nome_Cont= '" + nome + "', Email_Cont= '" + email + "', Sexo_Cont= '" + sexo + "', DataNas_Cont= '" + datNas + "', Cidade_Cont= '" + cidade + "', Estado_Cont= '" + estado + "', Endereco_Cont= '" + end + "', Tel_Cont= '" + tel + "', Cel_Cont= '" + cel + "', Obs_Cont= '" + obs + "', Foto_Cont= '" + nomeFoto.Replace(@"\", @"\\") + "' Where Cod_Cont = " + codigo;

                                


                                frmConsultar vemConsult = new frmConsultar();
                                vemConsult.dgvConsulta.Refresh();

                                alterar.Connection = conectar;
                                alterar.ExecuteNonQuery();
                                conectar.Close();
                                pbImagem.ImageLocation = nomeFoto;
                                MessageBox.Show("Seus dados foram alterados com sucesso", " CONFIRMAÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                System.IO.File.Delete(nomeFoto);

                                pbImagem.Image.Save(Application.StartupPath.ToString() + "\\imagensPerfil\\" + codigo + ".png", System.Drawing.Imaging.ImageFormat.Png);
                                nomeFoto = Application.StartupPath.ToString() + "\\imagensPerfil\\" + codigo + ".png";

                                alterar.CommandText = "Update contato set Nome_Cont= '" + nome + "', Email_Cont= '" + email + "', Sexo_Cont= '" + sexo + "', DataNas_Cont= '" + datNas + "', Cidade_Cont= '" + cidade + "', Estado_Cont= '" + estado + "', Endereco_Cont= '" + end + "', Tel_Cont= '" + tel + "', Cel_Cont= '" + cel + "', Obs_Cont= '" + obs + "', Foto_Cont= '" + nomeFoto.Replace(@"\", @"\\") + "' Where Cod_Cont = " + codigo;

                                


                                frmConsultar vemConsult = new frmConsultar();
                                vemConsult.dgvConsulta.Refresh();

                                alterar.Connection = conectar;
                                alterar.ExecuteNonQuery();
                                conectar.Close();
                                pbImagem.ImageLocation = nomeFoto;
                                MessageBox.Show("Seus dados foram alterados com sucesso", " CONFIRMAÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                    }                    
                }

              

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel alterar o seu cadastro, tente novamente mais tarde!" + "\n" + "\n" + "\n" + Convert.ToString(ex), "!!! ERRO DE CONEXÂO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadastrarNovoContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCont vemAddCont = new frmAddCont();
            this.Hide();
            vemAddCont.ShowDialog();
            this.Close();
        }

        private void excluirContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                      

            const string message = "Você Realmente deseja deletar esse contato?";
            const string caption = "DELETAR!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lblCod.Text = "";
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
                

                fotoPadrao = Application.StartupPath.ToString() + "\\imagensPerfil\\" + "User.png";
                if (pbImagem.ImageLocation == fotoPadrao)
                {
                    pbImagem.Image.Save(Application.StartupPath.ToString() + "\\imagensPerfil\\" + codigo + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    nomeFoto = Application.StartupPath.ToString() + "\\imagensPerfil\\" + codigo + ".png";
                    pbImagem.ImageLocation = nomeFoto;
                    System.IO.File.Delete(nomeFoto);
                    pbImagem.Image = null;

                    conectar.Open();
                    MySqlCommand excluir = new MySqlCommand();





                    excluir.CommandText = "DELETE FROM contato WHERE Cod_Cont = " + codigo;
                    excluir.Connection = conectar;
                    excluir.ExecuteNonQuery();
                    conectar.Close();



                    MessageBox.Show("Seu contato foi deletado!!");
                }
                else
                {
                    System.IO.File.Delete(nomeFoto);
                    conectar.Open();
                    MySqlCommand excluir = new MySqlCommand();
                    pbImagem.Image = null;

                    excluir.CommandText = "DELETE FROM contato WHERE Cod_Cont = " + codigo;
                    excluir.Connection = conectar;
                    excluir.ExecuteNonQuery();
                    conectar.Close();

                    MessageBox.Show("Seu contato foi deletado!!");
                }


                frmConsultar vemConsul = new frmConsultar();
                this.Hide();
                vemConsul.ShowDialog();
                this.Close();


            }
            else
            {

            }



        }       
    }
}
