namespace Symulator_wyscigow
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCat1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxCat1
            // 
            this.pictureBoxCat1.Image = global::Symulator_wyscigow.Properties.Resources.runingCat;
            this.pictureBoxCat1.Location = new System.Drawing.Point(30, 30);
            this.pictureBoxCat1.Name = "pictureBoxCat1";
            this.pictureBoxCat1.Size = new System.Drawing.Size(100, 30);
            this.pictureBoxCat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCat1.TabIndex = 1;
            this.pictureBoxCat1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Symulator_wyscigow.Properties.Resources.runingCat;
            this.pictureBox3.Location = new System.Drawing.Point(30, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Symulator_wyscigow.Properties.Resources.runingCat;
            this.pictureBox4.Location = new System.Drawing.Point(30, 102);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Symulator_wyscigow.Properties.Resources.runingCat;
            this.pictureBox5.Location = new System.Drawing.Point(30, 138);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(836, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 97);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBoxCat1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dzien na wyscigach";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxCat1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
    }
}

