using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace MagazinEF {
    public partial class SignUpForm : Form {
        public SignUpForm() {

            InitializeComponent();

            textBoxPassword.Text = "";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 14;

            textBoxConfirm.Text = "";
            textBoxConfirm.PasswordChar = '*';
            textBoxConfirm.MaxLength = 14;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e) {

            buttonSignUp.Enabled = false;
            Task.Run(() => createUser(this,buttonSignUp));

        }

        public delegate void enableLoginButtonDelegate(Button button);

        public void enableLoginButton(Button button) {

            button.Enabled = true;

        }

        public delegate void CloseFormDelegate(SignUpForm form);

        public void CloseForm(SignUpForm form) {
            if (form != null) {
                form.Close();
            }
        }

        private async Task createUser(SignUpForm form, Button button) {

            await Task.Run(async () => {

                using (UsersDbContext usersDb = new UsersDbContext()) {

                    Utilizatori user = new Utilizatori();
                    user._username = textBoxUsername.Text;
                    user._prenume = textBoxPrenume.Text;
                    user._name = textBoxNume.Text;
                    user._password = textBoxPassword.Text;

                    int query = (from u in usersDb._users
                                 where u._username == textBoxUsername.Text
                                 select u).Count();
                    if (query == 0) {

                        if (user._password == textBoxConfirm.Text) {

                            /////////////////////////////////////////////////////
                            //https://docs.microsoft.com/en-us/aspnet/core/security/data-protection/consumer-apis/password-hashing?view=aspnetcore-6.0
                            //Install-Package Microsoft.AspNetCore.Cryptography.KeyDerivation -Version 6.0.1

                            //codul este inspirat de la linkul de mai sus
                            byte[] salt = new byte[128 / 8];
                            using (var rngCsp = new RNGCryptoServiceProvider()) {
                                rngCsp.GetNonZeroBytes(salt);
                            }
                            
                            user._salt = Convert.ToBase64String(salt);

                            string hashed = Convert.ToBase64String( KeyDerivation.Pbkdf2(
                                             password: user._password,
                                             salt: salt,
                                             prf: KeyDerivationPrf.HMACSHA256,
                                             iterationCount: 100000,
                                             numBytesRequested: 256 / 8));
                            //////////////////////////////////////////////////
                            
                            user._password = hashed;

                            try {
                              
                                usersDb._users.Add(user);
                                usersDb.SaveChanges();
                                MessageBox.Show("Cont creat cu succes");


                                if (form.InvokeRequired) {

                                    object[] f = new object[1];
                                    f[0] = form;
                                    form.BeginInvoke(new CloseFormDelegate(CloseForm), f);
                                }
                                else {
                                    CloseForm(form);
                                }

                            }
                            catch(System.Data.Entity.Validation.DbEntityValidationException e) {
                                MessageBox.Show("Nu ati completat toate campurile");
                            }

                               
                        }
                        else {
                            MessageBox.Show("Parolele nu coincid!");
                        }
                    }
                    else {
                        MessageBox.Show("Userul exista deja!");
                    }

                    if (button.InvokeRequired) {
                        object[] b = new object[1];
                        b[0] = button;
                        button.BeginInvoke(new enableLoginButtonDelegate(enableLoginButton), b);
                    }
                    else {
                        enableLoginButton(button);
                    }

                }
            });
        }

    
    }
}
