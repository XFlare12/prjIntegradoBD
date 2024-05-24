namespace prjIntegradoBD
{
    partial class Professor
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.txtNotaB1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotaB2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotaB3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotaB4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnoLetivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlunoID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(362, 495);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(166, 37);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(449, 51);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(310, 40);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Olá professor , de y";
            this.lblDesc.Click += new System.EventHandler(this.lblDesc_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(593, 495);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(166, 37);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "GRAVAR NOTAS";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Disciplina";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Enabled = false;
            this.txtDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisciplina.Location = new System.Drawing.Point(38, 121);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(206, 30);
            this.txtDisciplina.TabIndex = 4;
            // 
            // txtNotaB1
            // 
            this.txtNotaB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaB1.Location = new System.Drawing.Point(38, 170);
            this.txtNotaB1.Name = "txtNotaB1";
            this.txtNotaB1.Size = new System.Drawing.Size(206, 30);
            this.txtNotaB1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota Bimestre 1";
            // 
            // txtNotaB2
            // 
            this.txtNotaB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaB2.Location = new System.Drawing.Point(38, 219);
            this.txtNotaB2.Name = "txtNotaB2";
            this.txtNotaB2.Size = new System.Drawing.Size(206, 30);
            this.txtNotaB2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nota Bimestre 2";
            // 
            // txtNotaB3
            // 
            this.txtNotaB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaB3.Location = new System.Drawing.Point(39, 265);
            this.txtNotaB3.Name = "txtNotaB3";
            this.txtNotaB3.Size = new System.Drawing.Size(206, 30);
            this.txtNotaB3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nota Bimestre 3";
            // 
            // txtNotaB4
            // 
            this.txtNotaB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaB4.Location = new System.Drawing.Point(38, 314);
            this.txtNotaB4.Name = "txtNotaB4";
            this.txtNotaB4.Size = new System.Drawing.Size(206, 30);
            this.txtNotaB4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 46);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nota Bimestre 4";
            // 
            // txtAnoLetivo
            // 
            this.txtAnoLetivo.Enabled = false;
            this.txtAnoLetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoLetivo.Location = new System.Drawing.Point(38, 368);
            this.txtAnoLetivo.Name = "txtAnoLetivo";
            this.txtAnoLetivo.Size = new System.Drawing.Size(206, 30);
            this.txtAnoLetivo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 46);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ano letivo";
            // 
            // txtAlunoID
            // 
            this.txtAlunoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlunoID.Location = new System.Drawing.Point(39, 419);
            this.txtAlunoID.Name = "txtAlunoID";
            this.txtAlunoID.Size = new System.Drawing.Size(206, 30);
            this.txtAlunoID.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 46);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID do aluno";
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.txtAlunoID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAnoLetivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNotaB4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotaB3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNotaB2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotaB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnVoltar);
            this.Name = "Professor";
            this.Text = "Professor";
            this.Load += new System.EventHandler(this.Professor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.TextBox txtNotaB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotaB2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotaB3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotaB4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnoLetivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlunoID;
        private System.Windows.Forms.Label label7;
    }
}