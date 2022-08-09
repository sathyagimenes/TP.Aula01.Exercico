namespace TP.Aula01
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEnter.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnter.Location = new System.Drawing.Point(128, 403);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(252, 89);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(472, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(252, 89);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbUser
            // 
            this.txbUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbUser.Location = new System.Drawing.Point(306, 248);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(365, 26);
            this.txbUser.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(174, 249);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 22);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(174, 304);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(110, 22);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPassword.Location = new System.Drawing.Point(306, 303);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(365, 26);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP.Aula01.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(255, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(834, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnter;
        private Button btnCancel;
        private TextBox txbUser;
        private Label lblUser;
        private Label lblPassword;
        private TextBox txbPassword;
        private PictureBox pictureBox1;
    }
}