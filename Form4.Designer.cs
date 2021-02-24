namespace Recrutamento
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultadoConsultaAluno = new System.Windows.Forms.TextBox();
            this.btnConsultarAluno = new System.Windows.Forms.Button();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listaDaSala = new System.Windows.Forms.ListBox();
            this.txtNomeDaSala = new System.Windows.Forms.TextBox();
            this.btnConsultarSala = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.resultadoConsultaAluno);
            this.groupBox1.Controls.Add(this.btnConsultarAluno);
            this.groupBox1.Controls.Add(this.txtNomeConsulta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // resultadoConsultaAluno
            // 
            this.resultadoConsultaAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoConsultaAluno.Location = new System.Drawing.Point(28, 105);
            this.resultadoConsultaAluno.Name = "resultadoConsultaAluno";
            this.resultadoConsultaAluno.ReadOnly = true;
            this.resultadoConsultaAluno.Size = new System.Drawing.Size(673, 26);
            this.resultadoConsultaAluno.TabIndex = 3;
            // 
            // btnConsultarAluno
            // 
            this.btnConsultarAluno.Location = new System.Drawing.Point(305, 34);
            this.btnConsultarAluno.Name = "btnConsultarAluno";
            this.btnConsultarAluno.Size = new System.Drawing.Size(115, 26);
            this.btnConsultarAluno.TabIndex = 2;
            this.btnConsultarAluno.Text = "Consultar";
            this.btnConsultarAluno.UseVisualStyleBackColor = true;
            this.btnConsultarAluno.Click += new System.EventHandler(this.btnConsultarAluno_Click);
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeConsulta.Location = new System.Drawing.Point(100, 34);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(183, 26);
            this.txtNomeConsulta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnConsultarSala);
            this.groupBox2.Controls.Add(this.txtNomeDaSala);
            this.groupBox2.Controls.Add(this.listaDaSala);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salas";
            // 
            // listaDaSala
            // 
            this.listaDaSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDaSala.FormattingEnabled = true;
            this.listaDaSala.ItemHeight = 20;
            this.listaDaSala.Location = new System.Drawing.Point(23, 86);
            this.listaDaSala.Name = "listaDaSala";
            this.listaDaSala.Size = new System.Drawing.Size(707, 124);
            this.listaDaSala.TabIndex = 0;
            // 
            // txtNomeDaSala
            // 
            this.txtNomeDaSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDaSala.Location = new System.Drawing.Point(163, 37);
            this.txtNomeDaSala.Name = "txtNomeDaSala";
            this.txtNomeDaSala.Size = new System.Drawing.Size(136, 26);
            this.txtNomeDaSala.TabIndex = 4;
            // 
            // btnConsultarSala
            // 
            this.btnConsultarSala.Location = new System.Drawing.Point(342, 37);
            this.btnConsultarSala.Name = "btnConsultarSala";
            this.btnConsultarSala.Size = new System.Drawing.Size(115, 26);
            this.btnConsultarSala.TabIndex = 4;
            this.btnConsultarSala.Text = "Consultar";
            this.btnConsultarSala.UseVisualStyleBackColor = true;
            this.btnConsultarSala.Click += new System.EventHandler(this.btnConsultarSala_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome da Sala";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultarAluno;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultadoConsultaAluno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listaDaSala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultarSala;
        private System.Windows.Forms.TextBox txtNomeDaSala;
    }
}