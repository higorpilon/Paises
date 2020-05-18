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
            this.lblPopulacao = new System.Windows.Forms.Label();
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
            this.lblNumeric = new System.Windows.Forms.Label();
            this.lblNative = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblDemonym = new System.Windows.Forms.Label();
            this.lblCioc = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lbCurrencies = new System.Windows.Forms.ListBox();
            this.lbLanguages = new System.Windows.Forms.ListBox();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.lbBorders = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Países:";
            // 
            // lbPaises
            // 
            this.lbPaises.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPaises.FormattingEnabled = true;
            this.lbPaises.Location = new System.Drawing.Point(51, 70);
            this.lbPaises.Name = "lbPaises";
            this.lbPaises.Size = new System.Drawing.Size(253, 223);
            this.lbPaises.TabIndex = 1;
            this.lbPaises.SelectedIndexChanged += new System.EventHandler(this.lbPaises_SelectedIndexChanged);
            // 
            // progressBarPaises
            // 
            this.progressBarPaises.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBarPaises.Location = new System.Drawing.Point(48, 667);
            this.progressBarPaises.Name = "progressBarPaises";
            this.progressBarPaises.Size = new System.Drawing.Size(310, 23);
            this.progressBarPaises.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(367, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapital.Location = new System.Drawing.Point(367, 177);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(44, 15);
            this.lblCapital.TabIndex = 4;
            this.lblCapital.Text = "Capital:";
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegiao.Location = new System.Drawing.Point(367, 84);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(46, 15);
            this.lblRegiao.TabIndex = 5;
            this.lblRegiao.Text = "Região:";
            // 
            // lblSubRegiao
            // 
            this.lblSubRegiao.AutoSize = true;
            this.lblSubRegiao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubRegiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubRegiao.Location = new System.Drawing.Point(367, 106);
            this.lblSubRegiao.Name = "lblSubRegiao";
            this.lblSubRegiao.Size = new System.Drawing.Size(63, 15);
            this.lblSubRegiao.TabIndex = 6;
            this.lblSubRegiao.Text = "Sub-região:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(45, 635);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 16);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // lblPopulacao
            // 
            this.lblPopulacao.AutoSize = true;
            this.lblPopulacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPopulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulacao.Location = new System.Drawing.Point(367, 129);
            this.lblPopulacao.Name = "lblPopulacao";
            this.lblPopulacao.Size = new System.Drawing.Size(63, 15);
            this.lblPopulacao.TabIndex = 8;
            this.lblPopulacao.Text = "População:";
            // 
            // lblGini
            // 
            this.lblGini.AutoSize = true;
            this.lblGini.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGini.Location = new System.Drawing.Point(367, 151);
            this.lblGini.Name = "lblGini";
            this.lblGini.Size = new System.Drawing.Size(30, 15);
            this.lblGini.TabIndex = 9;
            this.lblGini.Text = "Gini:";
            // 
            // lblBandeira
            // 
            this.lblBandeira.AutoSize = true;
            this.lblBandeira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBandeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandeira.Location = new System.Drawing.Point(51, 329);
            this.lblBandeira.Name = "lblBandeira";
            this.lblBandeira.Size = new System.Drawing.Size(41, 18);
            this.lblBandeira.TabIndex = 10;
            this.lblBandeira.Text = "Flag";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(51, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(741, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Traduções:";
            // 
            // lblIt
            // 
            this.lblIt.AutoSize = true;
            this.lblIt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIt.Location = new System.Drawing.Point(741, 152);
            this.lblIt.Name = "lblIt";
            this.lblIt.Size = new System.Drawing.Size(22, 15);
            this.lblIt.TabIndex = 18;
            this.lblIt.Text = "IT:";
            // 
            // lblFr
            // 
            this.lblFr.AutoSize = true;
            this.lblFr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFr.Location = new System.Drawing.Point(741, 107);
            this.lblFr.Name = "lblFr";
            this.lblFr.Size = new System.Drawing.Size(26, 15);
            this.lblFr.TabIndex = 17;
            this.lblFr.Text = "FR:";
            // 
            // lblJa
            // 
            this.lblJa.AutoSize = true;
            this.lblJa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJa.Location = new System.Drawing.Point(741, 129);
            this.lblJa.Name = "lblJa";
            this.lblJa.Size = new System.Drawing.Size(24, 15);
            this.lblJa.TabIndex = 16;
            this.lblJa.Text = "JA:";
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEs.Location = new System.Drawing.Point(741, 80);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(26, 15);
            this.lblEs.TabIndex = 15;
            this.lblEs.Text = "ES:";
            // 
            // lblBr
            // 
            this.lblBr.AutoSize = true;
            this.lblBr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBr.Location = new System.Drawing.Point(741, 174);
            this.lblBr.Name = "lblBr";
            this.lblBr.Size = new System.Drawing.Size(27, 15);
            this.lblBr.TabIndex = 14;
            this.lblBr.Text = "BR:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(741, 58);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(27, 15);
            this.lblDe.TabIndex = 13;
            this.lblDe.Text = "DE:";
            // 
            // lblPt
            // 
            this.lblPt.AutoSize = true;
            this.lblPt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPt.Location = new System.Drawing.Point(741, 200);
            this.lblPt.Name = "lblPt";
            this.lblPt.Size = new System.Drawing.Size(26, 15);
            this.lblPt.TabIndex = 19;
            this.lblPt.Text = "PT:";
            // 
            // lblNl
            // 
            this.lblNl.AutoSize = true;
            this.lblNl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNl.Location = new System.Drawing.Point(741, 229);
            this.lblNl.Name = "lblNl";
            this.lblNl.Size = new System.Drawing.Size(26, 15);
            this.lblNl.TabIndex = 20;
            this.lblNl.Text = "NL:";
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.Location = new System.Drawing.Point(741, 255);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(28, 15);
            this.lblHr.TabIndex = 21;
            this.lblHr.Text = "HR:";
            // 
            // lblFa
            // 
            this.lblFa.AutoSize = true;
            this.lblFa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFa.Location = new System.Drawing.Point(741, 282);
            this.lblFa.Name = "lblFa";
            this.lblFa.Size = new System.Drawing.Size(25, 15);
            this.lblFa.TabIndex = 22;
            this.lblFa.Text = "FA:";
            // 
            // lblNumeric
            // 
            this.lblNumeric.AutoSize = true;
            this.lblNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeric.Location = new System.Drawing.Point(367, 332);
            this.lblNumeric.Name = "lblNumeric";
            this.lblNumeric.Size = new System.Drawing.Size(79, 15);
            this.lblNumeric.TabIndex = 28;
            this.lblNumeric.Text = "Numeric Code:";
            // 
            // lblNative
            // 
            this.lblNative.AutoSize = true;
            this.lblNative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNative.Location = new System.Drawing.Point(367, 304);
            this.lblNative.Name = "lblNative";
            this.lblNative.Size = new System.Drawing.Size(74, 15);
            this.lblNative.TabIndex = 27;
            this.lblNative.Text = "Native Name:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(367, 273);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(34, 15);
            this.lblArea.TabIndex = 26;
            this.lblArea.Text = "Area:";
            // 
            // lblDemonym
            // 
            this.lblDemonym.AutoSize = true;
            this.lblDemonym.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDemonym.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemonym.Location = new System.Drawing.Point(367, 241);
            this.lblDemonym.Name = "lblDemonym";
            this.lblDemonym.Size = new System.Drawing.Size(59, 15);
            this.lblDemonym.TabIndex = 25;
            this.lblDemonym.Text = "Demonym:";
            // 
            // lblCioc
            // 
            this.lblCioc.AutoSize = true;
            this.lblCioc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCioc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCioc.Location = new System.Drawing.Point(367, 363);
            this.lblCioc.Name = "lblCioc";
            this.lblCioc.Size = new System.Drawing.Size(33, 15);
            this.lblCioc.TabIndex = 24;
            this.lblCioc.Text = "Cioc:";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(367, 206);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(50, 15);
            this.lblLat.TabIndex = 23;
            this.lblLat.Text = "Lat/Lng:";
            // 
            // lbCurrencies
            // 
            this.lbCurrencies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCurrencies.FormattingEnabled = true;
            this.lbCurrencies.Location = new System.Drawing.Point(367, 413);
            this.lbCurrencies.Name = "lbCurrencies";
            this.lbCurrencies.Size = new System.Drawing.Size(177, 54);
            this.lbCurrencies.TabIndex = 29;
            this.lbCurrencies.SelectedIndexChanged += new System.EventHandler(this.lbCurrencies_SelectedIndexChanged);
            // 
            // lbLanguages
            // 
            this.lbLanguages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLanguages.FormattingEnabled = true;
            this.lbLanguages.Location = new System.Drawing.Point(367, 486);
            this.lbLanguages.Name = "lbLanguages";
            this.lbLanguages.Size = new System.Drawing.Size(177, 54);
            this.lbLanguages.TabIndex = 30;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(599, 338);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(600, 313);
            this.map.TabIndex = 31;
            this.map.Zoom = 0D;
            // 
            // lbBorders
            // 
            this.lbBorders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBorders.FormattingEnabled = true;
            this.lbBorders.Location = new System.Drawing.Point(48, 532);
            this.lbBorders.Name = "lbBorders";
            this.lbBorders.Size = new System.Drawing.Size(275, 93);
            this.lbBorders.TabIndex = 32;
            this.lbBorders.DoubleClick += new System.EventHandler(this.lbBorders_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 749);
            this.Controls.Add(this.lbBorders);
            this.Controls.Add(this.map);
            this.Controls.Add(this.lbLanguages);
            this.Controls.Add(this.lbCurrencies);
            this.Controls.Add(this.lblNumeric);
            this.Controls.Add(this.lblNative);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblDemonym);
            this.Controls.Add(this.lblCioc);
            this.Controls.Add(this.lblLat);
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
            this.Controls.Add(this.lblPopulacao);
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
        private System.Windows.Forms.Label lblPopulacao;
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
        private System.Windows.Forms.Label lblNumeric;
        private System.Windows.Forms.Label lblNative;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblDemonym;
        private System.Windows.Forms.Label lblCioc;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.ListBox lbCurrencies;
        private System.Windows.Forms.ListBox lbLanguages;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.ListBox lbBorders;
    }
}

