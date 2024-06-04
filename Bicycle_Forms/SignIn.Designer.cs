
namespace Bicycle_Forms
{
    partial class singIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singIn));
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdButton = new System.Windows.Forms.Button();
            this.PasswordButton = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.ForgotPassword = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Label();
            this.Password2 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameButton = new System.Windows.Forms.Button();
            this.Password2Button = new System.Windows.Forms.Button();
            this.EmailButton = new System.Windows.Forms.Button();
            this.MessageCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID.ForeColor = System.Drawing.Color.Black;
            this.ID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ID.Location = new System.Drawing.Point(326, 116);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(208, 68);
            this.ID.TabIndex = 7;
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.int_Barcode1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(103, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 8;
            // 
            // IdButton
            // 
            this.IdButton.BackColor = System.Drawing.Color.Transparent;
            this.IdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.IdButton.Location = new System.Drawing.Point(12, 116);
            this.IdButton.Name = "IdButton";
            this.IdButton.Size = new System.Drawing.Size(208, 68);
            this.IdButton.TabIndex = 9;
            this.IdButton.Text = "מספר מזהה";
            this.IdButton.UseVisualStyleBackColor = false;
            // 
            // PasswordButton
            // 
            this.PasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.PasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordButton.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PasswordButton.Location = new System.Drawing.Point(12, 211);
            this.PasswordButton.Name = "PasswordButton";
            this.PasswordButton.Size = new System.Drawing.Size(208, 68);
            this.PasswordButton.TabIndex = 10;
            this.PasswordButton.Text = "סיסמא";
            this.PasswordButton.UseVisualStyleBackColor = false;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Password.Location = new System.Drawing.Point(326, 211);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(208, 68);
            this.Password.TabIndex = 11;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.int_Barcode2_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(12, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 54);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelWholeSale_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnd.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnd.Location = new System.Drawing.Point(369, 471);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(165, 54);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "אישור";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ForgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.ForgotPassword.Location = new System.Drawing.Point(453, 282);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(81, 15);
            this.ForgotPassword.TabIndex = 14;
            this.ForgotPassword.Text = "שחכתי סיסמא";
            this.ForgotPassword.Click += new System.EventHandler(this.ForgotPassword_Click);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.BackColor = System.Drawing.Color.Transparent;
            this.SignUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.SignUp.ForeColor = System.Drawing.Color.Blue;
            this.SignUp.Location = new System.Drawing.Point(12, 282);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(42, 15);
            this.SignUp.TabIndex = 15;
            this.SignUp.Text = "הירשם";
            this.SignUp.Click += new System.EventHandler(this.label3_Click);
            // 
            // Password2
            // 
            this.Password2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password2.ForeColor = System.Drawing.Color.Black;
            this.Password2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Password2.Location = new System.Drawing.Point(326, 300);
            this.Password2.Multiline = true;
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(208, 68);
            this.Password2.TabIndex = 16;
            this.Password2.Visible = false;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Email.Location = new System.Drawing.Point(326, 388);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(208, 68);
            this.Email.TabIndex = 17;
            this.Email.Visible = false;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameBox.ForeColor = System.Drawing.Color.Black;
            this.NameBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.NameBox.Location = new System.Drawing.Point(326, 32);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(208, 68);
            this.NameBox.TabIndex = 18;
            this.NameBox.Visible = false;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noGerash);
            // 
            // NameButton
            // 
            this.NameButton.BackColor = System.Drawing.Color.Transparent;
            this.NameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameButton.Location = new System.Drawing.Point(12, 32);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(208, 68);
            this.NameButton.TabIndex = 19;
            this.NameButton.Text = "שם";
            this.NameButton.UseVisualStyleBackColor = false;
            this.NameButton.Visible = false;
            // 
            // Password2Button
            // 
            this.Password2Button.BackColor = System.Drawing.Color.Transparent;
            this.Password2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Password2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Password2Button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password2Button.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Password2Button.Location = new System.Drawing.Point(12, 300);
            this.Password2Button.Name = "Password2Button";
            this.Password2Button.Size = new System.Drawing.Size(208, 68);
            this.Password2Button.TabIndex = 20;
            this.Password2Button.Text = "חזור סיסמא";
            this.Password2Button.UseVisualStyleBackColor = false;
            this.Password2Button.Visible = false;
            // 
            // EmailButton
            // 
            this.EmailButton.BackColor = System.Drawing.Color.Transparent;
            this.EmailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmailButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmailButton.Location = new System.Drawing.Point(12, 388);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(208, 68);
            this.EmailButton.TabIndex = 21;
            this.EmailButton.Text = "אימייל";
            this.EmailButton.UseVisualStyleBackColor = false;
            this.EmailButton.Visible = false;
            // 
            // MessageCode
            // 
            this.MessageCode.AutoSize = true;
            this.MessageCode.BackColor = System.Drawing.Color.Transparent;
            this.MessageCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageCode.Location = new System.Drawing.Point(12, 4);
            this.MessageCode.Name = "MessageCode";
            this.MessageCode.Size = new System.Drawing.Size(522, 30);
            this.MessageCode.TabIndex = 22;
            this.MessageCode.Text = "we send you code in your email. please enter the code.";
            this.MessageCode.Visible = false;
            // 
            // singIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(546, 537);
            this.Controls.Add(this.MessageCode);
            this.Controls.Add(this.EmailButton);
            this.Controls.Add(this.Password2Button);
            this.Controls.Add(this.NameButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordButton);
            this.Controls.Add(this.IdButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Name = "singIn";
            this.Text = "הזדהות";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IdButton;
        private System.Windows.Forms.Button PasswordButton;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label ForgotPassword;
        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.TextBox Password2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.Button Password2Button;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Label MessageCode;
    }
}