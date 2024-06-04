using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bicycle_DBMS;

namespace Bicycle_Forms
{
    public partial class singIn : Form
    {
        private ToOpen WhatToOpen;
        private Item item;
        private string State;
        private int code;
        private User user;
        public singIn(ToOpen toOpen, Item item = null)
        {
            InitializeComponent();
            if (!AccountWin.isHebrow)
            {
                this.Text = "Sign In";
                this.IdButton.Text = "ID";
                this.PasswordButton.Text = "Password";
                this.btnCancel.Text = "Cancel";
                this.btnEnd.Text = "OK";
            }
            WhatToOpen = toOpen;
            this.item = item;
            State = "SignIn";
        }

        private void int_Barcode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void int_Barcode1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Password.Focus();
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
        }
        private void int_Barcode2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEnd.Focus();
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
        }

        private void double_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') || (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void noGerash(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == '\'')|| (e.KeyChar == '"');
        }
        public bool IsPasscodeCorecct(string id, string passcode)
        {
            if (id == null)
                return false;
            User user = User.Select(id);
            if (user == null)
                return false;
            if (passcode == user.Password)
                return true;
            return false;
        }
        public void Open()
        {
            
            if (WhatToOpen == ToOpen.dailyReport)
            {
                this.Hide();
                var form = new DataGridDailyReport();
                form.Closed += (s, args) => this.Close();
                form.Show();

            }
            else if(WhatToOpen == ToOpen.saleDays)
            {
                this.Hide();
                var form = new DataGridSaleDays(item);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else if (WhatToOpen == ToOpen.items)
            {
                this.Hide();
                var form = new DataGridItem();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == "SignIn")
                {
                    if (this.ID.Text == "" || this.Password.Text == "")
                    {
                        if (AccountWin.isHebrow)
                            MessageBox.Show("שם משתמש או סיסמא חייב להכיל ערך");
                        else
                            MessageBox.Show("Id or passcode must contain values");
                    }
                    else if (IsPasscodeCorecct(this.ID.Text, this.Password.Text))
                    {
                        AccountWin.setSingIn(true);
                        Open();
                    }
                    else
                    {
                        if (AccountWin.isHebrow)
                            MessageBox.Show("המספר מזהה או הסיסמא שגויים");
                        else
                            MessageBox.Show("Id or passcode are incorrect");
                    }
                }
                else if (State == "SignUp")
                {
                    if (User.Select(this.ID.Text) != null)
                    {
                        if (AccountWin.isHebrow)
                            MessageBox.Show("מספר מזהה קיים, נא אפס סיסמא");
                        else
                            MessageBox.Show("ID is alreday existed");
                    }
                    else if (Password2.Text != Password.Text)
                    {
                        if (AccountWin.isHebrow)
                            MessageBox.Show("הסיסמאות אינן תואמות");
                        else
                            MessageBox.Show("passwords are not the same");
                    }
                    else
                    {
                        User user = GetData();
                        user.Insert();
                        Open();
                    }
                }
                else if (State == "ForgotPassword")
                {
                    try
                    {
                        user = User.Select(this.ID.Text);
                        if (user != null)
                        {
                            State = "EnterCode";
                            Random random = new Random();
                            code = random.Next(1000, 10000);
                            string destination = user.Email;
                            string subject = "Change your password";
                            string body = "hey " + user.Name + ",\n your activation code is: " + code + " \n for help please contact natananter@gmail.com";
                            Email email = new Email(destination, subject, body);
                            email.send();
                            string t = "enter code";
                            if (AccountWin.isHebrow)
                            {
                                t = "הכנס קוד";
                                this.MessageCode.Text = "שלחנו לך קוד במייל. הכנס קוד";
                            }
                            this.PasswordButton.Visible = true;
                            this.PasswordButton.Text = t;
                            this.Password.Visible = true;
                            this.MessageCode.Visible = true;
                        }
                        else
                        {
                            if (AccountWin.isHebrow)
                                MessageBox.Show("יש להזין מספר חשבון קיים במערכת");
                            else
                                MessageBox.Show("there is no Id like this in the system");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erorr: \n" + ex);
                    }
                }
                else if (State == "changePassword")
                {
                    this.ID.Text = user.Id;
                    this.ID.ReadOnly = true;
                    if (Password2.Text != Password.Text)
                    {
                        if (AccountWin.isHebrow)
                            MessageBox.Show("הסיסמאות אינן תואמות");
                        else
                            MessageBox.Show("passwords are not the same");
                    }
                    else
                    {
                        User user = GetData();
                        if(user.Update())
                            MessageBox.Show("בוצע");
                        AccountWin.setSingIn(true);
                        Open();
                    }

                }
                else
                {
                    if (this.Password.Text == code.ToString())
                    {
                        DialogResult dialogResult = MessageBox.Show(user.Password + "הקוד שלך הוא:", "האם תרצה לשנות את הקוד?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ChangePassword();
                        }
                    }
                    else
                    {
                        if (AccountWin.isHebrow)
                            MessageBox.Show("קוד שגוי");
                        else
                            MessageBox.Show("worng code");
                    }
                }
            }
            catch(Exception ex)
            {
                if (WhatToOpen == ToOpen.dailyReport)
                    MessageBox.Show("no items soled");
                else
                    MessageBox.Show("Erorr\n"+ex);
            }
            
        }
        private void ChangePassword()
        {
            this.SignUp.Visible = false;
            this.ForgotPassword.Visible = false;
            this.NameButton.Visible = true;
            this.NameBox.Visible = true;
            this.Password2Button.Visible = true;
            this.Password2.Visible = true;
            this.EmailButton.Visible = true;
            this.Email.Visible = true;
            this.ID.ReadOnly = true;
            this.NameBox.Text = user.Name;
            this.ID.Text = user.Id;
            this.Password.Text = user.Password;
            this.Password2.Text = user.Password;
            this.Email.Text = user.Email;
            State = "changePassword";
        }

        private void btnCancelWholeSale_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public enum ToOpen
        {
            saleDays,
            dailyReport,
            items,
            nothing
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (AccountWin.isSingIn)
            {
                this.SignUp.Visible = false;
                this.ForgotPassword.Visible = false;
                this.NameButton.Visible = true;
                this.NameBox.Visible = true;
                this.Password2Button.Visible = true;
                this.Password2.Visible = true;
                this.EmailButton.Visible = true;
                this.Email.Visible = true;
                State = "SignUp";
            }
            else
            {
                if (AccountWin.isHebrow)
                    MessageBox.Show("עליך להיות מחובר בשביל ליצור חשבון חדש");
                else
                    MessageBox.Show("you need to be sing in to create new account");
            }
        }
        private User GetData()
        {
            return new User(this.ID.Text, this.NameBox.Text, this.Password2.Text, this.Email.Text);
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            this.SignUp.Visible = false;
            this.ForgotPassword.Visible = false;
            this.PasswordButton.Visible = false;
            this.Password.Visible = false;
            State = "ForgotPassword";
        }
    }
}
