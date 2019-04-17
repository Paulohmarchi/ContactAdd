namespace ContactAdd
{
    partial class frmConsultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultar));
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.Cod_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNas_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cel_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto_Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtPesquisar.Location = new System.Drawing.Point(132, 92);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(699, 35);
            this.txtPesquisar.TabIndex = 13;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(7, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pesquisar:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Cont,
            this.Nome_Cont,
            this.Email_Cont,
            this.Sexo_Cont,
            this.DataNas_Cont,
            this.Cidade_Cont,
            this.Estado_Cont,
            this.Endereco_Cont,
            this.Tel_Cont,
            this.Cel_Cont,
            this.Obs_Cont,
            this.Foto_Cont});
            this.dgvConsulta.Location = new System.Drawing.Point(12, 133);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(886, 329);
            this.dgvConsulta.TabIndex = 16;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // Cod_Cont
            // 
            this.Cod_Cont.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cod_Cont.DataPropertyName = "Cod_Cont";
            this.Cod_Cont.HeaderText = "Codigo";
            this.Cod_Cont.Name = "Cod_Cont";
            // 
            // Nome_Cont
            // 
            this.Nome_Cont.DataPropertyName = "Nome_Cont";
            this.Nome_Cont.HeaderText = "Nome";
            this.Nome_Cont.Name = "Nome_Cont";
            // 
            // Email_Cont
            // 
            this.Email_Cont.DataPropertyName = "Email_Cont";
            this.Email_Cont.HeaderText = "Email";
            this.Email_Cont.Name = "Email_Cont";
            // 
            // Sexo_Cont
            // 
            this.Sexo_Cont.DataPropertyName = "Sexo_Cont";
            this.Sexo_Cont.HeaderText = "Sexo";
            this.Sexo_Cont.Name = "Sexo_Cont";
            // 
            // DataNas_Cont
            // 
            this.DataNas_Cont.DataPropertyName = "DataNas_Cont";
            this.DataNas_Cont.HeaderText = "Data de Nascimento";
            this.DataNas_Cont.Name = "DataNas_Cont";
            // 
            // Cidade_Cont
            // 
            this.Cidade_Cont.DataPropertyName = "Cidade_Cont";
            this.Cidade_Cont.HeaderText = "Cidade";
            this.Cidade_Cont.Name = "Cidade_Cont";
            // 
            // Estado_Cont
            // 
            this.Estado_Cont.DataPropertyName = "Estado_Cont";
            this.Estado_Cont.HeaderText = "Estado";
            this.Estado_Cont.Name = "Estado_Cont";
            // 
            // Endereco_Cont
            // 
            this.Endereco_Cont.DataPropertyName = "Endereco_Cont";
            this.Endereco_Cont.HeaderText = "Endereço";
            this.Endereco_Cont.Name = "Endereco_Cont";
            // 
            // Tel_Cont
            // 
            this.Tel_Cont.DataPropertyName = "Tel_Cont";
            this.Tel_Cont.HeaderText = "Telefone";
            this.Tel_Cont.Name = "Tel_Cont";
            // 
            // Cel_Cont
            // 
            this.Cel_Cont.DataPropertyName = "Cel_Cont";
            this.Cel_Cont.HeaderText = "Celular";
            this.Cel_Cont.Name = "Cel_Cont";
            // 
            // Obs_Cont
            // 
            this.Obs_Cont.DataPropertyName = "Obs_Cont";
            this.Obs_Cont.HeaderText = "Observações";
            this.Obs_Cont.Name = "Obs_Cont";
            // 
            // Foto_Cont
            // 
            this.Foto_Cont.DataPropertyName = "Foto_Cont";
            this.Foto_Cont.HeaderText = "Foto";
            this.Foto_Cont.Name = "Foto_Cont";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-2, 533);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "ContactAdd    v.    1.1.0.2";
            // 
            // dtpDia
            // 
            this.dtpDia.Enabled = false;
            this.dtpDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDia.Location = new System.Drawing.Point(569, 528);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(273, 22);
            this.dtpDia.TabIndex = 63;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(848, 530);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 18);
            this.lblTimer.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 76);
            this.label2.TabIndex = 65;
            this.label2.Text = "ContactAdd";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactAdd.Properties.Resources._1449258700_checked_user;
            this.pictureBox1.Location = new System.Drawing.Point(325, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSair.Image = global::ContactAdd.Properties.Resources._1449184291_logout1;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(801, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 44);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnVoltar.Image = global::ContactAdd.Properties.Resources._1449184129_redo;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.Location = new System.Drawing.Point(684, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(106, 44);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGo.Image = global::ContactAdd.Properties.Resources._1449184068_search;
            this.btnGo.Location = new System.Drawing.Point(837, 89);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(61, 38);
            this.btnGo.TabIndex = 18;
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.Transparent;
            this.btnExibir.FlatAppearance.BorderSize = 0;
            this.btnExibir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExibir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExibir.Image = global::ContactAdd.Properties.Resources._1449184240_refresh;
            this.btnExibir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExibir.Location = new System.Drawing.Point(12, 468);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(104, 53);
            this.btnExibir.TabIndex = 14;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(910, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.dtpDia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.btnExibir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactAdd    v.    1.1.0.2";
            this.Load += new System.EventHandler(this.frmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo_Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNas_Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade_Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco_Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cel_Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs_Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto_Cont;
        public System.Windows.Forms.DataGridView dgvConsulta;
    }
}