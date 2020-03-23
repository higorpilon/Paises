namespace Paises
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbPaises = new System.Windows.Forms.ListBox();
            this.progressBarPaises = new System.Windows.Forms.ProgressBar();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblRegiao = new System.Windows.Forms.Label();
            this.lblSubRegiao = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.blPopulacao = new System.Windows.Forms.Label();
            this.lblGini = new System.Windows.Forms.Label();
            this.lblBandeira = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Países:";
            // 
            // lbPaises
            // 
            this.lbPaises.FormattingEnabled = true;
            this.lbPaises.Location = new System.Drawing.Point(100, 58);
            this.lbPaises.Name = "lbPaises";
            this.lbPaises.Size = new System.Drawing.Size(373, 199);
            this.lbPaises.TabIndex = 1;
            // 
            // progressBarPaises
            // 
            this.progressBarPaises.Location = new System.Drawing.Point(646, 486);
            this.progressBarPaises.Name = "progressBarPaises";
            this.progressBarPaises.Size = new System.Drawing.Size(275, 23);
            this.progressBarPaises.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(542, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapital.Location = new System.Drawing.Point(542, 90);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(61, 16);
            this.lblCapital.TabIndex = 4;
            this.lblCapital.Text = "Capital:";
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiao.Location = new System.Drawing.Point(542, 127);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(63, 16);
            this.lblRegiao.TabIndex = 5;
            this.lblRegiao.Text = "Região:";
            // 
            // lblSubRegiao
            // 
            this.lblSubRegiao.AutoSize = true;
            this.lblSubRegiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubRegiao.Location = new System.Drawing.Point(542, 167);
            this.lblSubRegiao.Name = "lblSubRegiao";
            this.lblSubRegiao.Size = new System.Drawing.Size(89, 16);
            this.lblSubRegiao.TabIndex = 6;
            this.lblSubRegiao.Text = "Sub-região:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(52, 486);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 16);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // blPopulacao
            // 
            this.blPopulacao.AutoSize = true;
            this.blPopulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blPopulacao.Location = new System.Drawing.Point(542, 205);
            this.blPopulacao.Name = "blPopulacao";
            this.blPopulacao.Size = new System.Drawing.Size(87, 16);
            this.blPopulacao.TabIndex = 8;
            this.blPopulacao.Text = "População:";
            // 
            // lblGini
            // 
            this.lblGini.AutoSize = true;
            this.lblGini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGini.Location = new System.Drawing.Point(542, 247);
            this.lblGini.Name = "lblGini";
            this.lblGini.Size = new System.Drawing.Size(39, 16);
            this.lblGini.TabIndex = 9;
            this.lblGini.Text = "Gini:";
            // 
            // lblBandeira
            // 
            this.lblBandeira.AutoSize = true;
            this.lblBandeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandeira.Location = new System.Drawing.Point(106, 279);
            this.lblBandeira.Name = "lblBandeira";
            this.lblBandeira.Size = new System.Drawing.Size(39, 16);
            this.lblBandeira.TabIndex = 10;
            this.lblBandeira.Text = "Gini:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 543);
            this.Controls.Add(this.lblBandeira);
            this.Controls.Add(this.lblGini);
            this.Controls.Add(this.blPopulacao);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSubRegiao);
            this.Controls.Add(this.lblRegiao);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.progressBarPaises);
            this.Controls.Add(this.lbPaises);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bandeira:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPaises;
        private System.Windows.Forms.ProgressBar progressBarPaises;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label lblRegiao;
        private System.Windows.Forms.Label lblSubRegiao;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label blPopulacao;
        private System.Windows.Forms.Label lblGini;
        private System.Windows.Forms.Label lblBandeira;
    }
}

