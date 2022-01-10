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
using System.Threading;

namespace MagazinEF {
    public partial class AdminLoginForm : Form {

        private MagazinForm _form = null;
        private Thread _newMainThread = null;
        public AdminLoginForm(MagazinForm form) {
            InitializeComponent();
            _form = form;
            textBoxPassword.Text = "";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 14;
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
           
            buttonLogin.Enabled = false;
            Task.Run(() => conectare(buttonLogin));
        }

        public delegate void closeFormDelegate(MagazinForm form);

        public void closeForm(MagazinForm form) {
            if (form != null) {
                form.Close();
            }
        }

        public delegate void enableLoginButtonDelegate(Button button);

        public void enableLoginButton(Button button) {

            button.Enabled = true;

        }
        private async Task conectare(Button button) {

            await Task.Run(async () => {

            using (AdminDbContext adminDbContext = new AdminDbContext()) {

                    var query = from a in adminDbContext._admin
                                where a._username == textBoxName.Text
                                select new {
                                    _username = a._username,
                                    _password = a._password,
                                    _salt = a._salt
                                };

                    if( query.Count() == 1) {

                        string _username="", _password="", _salt="";
                        foreach (var item in query) {
                            _username = item._username;
                            _password = item._password;
                            _salt = item._salt;
                        }

                        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                            password: textBoxPassword.Text,
                                            salt: Convert.FromBase64String(_salt),
                                            prf: KeyDerivationPrf.HMACSHA256,
                                            iterationCount: 100000,
                                            numBytesRequested: 256 / 8));

                        if (hashed == _password) {


                            _newMainThread = new Thread(() => {
                                    Application.Run(new GestionareForm());
                                
                            });
                                _newMainThread.SetApartmentState(ApartmentState.STA);
                                _newMainThread.Start();
                            //InvalidOperationException 



                            if (_form.InvokeRequired) {
                                object[] f = new object[1];
                                f[0] = _form;

                                _form.BeginInvoke(new closeFormDelegate(closeForm), f);
                            }
                            else {
                                closeForm(_form);
                            }

                            this.Close();
                        }
                        else {

                            if (button.InvokeRequired) {
                                object[] b = new object[1];
                                b[0] = button;
                                button.BeginInvoke(new enableLoginButtonDelegate(enableLoginButton), b);
                            }
                            else {
                                enableLoginButton(button);
                            }

                            MessageBox.Show("Parola gresita!");
                        }
                    }
                    else {
                        if (button.InvokeRequired) {
                            object[] b = new object[1];
                            b[0] = button;
                            button.BeginInvoke(new enableLoginButtonDelegate(enableLoginButton), b);
                        }
                        else {
                            enableLoginButton(button);
                        }

                        MessageBox.Show("Adminul nu exista!");
                    }
                    
                }
                


            });

        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
