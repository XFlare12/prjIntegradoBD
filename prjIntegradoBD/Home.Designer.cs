namespace prjIntegradoBD
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnAluno.Image")));
            this.btnAluno.Location = new System.Drawing.Point(182, 224);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(122, 126);
            this.btnAluno.TabIndex = 0;
            this.btnAluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluno.UseVisualStyleBackColor = false;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnProf
            // 
            this.btnProf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProf.Image = ((System.Drawing.Image)(resources.GetObject("btnProf.Image")));
            this.btnProf.Location = new System.Drawing.Point(476, 224);
            this.btnProf.Margin = new System.Windows.Forms.Padding(0);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(122, 126);
            this.btnProf.TabIndex = 1;
            this.btnProf.UseVisualStyleBackColor = false;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 109);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem vindo, por favor selecione o modulo que gostaria de acessar!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aluno";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Professor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProf);
            this.Controls.Add(this.btnAluno);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}