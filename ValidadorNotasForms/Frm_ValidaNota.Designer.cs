namespace ValidadorNotasForms
{
    partial class Frm_ValidaNota
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
            this.gpbNomeAluno = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalvaNome = new System.Windows.Forms.Button();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.gpbNotas = new System.Windows.Forms.GroupBox();
            this.btnLimpaNota = new System.Windows.Forms.Button();
            this.txtNotaArt = new System.Windows.Forms.TextBox();
            this.btnSalvaNota = new System.Windows.Forms.Button();
            this.txtNotaFis = new System.Windows.Forms.TextBox();
            this.txtNotaPor = new System.Windows.Forms.TextBox();
            this.txtNotaMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.dgvExibeNotas = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExibirResul = new System.Windows.Forms.Button();
            this.btnExibeAprov = new System.Windows.Forms.Button();
            this.btnExcluiAluno = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.gpbNomeAluno.SuspendLayout();
            this.gpbNotas.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibeNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbNomeAluno
            // 
            this.gpbNomeAluno.Controls.Add(this.btnPesquisa);
            this.gpbNomeAluno.Controls.Add(this.btnExcluiAluno);
            this.gpbNomeAluno.Controls.Add(this.button1);
            this.gpbNomeAluno.Controls.Add(this.btnSalvaNome);
            this.gpbNomeAluno.Controls.Add(this.txtNomeAluno);
            this.gpbNomeAluno.Controls.Add(this.lblNomeAluno);
            this.gpbNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNomeAluno.Location = new System.Drawing.Point(9, 10);
            this.gpbNomeAluno.Margin = new System.Windows.Forms.Padding(2);
            this.gpbNomeAluno.Name = "gpbNomeAluno";
            this.gpbNomeAluno.Padding = new System.Windows.Forms.Padding(2);
            this.gpbNomeAluno.Size = new System.Drawing.Size(662, 91);
            this.gpbNomeAluno.TabIndex = 0;
            this.gpbNomeAluno.TabStop = false;
            this.gpbNomeAluno.Text = "Aluno";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(540, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalvaNome
            // 
            this.btnSalvaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaNome.Location = new System.Drawing.Point(600, 64);
            this.btnSalvaNome.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvaNome.Name = "btnSalvaNome";
            this.btnSalvaNome.Size = new System.Drawing.Size(56, 23);
            this.btnSalvaNome.TabIndex = 2;
            this.btnSalvaNome.Text = "Salvar";
            this.btnSalvaNome.UseVisualStyleBackColor = true;
            this.btnSalvaNome.Click += new System.EventHandler(this.btnSalvaNome_Click);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(4, 64);
            this.txtNomeAluno.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(304, 23);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(4, 37);
            this.lblNomeAluno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(169, 17);
            this.lblNomeAluno.TabIndex = 0;
            this.lblNomeAluno.Text = "Qual é o nome do Aluno?";
            // 
            // gpbNotas
            // 
            this.gpbNotas.Controls.Add(this.btnLimpaNota);
            this.gpbNotas.Controls.Add(this.txtNotaArt);
            this.gpbNotas.Controls.Add(this.btnSalvaNota);
            this.gpbNotas.Controls.Add(this.txtNotaFis);
            this.gpbNotas.Controls.Add(this.txtNotaPor);
            this.gpbNotas.Controls.Add(this.txtNotaMat);
            this.gpbNotas.Controls.Add(this.label4);
            this.gpbNotas.Controls.Add(this.label3);
            this.gpbNotas.Controls.Add(this.label2);
            this.gpbNotas.Controls.Add(this.label1);
            this.gpbNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNotas.Location = new System.Drawing.Point(9, 105);
            this.gpbNotas.Margin = new System.Windows.Forms.Padding(2);
            this.gpbNotas.Name = "gpbNotas";
            this.gpbNotas.Padding = new System.Windows.Forms.Padding(2);
            this.gpbNotas.Size = new System.Drawing.Size(662, 103);
            this.gpbNotas.TabIndex = 1;
            this.gpbNotas.TabStop = false;
            this.gpbNotas.Text = "Notas";
            // 
            // btnLimpaNota
            // 
            this.btnLimpaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaNota.Location = new System.Drawing.Point(540, 82);
            this.btnLimpaNota.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpaNota.Name = "btnLimpaNota";
            this.btnLimpaNota.Size = new System.Drawing.Size(56, 21);
            this.btnLimpaNota.TabIndex = 9;
            this.btnLimpaNota.Text = "Limpar";
            this.btnLimpaNota.UseVisualStyleBackColor = true;
            this.btnLimpaNota.Click += new System.EventHandler(this.btnLimpaNota_Click);
            // 
            // txtNotaArt
            // 
            this.txtNotaArt.Location = new System.Drawing.Point(281, 37);
            this.txtNotaArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotaArt.Name = "txtNotaArt";
            this.txtNotaArt.Size = new System.Drawing.Size(102, 23);
            this.txtNotaArt.TabIndex = 5;
            // 
            // btnSalvaNota
            // 
            this.btnSalvaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaNota.Location = new System.Drawing.Point(601, 82);
            this.btnSalvaNota.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvaNota.Name = "btnSalvaNota";
            this.btnSalvaNota.Size = new System.Drawing.Size(56, 21);
            this.btnSalvaNota.TabIndex = 8;
            this.btnSalvaNota.Text = "Salvar";
            this.btnSalvaNota.UseVisualStyleBackColor = true;
            this.btnSalvaNota.Click += new System.EventHandler(this.btnSalvaNota_Click);
            // 
            // txtNotaFis
            // 
            this.txtNotaFis.Location = new System.Drawing.Point(281, 73);
            this.txtNotaFis.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotaFis.Name = "txtNotaFis";
            this.txtNotaFis.Size = new System.Drawing.Size(102, 23);
            this.txtNotaFis.TabIndex = 7;
            // 
            // txtNotaPor
            // 
            this.txtNotaPor.Location = new System.Drawing.Point(89, 73);
            this.txtNotaPor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotaPor.Name = "txtNotaPor";
            this.txtNotaPor.Size = new System.Drawing.Size(102, 23);
            this.txtNotaPor.TabIndex = 6;
            // 
            // txtNotaMat
            // 
            this.txtNotaMat.Location = new System.Drawing.Point(89, 37);
            this.txtNotaMat.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotaMat.Name = "txtNotaMat";
            this.txtNotaMat.Size = new System.Drawing.Size(102, 23);
            this.txtNotaMat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fisica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Artes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Portugues";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matematica";
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.dgvExibeNotas);
            this.gpbResultado.Location = new System.Drawing.Point(9, 212);
            this.gpbResultado.Margin = new System.Windows.Forms.Padding(2);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Padding = new System.Windows.Forms.Padding(2);
            this.gpbResultado.Size = new System.Drawing.Size(662, 208);
            this.gpbResultado.TabIndex = 2;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // dgvExibeNotas
            // 
            this.dgvExibeNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExibeNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExibeNotas.Location = new System.Drawing.Point(2, 15);
            this.dgvExibeNotas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvExibeNotas.Name = "dgvExibeNotas";
            this.dgvExibeNotas.RowTemplate.Height = 24;
            this.dgvExibeNotas.Size = new System.Drawing.Size(658, 191);
            this.dgvExibeNotas.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(87, 501);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(51, 24);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExibirResul
            // 
            this.btnExibirResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirResul.Location = new System.Drawing.Point(148, 501);
            this.btnExibirResul.Margin = new System.Windows.Forms.Padding(2);
            this.btnExibirResul.Name = "btnExibirResul";
            this.btnExibirResul.Size = new System.Drawing.Size(51, 24);
            this.btnExibirResul.TabIndex = 10;
            this.btnExibirResul.Text = "Exibir";
            this.btnExibirResul.UseVisualStyleBackColor = true;
            this.btnExibirResul.Click += new System.EventHandler(this.btnExibirResul_Click);
            // 
            // btnExibeAprov
            // 
            this.btnExibeAprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibeAprov.Location = new System.Drawing.Point(10, 501);
            this.btnExibeAprov.Margin = new System.Windows.Forms.Padding(2);
            this.btnExibeAprov.Name = "btnExibeAprov";
            this.btnExibeAprov.Size = new System.Drawing.Size(68, 24);
            this.btnExibeAprov.TabIndex = 12;
            this.btnExibeAprov.Text = "Resultado";
            this.btnExibeAprov.UseVisualStyleBackColor = true;
            this.btnExibeAprov.Click += new System.EventHandler(this.btnExibeAprov_Click);
            // 
            // btnExcluiAluno
            // 
            this.btnExcluiAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluiAluno.Location = new System.Drawing.Point(396, 64);
            this.btnExcluiAluno.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluiAluno.Name = "btnExcluiAluno";
            this.btnExcluiAluno.Size = new System.Drawing.Size(68, 23);
            this.btnExcluiAluno.TabIndex = 15;
            this.btnExcluiAluno.Text = "Excluir";
            this.btnExcluiAluno.UseVisualStyleBackColor = true;
            this.btnExcluiAluno.Click += new System.EventHandler(this.btnExcluiAluno_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(468, 64);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(68, 23);
            this.btnPesquisa.TabIndex = 16;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // Frm_ValidaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 536);
            this.Controls.Add(this.btnExibeAprov);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.btnExibirResul);
            this.Controls.Add(this.gpbNotas);
            this.Controls.Add(this.gpbNomeAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_ValidaNota";
            this.Text = "Validador de Notas";
            this.gpbNomeAluno.ResumeLayout(false);
            this.gpbNomeAluno.PerformLayout();
            this.gpbNotas.ResumeLayout(false);
            this.gpbNotas.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibeNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNomeAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.GroupBox gpbNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotaArt;
        private System.Windows.Forms.TextBox txtNotaFis;
        private System.Windows.Forms.TextBox txtNotaPor;
        private System.Windows.Forms.TextBox txtNotaMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvaNome;
        private System.Windows.Forms.Button btnLimpaNota;
        private System.Windows.Forms.Button btnSalvaNota;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.DataGridView dgvExibeNotas;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExibirResul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExibeAprov;
        private System.Windows.Forms.Button btnExcluiAluno;
        private System.Windows.Forms.Button btnPesquisa;
    }
}

