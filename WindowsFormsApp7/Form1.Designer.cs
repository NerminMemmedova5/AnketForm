namespace WindowsFormsApp7
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
            this.registrationLbl = new System.Windows.Forms.Label();
            this.firstnametxtB = new System.Windows.Forms.TextBox();
            this.lastnametxtB = new System.Windows.Forms.TextBox();
            this.phonemskB = new System.Windows.Forms.MaskedTextBox();
            this.femalerdB = new System.Windows.Forms.RadioButton();
            this.malerdB = new System.Windows.Forms.RadioButton();
            this.gendergrpB = new System.Windows.Forms.GroupBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.birthdateLbl = new System.Windows.Forms.Label();
            this.birthdatemskB = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailtxtB = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.adressLbl = new System.Windows.Forms.Label();
            this.adressrchB = new System.Windows.Forms.RichTextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordtxtB = new System.Windows.Forms.TextBox();
            this.passwordnoteLbl = new System.Windows.Forms.Label();
            this.repeatpasswordLbl = new System.Windows.Forms.Label();
            this.repeatpasswordtxtB = new System.Windows.Forms.TextBox();
            this.repeatpasswordnoteLbl = new System.Windows.Forms.Label();
            this.signinBtn = new System.Windows.Forms.Button();
            this.gendergrpB.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationLbl
            // 
            this.registrationLbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.registrationLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrationLbl.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLbl.Location = new System.Drawing.Point(0, 0);
            this.registrationLbl.Name = "registrationLbl";
            this.registrationLbl.Size = new System.Drawing.Size(434, 83);
            this.registrationLbl.TabIndex = 0;
            this.registrationLbl.Text = "Registration Form";
            this.registrationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstnametxtB
            // 
            this.firstnametxtB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnametxtB.ForeColor = System.Drawing.Color.Silver;
            this.firstnametxtB.Location = new System.Drawing.Point(18, 129);
            this.firstnametxtB.Name = "firstnametxtB";
            this.firstnametxtB.Size = new System.Drawing.Size(177, 32);
            this.firstnametxtB.TabIndex = 1;
            this.firstnametxtB.Text = "First name";
            this.firstnametxtB.MouseEnter += new System.EventHandler(this.nametxtB_MouseEnter);
            this.firstnametxtB.MouseLeave += new System.EventHandler(this.nametxtB_MouseLeave);
            // 
            // lastnametxtB
            // 
            this.lastnametxtB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnametxtB.ForeColor = System.Drawing.Color.Silver;
            this.lastnametxtB.Location = new System.Drawing.Point(245, 129);
            this.lastnametxtB.Name = "lastnametxtB";
            this.lastnametxtB.Size = new System.Drawing.Size(177, 32);
            this.lastnametxtB.TabIndex = 2;
            this.lastnametxtB.Text = "Last name";
            this.lastnametxtB.MouseEnter += new System.EventHandler(this.lastnametxtB_MouseEnter);
            this.lastnametxtB.MouseLeave += new System.EventHandler(this.lastnametxtB_MouseLeave);
            // 
            // phonemskB
            // 
            this.phonemskB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonemskB.Location = new System.Drawing.Point(82, 365);
            this.phonemskB.Mask = "(+000) 00-000-00-00";
            this.phonemskB.Name = "phonemskB";
            this.phonemskB.Size = new System.Drawing.Size(336, 29);
            this.phonemskB.TabIndex = 3;
            // 
            // femalerdB
            // 
            this.femalerdB.AutoSize = true;
            this.femalerdB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalerdB.ForeColor = System.Drawing.Color.Silver;
            this.femalerdB.Location = new System.Drawing.Point(15, 31);
            this.femalerdB.Name = "femalerdB";
            this.femalerdB.Size = new System.Drawing.Size(99, 28);
            this.femalerdB.TabIndex = 4;
            this.femalerdB.TabStop = true;
            this.femalerdB.Text = "Female";
            this.femalerdB.UseVisualStyleBackColor = true;
            this.femalerdB.CheckedChanged += new System.EventHandler(this.femalerdB_CheckedChanged);
            // 
            // malerdB
            // 
            this.malerdB.AutoSize = true;
            this.malerdB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malerdB.ForeColor = System.Drawing.Color.Silver;
            this.malerdB.Location = new System.Drawing.Point(144, 31);
            this.malerdB.Name = "malerdB";
            this.malerdB.Size = new System.Drawing.Size(74, 28);
            this.malerdB.TabIndex = 5;
            this.malerdB.TabStop = true;
            this.malerdB.Text = "Male";
            this.malerdB.UseVisualStyleBackColor = true;
            this.malerdB.CheckedChanged += new System.EventHandler(this.malerdB_CheckedChanged);
            // 
            // gendergrpB
            // 
            this.gendergrpB.Controls.Add(this.femalerdB);
            this.gendergrpB.Controls.Add(this.malerdB);
            this.gendergrpB.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendergrpB.Location = new System.Drawing.Point(6, 167);
            this.gendergrpB.Name = "gendergrpB";
            this.gendergrpB.Size = new System.Drawing.Size(352, 62);
            this.gendergrpB.TabIndex = 6;
            this.gendergrpB.TabStop = false;
            this.gendergrpB.Text = "Gender";
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(12, 99);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(168, 27);
            this.nameLbl.TabIndex = 7;
            this.nameLbl.Text = "Name";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.Location = new System.Drawing.Point(238, 99);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(78, 23);
            this.surnameLbl.TabIndex = 8;
            this.surnameLbl.Text = "Surname";
            // 
            // birthdateLbl
            // 
            this.birthdateLbl.AutoSize = true;
            this.birthdateLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateLbl.Location = new System.Drawing.Point(12, 232);
            this.birthdateLbl.Name = "birthdateLbl";
            this.birthdateLbl.Size = new System.Drawing.Size(79, 23);
            this.birthdateLbl.TabIndex = 9;
            this.birthdateLbl.Text = "Birthdate";
            // 
            // birthdatemskB
            // 
            this.birthdatemskB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdatemskB.ForeColor = System.Drawing.Color.Black;
            this.birthdatemskB.Location = new System.Drawing.Point(20, 258);
            this.birthdatemskB.Mask = "00/00/0000";
            this.birthdatemskB.Name = "birthdatemskB";
            this.birthdatemskB.Size = new System.Drawing.Size(177, 32);
            this.birthdatemskB.TabIndex = 10;
            this.birthdatemskB.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(14, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Day/Month/Year";
            // 
            // emailLbl
            // 
            this.emailLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(12, 332);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(135, 28);
            this.emailLbl.TabIndex = 12;
            this.emailLbl.Text = "E-mail";
            // 
            // emailtxtB
            // 
            this.emailtxtB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxtB.ForeColor = System.Drawing.Color.Silver;
            this.emailtxtB.Location = new System.Drawing.Point(82, 330);
            this.emailtxtB.Name = "emailtxtB";
            this.emailtxtB.Size = new System.Drawing.Size(336, 29);
            this.emailtxtB.TabIndex = 13;
            this.emailtxtB.Text = "@gmail.com";
            this.emailtxtB.MouseEnter += new System.EventHandler(this.emailtxtB_MouseEnter);
            this.emailtxtB.MouseLeave += new System.EventHandler(this.emailtxtB_MouseLeave);
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(12, 371);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(59, 23);
            this.phoneLbl.TabIndex = 14;
            this.phoneLbl.Text = "Phone";
            // 
            // adressLbl
            // 
            this.adressLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressLbl.Location = new System.Drawing.Point(12, 421);
            this.adressLbl.Name = "adressLbl";
            this.adressLbl.Size = new System.Drawing.Size(66, 56);
            this.adressLbl.TabIndex = 15;
            this.adressLbl.Text = "Adress";
            // 
            // adressrchB
            // 
            this.adressrchB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressrchB.Location = new System.Drawing.Point(82, 419);
            this.adressrchB.Name = "adressrchB";
            this.adressrchB.Size = new System.Drawing.Size(336, 56);
            this.adressrchB.TabIndex = 16;
            this.adressrchB.Text = "";
            this.adressrchB.MouseEnter += new System.EventHandler(this.adressrchB_MouseEnter_1);
            this.adressrchB.MouseLeave += new System.EventHandler(this.adressrchB_MouseLeave_1);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(12, 494);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(85, 23);
            this.passwordLbl.TabIndex = 17;
            this.passwordLbl.Text = "Password";
            // 
            // passwordtxtB
            // 
            this.passwordtxtB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxtB.ForeColor = System.Drawing.Color.Silver;
            this.passwordtxtB.Location = new System.Drawing.Point(20, 520);
            this.passwordtxtB.Name = "passwordtxtB";
            this.passwordtxtB.PasswordChar = '*';
            this.passwordtxtB.Size = new System.Drawing.Size(310, 29);
            this.passwordtxtB.TabIndex = 18;
            this.passwordtxtB.TextChanged += new System.EventHandler(this.passwordtxtB_TextChanged);
            this.passwordtxtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordtxtB_KeyPress);
            // 
            // passwordnoteLbl
            // 
            this.passwordnoteLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordnoteLbl.ForeColor = System.Drawing.Color.Red;
            this.passwordnoteLbl.Location = new System.Drawing.Point(18, 552);
            this.passwordnoteLbl.Name = "passwordnoteLbl";
            this.passwordnoteLbl.Size = new System.Drawing.Size(310, 34);
            this.passwordnoteLbl.TabIndex = 19;
            // 
            // repeatpasswordLbl
            // 
            this.repeatpasswordLbl.AutoSize = true;
            this.repeatpasswordLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatpasswordLbl.Location = new System.Drawing.Point(15, 596);
            this.repeatpasswordLbl.Name = "repeatpasswordLbl";
            this.repeatpasswordLbl.Size = new System.Drawing.Size(142, 23);
            this.repeatpasswordLbl.TabIndex = 21;
            this.repeatpasswordLbl.Text = "Repeat Password";
            // 
            // repeatpasswordtxtB
            // 
            this.repeatpasswordtxtB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatpasswordtxtB.Location = new System.Drawing.Point(22, 622);
            this.repeatpasswordtxtB.Name = "repeatpasswordtxtB";
            this.repeatpasswordtxtB.PasswordChar = '*';
            this.repeatpasswordtxtB.Size = new System.Drawing.Size(306, 29);
            this.repeatpasswordtxtB.TabIndex = 22;
            this.repeatpasswordtxtB.TextChanged += new System.EventHandler(this.repeatpasswordtxtB_TextChanged);
            this.repeatpasswordtxtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repeatpasswordtxtB_KeyPress);
            // 
            // repeatpasswordnoteLbl
            // 
            this.repeatpasswordnoteLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatpasswordnoteLbl.Location = new System.Drawing.Point(19, 654);
            this.repeatpasswordnoteLbl.Name = "repeatpasswordnoteLbl";
            this.repeatpasswordnoteLbl.Size = new System.Drawing.Size(309, 28);
            this.repeatpasswordnoteLbl.TabIndex = 23;
            // 
            // signinBtn
            // 
            this.signinBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinBtn.Location = new System.Drawing.Point(305, 674);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(117, 55);
            this.signinBtn.TabIndex = 24;
            this.signinBtn.Text = "SignIn";
            this.signinBtn.UseVisualStyleBackColor = true;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(434, 741);
            this.Controls.Add(this.signinBtn);
            this.Controls.Add(this.repeatpasswordnoteLbl);
            this.Controls.Add(this.repeatpasswordtxtB);
            this.Controls.Add(this.repeatpasswordLbl);
            this.Controls.Add(this.passwordnoteLbl);
            this.Controls.Add(this.passwordtxtB);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.adressrchB);
            this.Controls.Add(this.adressLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.emailtxtB);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthdatemskB);
            this.Controls.Add(this.birthdateLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.gendergrpB);
            this.Controls.Add(this.phonemskB);
            this.Controls.Add(this.lastnametxtB);
            this.Controls.Add(this.firstnametxtB);
            this.Controls.Add(this.registrationLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gendergrpB.ResumeLayout(false);
            this.gendergrpB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrationLbl;
        private System.Windows.Forms.TextBox firstnametxtB;
        private System.Windows.Forms.TextBox lastnametxtB;
        private System.Windows.Forms.MaskedTextBox phonemskB;
        private System.Windows.Forms.RadioButton femalerdB;
        private System.Windows.Forms.RadioButton malerdB;
        private System.Windows.Forms.GroupBox gendergrpB;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label birthdateLbl;
        private System.Windows.Forms.MaskedTextBox birthdatemskB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailtxtB;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label adressLbl;
        private System.Windows.Forms.RichTextBox adressrchB;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordtxtB;
        private System.Windows.Forms.Label passwordnoteLbl;
        private System.Windows.Forms.Label repeatpasswordLbl;
        private System.Windows.Forms.TextBox repeatpasswordtxtB;
        private System.Windows.Forms.Label repeatpasswordnoteLbl;
        private System.Windows.Forms.Button signinBtn;
    }
}

