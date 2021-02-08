
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
            this.btnOnlyNumbers = new System.Windows.Forms.CheckBox();
            this.btnOnlySmallLetters = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCopiedText = new System.Windows.Forms.Label();
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
            this.lblPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPasswordLength.Location = new System.Drawing.Point(80, 27);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(117, 17);
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
            this.checkSpecialChar.Text = "include special characters (like $, %...)";
            this.checkSpecialChar.UseVisualStyleBackColor = true;
            this.checkSpecialChar.CheckedChanged += new System.EventHandler(this.checkSpecialChar_CheckedChanged_1);
            // 
            // checkBigLetters
            // 
            this.checkBigLetters.AutoSize = true;
            this.checkBigLetters.Location = new System.Drawing.Point(54, 169);
            this.checkBigLetters.Name = "checkBigLetters";
            this.checkBigLetters.Size = new System.Drawing.Size(130, 17);
            this.checkBigLetters.TabIndex = 5;
            this.checkBigLetters.Text = "include Capital Letters";
            this.checkBigLetters.UseVisualStyleBackColor = true;
            this.checkBigLetters.CheckedChanged += new System.EventHandler(this.checkBigLetters_CheckedChanged_1);
            // 
            // btnGeneratePw
            // 
            this.btnGeneratePw.Location = new System.Drawing.Point(54, 287);
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
            this.lblPassword.Location = new System.Drawing.Point(51, 324);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Your Password:";
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Enabled = false;
            this.btnCopyPassword.Location = new System.Drawing.Point(54, 357);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(75, 23);
            this.btnCopyPassword.TabIndex = 8;
            this.btnCopyPassword.Text = "copy password";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // btnOnlyNumbers
            // 
            this.btnOnlyNumbers.AutoSize = true;
            this.btnOnlyNumbers.Location = new System.Drawing.Point(54, 218);
            this.btnOnlyNumbers.Name = "btnOnlyNumbers";
            this.btnOnlyNumbers.Size = new System.Drawing.Size(108, 17);
            this.btnOnlyNumbers.TabIndex = 9;
            this.btnOnlyNumbers.Text = "use only numbers";
            this.btnOnlyNumbers.UseVisualStyleBackColor = true;
            this.btnOnlyNumbers.CheckedChanged += new System.EventHandler(this.btnOnlyNumbers_CheckedChanged);
            // 
            // btnOnlySmallLetters
            // 
            this.btnOnlySmallLetters.AutoSize = true;
            this.btnOnlySmallLetters.Location = new System.Drawing.Point(54, 253);
            this.btnOnlySmallLetters.Name = "btnOnlySmallLetters";
            this.btnOnlySmallLetters.Size = new System.Drawing.Size(122, 17);
            this.btnOnlySmallLetters.TabIndex = 10;
            this.btnOnlySmallLetters.Text = "use only small letters";
            this.btnOnlySmallLetters.UseVisualStyleBackColor = true;
            this.btnOnlySmallLetters.CheckedChanged += new System.EventHandler(this.btnOnlySmallLetters_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "(note: not selecting any checkbox will \r\ninclude both numbers and small letters)";
            // 
            // lblCopiedText
            // 
            this.lblCopiedText.AutoSize = true;
            this.lblCopiedText.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblCopiedText.Location = new System.Drawing.Point(141, 362);
            this.lblCopiedText.Name = "lblCopiedText";
            this.lblCopiedText.Size = new System.Drawing.Size(0, 13);
            this.lblCopiedText.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.lblCopiedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOnlySmallLetters);
            this.Controls.Add(this.btnOnlyNumbers);
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
        private System.Windows.Forms.CheckBox btnOnlyNumbers;
        private System.Windows.Forms.CheckBox btnOnlySmallLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCopiedText;
    }
}

