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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIt = new System.Windows.Forms.Label();
            this.lblFr = new System.Windows.Forms.Label();
            this.lblJa = new System.Windows.Forms.Label();
            this.lblEs = new System.Windows.Forms.Label();
            this.lblBr = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblPt = new System.Windows.Forms.Label();
            this.lblNl = new System.Windows.Forms.Label();
            this.lblHr = new System.Windows.Forms.Label();
            this.lblFa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Países:";
            // 
            // lbPaises
            // 
            this.lbPaises.FormattingEnabled = true;
            this.lbPaises.Location = new System.Drawing.Point(51, 70);
            this.lbPaises.Name = "lbPaises";
            this.lbPaises.Size = new System.Drawing.Size(253, 225);
            this.lbPaises.TabIndex = 1;
            this.lbPaises.SelectedIndexChanged += new System.EventHandler(this.lbPaises_SelectedIndexChanged);
            // 
            // progressBarPaises
            // 
            this.progressBarPaises.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBarPaises.Location = new System.Drawing.Point(726, 659);
            this.progressBarPaises.Name = "progressBarPaises";
            this.progressBarPaises.Size = new System.Drawing.Size(310, 23);
            this.progressBarPaises.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(449, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapital.Location = new System.Drawing.Point(449, 241);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(42, 13);
            this.lblCapital.TabIndex = 4;
            this.lblCapital.Text = "Capital:";
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiao.Location = new System.Drawing.Point(449, 96);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(44, 13);
            this.lblRegiao.TabIndex = 5;
            this.lblRegiao.Text = "Região:";
            // 
            // lblSubRegiao
            // 
            this.lblSubRegiao.AutoSize = true;
            this.lblSubRegiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubRegiao.Location = new System.Drawing.Point(449, 129);
            this.lblSubRegiao.Name = "lblSubRegiao";
            this.lblSubRegiao.Size = new System.Drawing.Size(61, 13);
            this.lblSubRegiao.TabIndex = 6;
            this.lblSubRegiao.Text = "Sub-região:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(48, 633);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 16);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // blPopulacao
            // 
            this.blPopulacao.AutoSize = true;
            this.blPopulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blPopulacao.Location = new System.Drawing.Point(449, 162);
            this.blPopulacao.Name = "blPopulacao";
            this.blPopulacao.Size = new System.Drawing.Size(61, 13);
            this.blPopulacao.TabIndex = 8;
            this.blPopulacao.Text = "População:";
            // 
            // lblGini
            // 
            this.lblGini.AutoSize = true;
            this.lblGini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGini.Location = new System.Drawing.Point(449, 200);
            this.lblGini.Name = "lblGini";
            this.lblGini.Size = new System.Drawing.Size(28, 13);
            this.lblGini.TabIndex = 9;
            this.lblGini.Text = "Gini:";
            // 
            // lblBandeira
            // 
            this.lblBandeira.AutoSize = true;
            this.lblBandeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandeira.Location = new System.Drawing.Point(97, 327);
            this.lblBandeira.Name = "lblBandeira";
            this.lblBandeira.Size = new System.Drawing.Size(75, 16);
            this.lblBandeira.TabIndex = 10;
            this.lblBandeira.Text = "Bandeira:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 386);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(741, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Traduções:";
            // 
            // lblIt
            // 
            this.lblIt.AutoSize = true;
            this.lblIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIt.Location = new System.Drawing.Point(741, 152);
            this.lblIt.Name = "lblIt";
            this.lblIt.Size = new System.Drawing.Size(20, 13);
            this.lblIt.TabIndex = 18;
            this.lblIt.Text = "IT:";
            // 
            // lblFr
            // 
            this.lblFr.AutoSize = true;
            this.lblFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFr.Location = new System.Drawing.Point(740, 107);
            this.lblFr.Name = "lblFr";
            this.lblFr.Size = new System.Drawing.Size(24, 13);
            this.lblFr.TabIndex = 17;
            this.lblFr.Text = "FR:";
            // 
            // lblJa
            // 
            this.lblJa.AutoSize = true;
            this.lblJa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJa.Location = new System.Drawing.Point(740, 129);
            this.lblJa.Name = "lblJa";
            this.lblJa.Size = new System.Drawing.Size(22, 13);
            this.lblJa.TabIndex = 16;
            this.lblJa.Text = "JA:";
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEs.Location = new System.Drawing.Point(740, 80);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(24, 13);
            this.lblEs.TabIndex = 15;
            this.lblEs.Text = "ES:";
            // 
            // lblBr
            // 
            this.lblBr.AutoSize = true;
            this.lblBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBr.Location = new System.Drawing.Point(740, 174);
            this.lblBr.Name = "lblBr";
            this.lblBr.Size = new System.Drawing.Size(25, 13);
            this.lblBr.TabIndex = 14;
            this.lblBr.Text = "BR:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(741, 58);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(25, 13);
            this.lblDe.TabIndex = 13;
            this.lblDe.Text = "DE:";
            // 
            // lblPt
            // 
            this.lblPt.AutoSize = true;
            this.lblPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPt.Location = new System.Drawing.Point(740, 200);
            this.lblPt.Name = "lblPt";
            this.lblPt.Size = new System.Drawing.Size(24, 13);
            this.lblPt.TabIndex = 19;
            this.lblPt.Text = "PT:";
            // 
            // lblNl
            // 
            this.lblNl.AutoSize = true;
            this.lblNl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNl.Location = new System.Drawing.Point(740, 229);
            this.lblNl.Name = "lblNl";
            this.lblNl.Size = new System.Drawing.Size(24, 13);
            this.lblNl.TabIndex = 20;
            this.lblNl.Text = "NL:";
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.Location = new System.Drawing.Point(740, 255);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(26, 13);
            this.lblHr.TabIndex = 21;
            this.lblHr.Text = "HR:";
            // 
            // lblFa
            // 
            this.lblFa.AutoSize = true;
            this.lblFa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFa.Location = new System.Drawing.Point(741, 282);
            this.lblFa.Name = "lblFa";
            this.lblFa.Size = new System.Drawing.Size(23, 13);
            this.lblFa.TabIndex = 22;
            this.lblFa.Text = "FA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Numeric Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Native Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Area:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Demonym:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cioc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Lat/Lng:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFa);
            this.Controls.Add(this.lblHr);
            this.Controls.Add(this.lblNl);
            this.Controls.Add(this.lblPt);
            this.Controls.Add(this.lblIt);
            this.Controls.Add(this.lblFr);
            this.Controls.Add(this.lblJa);
            this.Controls.Add(this.lblEs);
            this.Controls.Add(this.lblBr);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Países";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIt;
        private System.Windows.Forms.Label lblFr;
        private System.Windows.Forms.Label lblJa;
        private System.Windows.Forms.Label lblEs;
        private System.Windows.Forms.Label lblBr;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblPt;
        private System.Windows.Forms.Label lblNl;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Label lblFa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

