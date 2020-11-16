namespace GubbeSomFaller
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
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.tbxVisa = new System.Windows.Forms.TextBox();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.lblResutate = new System.Windows.Forms.Label();
            this.pbxGubbe = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxSky = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSexBokst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGubbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSky)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rätt svar";
            // 
            // tbxSvar
            // 
            this.tbxSvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSvar.Location = new System.Drawing.Point(182, 63);
            this.tbxSvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.PasswordChar = '?';
            this.tbxSvar.Size = new System.Drawing.Size(142, 26);
            this.tbxSvar.TabIndex = 1;
            this.tbxSvar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxSvar.TextChanged += new System.EventHandler(this.tbxSvar_TextChanged);
            // 
            // tbxVisa
            // 
            this.tbxVisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxVisa.BackColor = System.Drawing.Color.White;
            this.tbxVisa.Enabled = false;
            this.tbxVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVisa.Location = new System.Drawing.Point(38, 662);
            this.tbxVisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxVisa.Name = "tbxVisa";
            this.tbxVisa.ReadOnly = true;
            this.tbxVisa.Size = new System.Drawing.Size(451, 43);
            this.tbxVisa.TabIndex = 4;
            this.tbxVisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxVisa.TextChanged += new System.EventHandler(this.tbxVisa_TextChanged);
            // 
            // tbxGissa
            // 
            this.tbxGissa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxGissa.Location = new System.Drawing.Point(216, 719);
            this.tbxGissa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(91, 26);
            this.tbxGissa.TabIndex = 5;
            this.tbxGissa.TextChanged += new System.EventHandler(this.tbxGissa_TextChanged);
            // 
            // lblResutate
            // 
            this.lblResutate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResutate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResutate.Location = new System.Drawing.Point(81, 765);
            this.lblResutate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResutate.Name = "lblResutate";
            this.lblResutate.Size = new System.Drawing.Size(362, 40);
            this.lblResutate.TabIndex = 6;
            this.lblResutate.Text = "Gissa på en bokstav";
            this.lblResutate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxGubbe
            // 
            this.pbxGubbe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxGubbe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxGubbe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxGubbe.Image = global::GubbeSomFaller.Properties.Resources._10090_face_with_monocle_icon;
            this.pbxGubbe.Location = new System.Drawing.Point(180, 152);
            this.pbxGubbe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxGubbe.Name = "pbxGubbe";
            this.pbxGubbe.Size = new System.Drawing.Size(150, 128);
            this.pbxGubbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGubbe.TabIndex = 7;
            this.pbxGubbe.TabStop = false;
            this.pbxGubbe.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(38, 588);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 55);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pbxSky
            // 
            this.pbxSky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxSky.InitialImage = null;
            this.pbxSky.Location = new System.Drawing.Point(38, 103);
            this.pbxSky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxSky.Name = "pbxSky";
            this.pbxSky.Size = new System.Drawing.Size(453, 485);
            this.pbxSky.TabIndex = 2;
            this.pbxSky.TabStop = false;
            this.pbxSky.Click += new System.EventHandler(this.pbxSky_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lätt",
            "Svårt"});
            this.comboBox1.Location = new System.Drawing.Point(12, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // lblSexBokst
            // 
            this.lblSexBokst.AutoSize = true;
            this.lblSexBokst.BackColor = System.Drawing.Color.Transparent;
            this.lblSexBokst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSexBokst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSexBokst.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSexBokst.Location = new System.Drawing.Point(276, 94);
            this.lblSexBokst.Name = "lblSexBokst";
            this.lblSexBokst.Size = new System.Drawing.Size(169, 22);
            this.lblSexBokst.TabIndex = 9;
            this.lblSexBokst.Text = "bör vara sex bokstäver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nivå";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 824);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSexBokst);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pbxGubbe);
            this.Controls.Add(this.lblResutate);
            this.Controls.Add(this.tbxGissa);
            this.Controls.Add(this.tbxVisa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxSky);
            this.Controls.Add(this.tbxSvar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Gubbe som faller, typ";
            ((System.ComponentModel.ISupportInitialize)(this.pbxGubbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSvar;
        private System.Windows.Forms.PictureBox pbxSky;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxVisa;
        private System.Windows.Forms.TextBox tbxGissa;
        private System.Windows.Forms.Label lblResutate;
        private System.Windows.Forms.PictureBox pbxGubbe;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSexBokst;
        private System.Windows.Forms.Label label2;
    }
}

