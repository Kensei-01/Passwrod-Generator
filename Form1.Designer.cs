
namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDecrement = new System.Windows.Forms.Button();
            this.lblPasswordLengthReal = new System.Windows.Forms.Label();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.checkSpecialChar = new System.Windows.Forms.CheckBox();
            this.checkBigLetters = new System.Windows.Forms.CheckBox();
            this.btnGeneratePw = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDecrement
            // 
            this.btnDecrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDecrement.Location = new System.Drawing.Point(54, 70);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(30, 28);
            this.btnDecrement.TabIndex = 0;
            this.btnDecrement.Text = "-";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // lblPasswordLengthReal
            // 
            this.lblPasswordLengthReal.AutoSize = true;
            this.lblPasswordLengthReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPasswordLengthReal.Location = new System.Drawing.Point(121, 78);
            this.lblPasswordLengthReal.Name = "lblPasswordLengthReal";
            this.lblPasswordLengthReal.Size = new System.Drawing.Size(18, 20);
            this.lblPasswordLengthReal.TabIndex = 1;
            this.lblPasswordLengthReal.Text = "3";
            // 
            // btnIncrement
            // 
            this.btnIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIncrement.Location = new System.Drawing.Point(178, 70);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(31, 28);
            this.btnIncrement.TabIndex = 2;
            this.btnIncrement.Text = "+";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click_1);
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.Location = new System.Drawing.Point(88, 37);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(89, 13);
            this.lblPasswordLength.TabIndex = 3;
            this.lblPasswordLength.Text = "Password Length";
            // 
            // checkSpecialChar
            // 
            this.checkSpecialChar.AutoSize = true;
            this.checkSpecialChar.Location = new System.Drawing.Point(54, 136);
            this.checkSpecialChar.Name = "checkSpecialChar";
            this.checkSpecialChar.Size = new System.Drawing.Size(206, 17);
            this.checkSpecialChar.TabIndex = 4;
            this.checkSpecialChar.Text = "include spacial characters (like $, %...)";
            this.checkSpecialChar.UseVisualStyleBackColor = true;
            this.checkSpecialChar.CheckedChanged += new System.EventHandler(this.checkSpecialChar_CheckedChanged_1);
            // 
            // checkBigLetters
            // 
            this.checkBigLetters.AutoSize = true;
            this.checkBigLetters.Location = new System.Drawing.Point(54, 174);
            this.checkBigLetters.Name = "checkBigLetters";
            this.checkBigLetters.Size = new System.Drawing.Size(130, 17);
            this.checkBigLetters.TabIndex = 5;
            this.checkBigLetters.Text = "include Capital Letters";
            this.checkBigLetters.UseVisualStyleBackColor = true;
            this.checkBigLetters.CheckedChanged += new System.EventHandler(this.checkBigLetters_CheckedChanged_1);
            // 
            // btnGeneratePw
            // 
            this.btnGeneratePw.Location = new System.Drawing.Point(65, 230);
            this.btnGeneratePw.Name = "btnGeneratePw";
            this.btnGeneratePw.Size = new System.Drawing.Size(132, 23);
            this.btnGeneratePw.TabIndex = 6;
            this.btnGeneratePw.Text = "Generate Password";
            this.btnGeneratePw.UseVisualStyleBackColor = true;
            this.btnGeneratePw.Click += new System.EventHandler(this.btnGeneratePw_Click_1);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(62, 310);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Your Password:";
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Enabled = false;
            this.btnCopyPassword.Location = new System.Drawing.Point(64, 335);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(75, 23);
            this.btnCopyPassword.TabIndex = 8;
            this.btnCopyPassword.Text = "copy password";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.btnCopyPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnGeneratePw);
            this.Controls.Add(this.checkBigLetters);
            this.Controls.Add(this.checkSpecialChar);
            this.Controls.Add(this.lblPasswordLength);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.lblPasswordLengthReal);
            this.Controls.Add(this.btnDecrement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Label lblPasswordLengthReal;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.CheckBox checkSpecialChar;
        private System.Windows.Forms.CheckBox checkBigLetters;
        private System.Windows.Forms.Button btnGeneratePw;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCopyPassword;
    }
}

