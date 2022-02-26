namespace SekillerDunyasi
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
            this.pnlCizim = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSekiller = new System.Windows.Forms.ListBox();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudGen = new System.Windows.Forms.NumericUpDown();
            this.nudYuk = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTur = new System.Windows.Forms.ComboBox();
            this.cdiRenk = new System.Windows.Forms.ColorDialog();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.pboRenk = new System.Windows.Forms.PictureBox();
            this.btnTumunuSil = new System.Windows.Forms.Button();
            this.sfdSekiller = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCizim
            // 
            this.pnlCizim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCizim.BackColor = System.Drawing.Color.White;
            this.pnlCizim.Location = new System.Drawing.Point(658, 12);
            this.pnlCizim.Name = "pnlCizim";
            this.pnlCizim.Size = new System.Drawing.Size(801, 687);
            this.pnlCizim.TabIndex = 0;
            this.pnlCizim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizim_Paint);
            this.pnlCizim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCizim_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(511, 32);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 29);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(41, 32);
            this.nudX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(75, 29);
            this.nudX.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTur);
            this.groupBox1.Controls.Add(this.pboRenk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudYuk);
            this.groupBox1.Controls.Add(this.nudGen);
            this.groupBox1.Controls.Add(this.nudY);
            this.groupBox1.Controls.Add(this.nudX);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Şekil";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.lstSekiller);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 533);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şekiller";
            // 
            // lstSekiller
            // 
            this.lstSekiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSekiller.FormattingEnabled = true;
            this.lstSekiller.ItemHeight = 24;
            this.lstSekiller.Location = new System.Drawing.Point(3, 25);
            this.lstSekiller.Name = "lstSekiller";
            this.lstSekiller.Size = new System.Drawing.Size(586, 505);
            this.lstSekiller.TabIndex = 0;
            this.lstSekiller.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSekiller_KeyDown);
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(41, 67);
            this.nudY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(75, 29);
            this.nudY.TabIndex = 3;
            // 
            // nudGen
            // 
            this.nudGen.Location = new System.Drawing.Point(275, 32);
            this.nudGen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGen.Name = "nudGen";
            this.nudGen.Size = new System.Drawing.Size(75, 29);
            this.nudGen.TabIndex = 4;
            this.nudGen.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudYuk
            // 
            this.nudYuk.Location = new System.Drawing.Point(275, 67);
            this.nudYuk.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudYuk.Name = "nudYuk";
            this.nudYuk.Size = new System.Drawing.Size(75, 29);
            this.nudYuk.TabIndex = 5;
            this.nudYuk.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Genişlik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yükseklik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Renk:";
            // 
            // cboTur
            // 
            this.cboTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTur.FormattingEnabled = true;
            this.cboTur.Items.AddRange(new object[] {
            "Dikdörtgen",
            "Elips"});
            this.cboTur.Location = new System.Drawing.Point(415, 66);
            this.cboTur.Name = "cboTur";
            this.cboTur.Size = new System.Drawing.Size(171, 32);
            this.cboTur.TabIndex = 11;
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = global::SekillerDunyasi.Properties.Resources.up;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Location = new System.Drawing.Point(607, 373);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(45, 43);
            this.btnUp.TabIndex = 2;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = global::SekillerDunyasi.Properties.Resources.down;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Location = new System.Drawing.Point(607, 422);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(45, 43);
            this.btnDown.TabIndex = 1;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // pboRenk
            // 
            this.pboRenk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pboRenk.Location = new System.Drawing.Point(476, 32);
            this.pboRenk.Name = "pboRenk";
            this.pboRenk.Size = new System.Drawing.Size(29, 29);
            this.pboRenk.TabIndex = 10;
            this.pboRenk.TabStop = false;
            this.pboRenk.Click += new System.EventHandler(this.pboRenk_Click);
            // 
            // btnTumunuSil
            // 
            this.btnTumunuSil.Location = new System.Drawing.Point(488, 670);
            this.btnTumunuSil.Name = "btnTumunuSil";
            this.btnTumunuSil.Size = new System.Drawing.Size(116, 29);
            this.btnTumunuSil.TabIndex = 5;
            this.btnTumunuSil.Text = "Tümünü Sil";
            this.btnTumunuSil.UseVisualStyleBackColor = true;
            this.btnTumunuSil.Click += new System.EventHandler(this.btnTumunuSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 711);
            this.Controls.Add(this.btnTumunuSil);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlCizim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Şekiller Dünyası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCizim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTur;
        private System.Windows.Forms.PictureBox pboRenk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudYuk;
        private System.Windows.Forms.NumericUpDown nudGen;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSekiller;
        private System.Windows.Forms.ColorDialog cdiRenk;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnTumunuSil;
        private System.Windows.Forms.SaveFileDialog sfdSekiller;
    }
}

