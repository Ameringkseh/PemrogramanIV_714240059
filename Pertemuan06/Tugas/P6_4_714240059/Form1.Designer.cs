namespace P6_4_714240059
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtKodeMisi = new System.Windows.Forms.TextBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAngka
            // 
            this.txtAngka.BackColor = System.Drawing.Color.DarkGray;
            this.txtAngka.ForeColor = System.Drawing.Color.White;
            this.txtAngka.Location = new System.Drawing.Point(50, 220);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(100, 27);
            this.txtAngka.TabIndex = 0;
            this.txtAngka.TextChanged += new System.EventHandler(this.txtAngka_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.DarkGray;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(50, 280);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 27);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.DarkGray;
            this.txtNama.ForeColor = System.Drawing.Color.White;
            this.txtNama.Location = new System.Drawing.Point(50, 100);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(380, 27);
            this.txtNama.TabIndex = 2;
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // txtHuruf
            // 
            this.txtHuruf.BackColor = System.Drawing.Color.DarkGray;
            this.txtHuruf.ForeColor = System.Drawing.Color.White;
            this.txtHuruf.Location = new System.Drawing.Point(50, 160);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(380, 27);
            this.txtHuruf.TabIndex = 3;
            this.txtHuruf.Leave += new System.EventHandler(this.txtHuruf_Leave);
            // 
            // txtTelepon
            // 
            this.txtTelepon.BackColor = System.Drawing.Color.DarkGray;
            this.txtTelepon.ForeColor = System.Drawing.Color.White;
            this.txtTelepon.Location = new System.Drawing.Point(50, 340);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(380, 27);
            this.txtTelepon.TabIndex = 4;
            this.txtTelepon.TextChanged += new System.EventHandler(this.txtTelepon_TextChanged);
            // 
            // txtKodeMisi
            // 
            this.txtKodeMisi.BackColor = System.Drawing.Color.DarkGray;
            this.txtKodeMisi.ForeColor = System.Drawing.Color.White;
            this.txtKodeMisi.Location = new System.Drawing.Point(50, 460);
            this.txtKodeMisi.Name = "txtKodeMisi";
            this.txtKodeMisi.Size = new System.Drawing.Size(180, 27);
            this.txtKodeMisi.TabIndex = 5;
            this.txtKodeMisi.TextChanged += new System.EventHandler(this.txtKodeMisi_TextChanged);
            // 
            // txtPass1
            // 
            this.txtPass1.BackColor = System.Drawing.Color.DarkGray;
            this.txtPass1.ForeColor = System.Drawing.Color.White;
            this.txtPass1.Location = new System.Drawing.Point(50, 400);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(180, 27);
            this.txtPass1.TabIndex = 6;
            this.txtPass1.TextChanged += new System.EventHandler(this.txtPass1_TextChanged);
            // 
            // txtPass2
            // 
            this.txtPass2.BackColor = System.Drawing.Color.DarkGray;
            this.txtPass2.ForeColor = System.Drawing.Color.White;
            this.txtPass2.Location = new System.Drawing.Point(250, 400);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(180, 27);
            this.txtPass2.TabIndex = 7;
            this.txtPass2.TextChanged += new System.EventHandler(this.txtPass2_TextChanged);
            // 
            // epWarning
            // 
            this.epWarning.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(50, 520);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(380, 45);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "[ INITIALIZE UPLOAD ]";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nama Lengkap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama Samaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Umur Agen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kode Misi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email Terenkripsi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "No. Jalur Darurat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Konfirmasi Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.DarkGray;
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(250, 460);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 27);
            this.txtUsername.TabIndex = 18;
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Cyan;
            this.label10.Location = new System.Drawing.Point(100, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(367, 36);
            this.label10.TabIndex = 19;
            this.label10.Text = "NEW AGENT REGISTRATION";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // epCorrect
            // 
            this.epCorrect.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // chkShowPass
            // 
            this.chkShowPass.Location = new System.Drawing.Point(452, 400);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(41, 25);
            this.chkShowPass.TabIndex = 20;
            this.chkShowPass.Text = "👁️";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(502, 603);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.txtKodeMisi);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtHuruf);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAngka);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CyberOps Agency Recruitment";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtKodeMisi;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.CheckBox chkShowPass;
    }
}

