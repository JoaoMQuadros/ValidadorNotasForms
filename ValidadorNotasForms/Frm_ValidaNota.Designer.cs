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
            this.btLimpaNome = new System.Windows.Forms.Button();
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
            this.gpbNomeAluno.SuspendLayout();
            this.gpbNotas.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibeNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbNomeAluno
            // 
            this.gpbNomeAluno.Controls.Add(this.btLimpaNome);
            this.gpbNomeAluno.Controls.Add(this.btnSalvaNome);
            this.gpbNomeAluno.Controls.Add(this.txtNomeAluno);
            this.gpbNomeAluno.Controls.Add(this.lblNomeAluno);
            this.gpbNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNomeAluno.Location = new System.Drawing.Point(12, 12);
            this.gpbNomeAluno.Name = "gpbNomeAluno";
            this.gpbNomeAluno.Size = new System.Drawing.Size(758, 177);
            this.gpbNomeAluno.TabIndex = 0;
            this.gpbNomeAluno.TabStop = false;
            this.gpbNomeAluno.Text = "Aluno";
            // 
            // btLimpaNome
            // 
            this.btLimpaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpaNome.Location = new System.Drawing.Point(596, 148);
            this.btLimpaNome.Name = "btLimpaNome";
            this.btLimpaNome.Size = new System.Drawing.Size(75, 23);
            this.btLimpaNome.TabIndex = 3;
            this.btLimpaNome.Text = "Limpar";
            this.btLimpaNome.UseVisualStyleBackColor = true;
            // 
            // btnSalvaNome
            // 
            this.btnSalvaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaNome.Location = new System.Drawing.Point(677, 148);
            this.btnSalvaNome.Name = "btnSalvaNome";
            this.btnSalvaNome.Size = new System.Drawing.Size(75, 23);
            this.btnSalvaNome.TabIndex = 2;
            this.btnSalvaNome.Text = "Salvar";
            this.btnSalvaNome.UseVisualStyleBackColor = true;
            this.btnSalvaNome.Click += new System.EventHandler(this.btnSalvaNome_Click);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(6, 79);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(404, 26);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(6, 45);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(197, 20);
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
            this.gpbNotas.Location = new System.Drawing.Point(12, 195);
            this.gpbNotas.Name = "gpbNotas";
            this.gpbNotas.Size = new System.Drawing.Size(758, 177);
            this.gpbNotas.TabIndex = 1;
            this.gpbNotas.TabStop = false;
            this.gpbNotas.Text = "Notas";
            // 
            // btnLimpaNota
            // 
            this.btnLimpaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaNota.Location = new System.Drawing.Point(596, 148);
            this.btnLimpaNota.Name = "btnLimpaNota";
            this.btnLimpaNota.Size = new System.Drawing.Size(75, 23);
            this.btnLimpaNota.TabIndex = 5;
            this.btnLimpaNota.Text = "Limpar";
            this.btnLimpaNota.UseVisualStyleBackColor = true;
            // 
            // txtNotaArt
            // 
            this.txtNotaArt.Location = new System.Drawing.Point(450, 45);
            this.txtNotaArt.Name = "txtNotaArt";
            this.txtNotaArt.Size = new System.Drawing.Size(135, 26);
            this.txtNotaArt.TabIndex = 7;
            // 
            // btnSalvaNota
            // 
            this.btnSalvaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaNota.Location = new System.Drawing.Point(677, 148);
            this.btnSalvaNota.Name = "btnSalvaNota";
            this.btnSalvaNota.Size = new System.Drawing.Size(75, 23);
            this.btnSalvaNota.TabIndex = 4;
            this.btnSalvaNota.Text = "Salvar";
            this.btnSalvaNota.UseVisualStyleBackColor = true;
            // 
            // txtNotaFis
            // 
            this.txtNotaFis.Location = new System.Drawing.Point(450, 108);
            this.txtNotaFis.Name = "txtNotaFis";
            this.txtNotaFis.Size = new System.Drawing.Size(135, 26);
            this.txtNotaFis.TabIndex = 7;
            // 
            // txtNotaPor
            // 
            this.txtNotaPor.Location = new System.Drawing.Point(119, 108);
            this.txtNotaPor.Name = "txtNotaPor";
            this.txtNotaPor.Size = new System.Drawing.Size(135, 26);
            this.txtNotaPor.TabIndex = 6;
            // 
            // txtNotaMat
            // 
            this.txtNotaMat.Location = new System.Drawing.Point(119, 45);
            this.txtNotaMat.Name = "txtNotaMat";
            this.txtNotaMat.Size = new System.Drawing.Size(135, 26);
            this.txtNotaMat.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fisica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Artes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Portugues";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matematica";
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.dgvExibeNotas);
            this.gpbResultado.Location = new System.Drawing.Point(12, 365);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(758, 247);
            this.gpbResultado.TabIndex = 2;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // dgvExibeNotas
            // 
            this.dgvExibeNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExibeNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExibeNotas.Location = new System.Drawing.Point(3, 18);
            this.dgvExibeNotas.Name = "dgvExibeNotas";
            this.dgvExibeNotas.RowTemplate.Height = 24;
            this.dgvExibeNotas.Size = new System.Drawing.Size(752, 226);
            this.dgvExibeNotas.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(614, 618);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnExibirResul
            // 
            this.btnExibirResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirResul.Location = new System.Drawing.Point(695, 618);
            this.btnExibirResul.Name = "btnExibirResul";
            this.btnExibirResul.Size = new System.Drawing.Size(75, 23);
            this.btnExibirResul.TabIndex = 8;
            this.btnExibirResul.Text = "Exibir";
            this.btnExibirResul.UseVisualStyleBackColor = true;
            // 
            // Frm_ValidaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.btnExibirResul);
            this.Controls.Add(this.gpbNotas);
            this.Controls.Add(this.gpbNomeAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
        private System.Windows.Forms.Button btLimpaNome;
        private System.Windows.Forms.Button btnSalvaNome;
        private System.Windows.Forms.Button btnLimpaNota;
        private System.Windows.Forms.Button btnSalvaNota;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.DataGridView dgvExibeNotas;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExibirResul;
    }
}

