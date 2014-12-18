namespace ICU
{
    partial class ICU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ICU));
            this.vykdyti1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tikrinti = new System.Windows.Forms.RadioButton();
            this.trinti = new System.Windows.Forms.RadioButton();
            this.vykdyti2 = new System.Windows.Forms.Button();
            this.exportas = new System.Windows.Forms.RadioButton();
            this.Įjungti = new System.Windows.Forms.RadioButton();
            this.isjungti = new System.Windows.Forms.RadioButton();
            this.imageOff = new System.Windows.Forms.PictureBox();
            this.imageOn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOn)).BeginInit();
            this.SuspendLayout();
            // 
            // vykdyti1
            // 
            this.vykdyti1.Location = new System.Drawing.Point(61, 205);
            this.vykdyti1.Name = "vykdyti1";
            this.vykdyti1.Size = new System.Drawing.Size(134, 26);
            this.vykdyti1.TabIndex = 0;
            this.vykdyti1.Text = "Vykdyti";
            this.vykdyti1.UseVisualStyleBackColor = true;
            this.vykdyti1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Įveskite Slaptažodį";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 33);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tikrinti);
            this.panel1.Controls.Add(this.trinti);
            this.panel1.Controls.Add(this.vykdyti2);
            this.panel1.Controls.Add(this.exportas);
            this.panel1.Controls.Add(this.Įjungti);
            this.panel1.Controls.Add(this.isjungti);
            this.panel1.Controls.Add(this.imageOn);
            this.panel1.Controls.Add(this.imageOff);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 264);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "* Ištrinti galima tik tada kai programos yra išjungtos";
            this.label2.Visible = false;
            // 
            // tikrinti
            // 
            this.tikrinti.AutoSize = true;
            this.tikrinti.Location = new System.Drawing.Point(25, 157);
            this.tikrinti.Name = "tikrinti";
            this.tikrinti.Size = new System.Drawing.Size(188, 17);
            this.tikrinti.TabIndex = 5;
            this.tikrinti.TabStop = true;
            this.tikrinti.Text = "Patikrinti Sekimo programų būseną";
            this.tikrinti.UseVisualStyleBackColor = true;
            this.tikrinti.Visible = false;
            // 
            // trinti
            // 
            this.trinti.AutoSize = true;
            this.trinti.Location = new System.Drawing.Point(25, 134);
            this.trinti.Name = "trinti";
            this.trinti.Size = new System.Drawing.Size(145, 17);
            this.trinti.TabIndex = 4;
            this.trinti.TabStop = true;
            this.trinti.Text = "Ištrinti Sekimo duomenis *";
            this.trinti.UseVisualStyleBackColor = true;
            // 
            // vykdyti2
            // 
            this.vykdyti2.Location = new System.Drawing.Point(44, 199);
            this.vykdyti2.Name = "vykdyti2";
            this.vykdyti2.Size = new System.Drawing.Size(169, 32);
            this.vykdyti2.TabIndex = 3;
            this.vykdyti2.Text = "Vykdyti";
            this.vykdyti2.UseVisualStyleBackColor = true;
            this.vykdyti2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exportas
            // 
            this.exportas.AutoSize = true;
            this.exportas.Location = new System.Drawing.Point(25, 111);
            this.exportas.Name = "exportas";
            this.exportas.Size = new System.Drawing.Size(162, 17);
            this.exportas.TabIndex = 2;
            this.exportas.TabStop = true;
            this.exportas.Text = "Eksportuoti sekimo duomenis";
            this.exportas.UseVisualStyleBackColor = true;
            // 
            // Įjungti
            // 
            this.Įjungti.AutoSize = true;
            this.Įjungti.Location = new System.Drawing.Point(25, 88);
            this.Įjungti.Name = "Įjungti";
            this.Įjungti.Size = new System.Drawing.Size(91, 17);
            this.Įjungti.TabIndex = 1;
            this.Įjungti.TabStop = true;
            this.Įjungti.Text = "Ijungti Sekima";
            this.Įjungti.UseVisualStyleBackColor = true;
            // 
            // isjungti
            // 
            this.isjungti.AutoSize = true;
            this.isjungti.Location = new System.Drawing.Point(25, 65);
            this.isjungti.Name = "isjungti";
            this.isjungti.Size = new System.Drawing.Size(96, 17);
            this.isjungti.TabIndex = 0;
            this.isjungti.TabStop = true;
            this.isjungti.Text = "Išjungti Sekima";
            this.isjungti.UseVisualStyleBackColor = true;
            // 
            // imageOff
            // 
            this.imageOff.Image = ((System.Drawing.Image)(resources.GetObject("imageOff.Image")));
            this.imageOff.Location = new System.Drawing.Point(25, 13);
            this.imageOff.Name = "imageOff";
            this.imageOff.Size = new System.Drawing.Size(100, 50);
            this.imageOff.TabIndex = 8;
            this.imageOff.TabStop = false;
            // 
            // imageOn
            // 
            this.imageOn.Image = ((System.Drawing.Image)(resources.GetObject("imageOn.Image")));
            this.imageOn.InitialImage = null;
            this.imageOn.Location = new System.Drawing.Point(25, 13);
            this.imageOn.Name = "imageOn";
            this.imageOn.Size = new System.Drawing.Size(100, 50);
            this.imageOn.TabIndex = 7;
            this.imageOn.TabStop = false;
            // 
            // ICU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(273, 265);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vykdyti1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ICU";
            this.Text = "I See You v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vykdyti1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button vykdyti2;
        private System.Windows.Forms.RadioButton exportas;
        private System.Windows.Forms.RadioButton Įjungti;
        private System.Windows.Forms.RadioButton isjungti;
        private System.Windows.Forms.RadioButton tikrinti;
        private System.Windows.Forms.RadioButton trinti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imageOn;
        private System.Windows.Forms.PictureBox imageOff;

    }
}

