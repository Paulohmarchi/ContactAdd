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
    public partial class frmConsultar : Form
    {
        MySqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados 
        MySqlCommandBuilder cmd; //este carinha é quem monta os codigos SQL do MySQL para enviar para o banco
        DataTable datb; //datatable é quem vai receber os dados do adpter
        MySqlConnection con; //conexao com o banco
        
        frmAddCont cads = new frmAddCont();
        cadastro cad = new cadastro();

        public frmConsultar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmAddCont vemAddCont = new frmAddCont();
            this.Hide();
            vemAddCont.ShowDialog();
            this.Close();
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
            con = new MySqlConnection("server = localhost; user id = root; database= db_contactadd; password=''");
            dados = new MySqlDataAdapter("select * from contato", con);//classe que armazena dados
            datb = new DataTable(); //preenche data table
            dados.Fill(datb);   // transfere os pensamentos da base para o DataTable

            dgvConsulta.DataSource = datb;

            dgvConsulta.Refresh();
        }
        

        private void btnExibir_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server=localhost; User id=root; Database= db_contactadd;Password=''");
            dados = new MySqlDataAdapter("select * from contato", con);
            datb = new DataTable();
            dados.Fill(datb);

            dgvConsulta.DataSource = datb;
            dgvConsulta.Refresh();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server=localhost; User id=root; Database= db_contactadd;Password=''");
            dados = new MySqlDataAdapter("select * from contato where Nome_Cont LIKE '%" + txtPesquisar.Text + "%'", con);
            datb = new DataTable();
            dados.Fill(datb);       
            
            dgvConsulta.DataSource = datb;
            dgvConsulta.Refresh();

           
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cad.cod = Convert.ToInt16(dgvConsulta[0, dgvConsulta.CurrentRow.Index].Value.ToString());
            cad.nome = dgvConsulta[1, dgvConsulta.CurrentRow.Index].Value.ToString();
            cad.email = dgvConsulta[2, dgvConsulta.CurrentRow.Index].Value.ToString();
            cad.sexo = dgvConsulta[3, dgvConsulta.CurrentRow.Index].Value.ToString();
            cad.datNas = dgvConsulta[4, dgvConsulta.CurrentRow.Index].Value.ToString();
            cad.cidade = dgvConsulta[5, dgvConsulta.CurrentRow.Index].Value.ToString();
            cad.estado = dgvConsulta[6, dgvConsulta.CurrentRow.Index].Value.ToString();
            cad.end = dgvConsulta[7, dgvConsulta.CurrentRow.Index].Value.ToString();
            cad.tel = dgvConsulta[8, dgvConsulta.CurrentRow.Index].Value.ToString();
            cad.cel = dgvConsulta[9, dgvConsulta.CurrentRow.Index].Value.ToString();
            cad.obs = dgvConsulta[10, dgvConsulta.CurrentRow.Index].Value.ToString();
            cad.foto = dgvConsulta[11, dgvConsulta.CurrentRow.Index].Value.ToString();

            frmAltCont altCont = new frmAltCont(cad);
            this.Hide();
            altCont.ShowDialog();
            this.Close();
        }
    }
}
