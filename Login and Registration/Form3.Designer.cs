namespace Login_and_Registration
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtEnter
            // 
            this.txtEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter.ForeColor = System.Drawing.Color.Black;
            this.txtEnter.Location = new System.Drawing.Point(32, 278);
            this.txtEnter.Multiline = true;
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(340, 57);
            this.txtEnter.TabIndex = 1;
            this.txtEnter.TextChanged += new System.EventHandler(this.txtEnter_TextChanged);
            this.txtEnter.Enter += new System.EventHandler(this.txtEnter_Enter);
            this.txtEnter.Leave += new System.EventHandler(this.txtEnter_Leave);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(390, 269);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(114, 76);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReplace.BackgroundImage")));
            this.btnReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplace.Location = new System.Drawing.Point(11, 175);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(91, 73);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCaptcha.BackgroundImage")));
            this.pictureBoxCaptcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(187, 29);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(159, 127);
            this.pictureBoxCaptcha.TabIndex = 4;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // txtRandom
            // 
            this.txtRandom.Font = new System.Drawing.Font("Chiller", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRandom.Location = new System.Drawing.Point(117, 175);
            this.txtRandom.Multiline = true;
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.Size = new System.Drawing.Size(404, 63);
            this.txtRandom.TabIndex = 5;
            this.txtRandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(5, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 35);
            this.btnBack.TabIndex = 31;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 370);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtRandom);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reCaptcha Form";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.TextBox txtRandom;
        private System.Windows.Forms.Button btnBack;
    }
}