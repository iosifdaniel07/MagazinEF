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
    public partial class MagazinForm : Form {

        private Thread _newMainThread = null;
        private UserAnonim _thisUser = null;
        public MagazinForm() {

            InitializeComponent();

            Task.Run(() => createAdminIfDontExist());

            textBoxPassword.Text = "";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 14;

        }

        private void buttonSignUp_Click(object sender, EventArgs e) {
            SignUpForm signupForm = new SignUpForm();
            signupForm.ShowDialog();
        }

        private void buttonLoginUser_Click(object sender, EventArgs e) {
            buttonLoginUser.Enabled = false;
            Task.Run(() => conectare(buttonLoginUser, _thisUser));

        }

        public delegate void enableLoginButtonDelegate(Button button);

        public void enableLoginButton(Button button) {

            button.Enabled = true;

        }
        private async Task conectare(Button button, UserAnonim userA) {

            await Task.Run(async () => {

                using (UsersDbContext usersDbContext = new UsersDbContext()) {

                    try {

                        Utilizatori user = usersDbContext._users.Where(i => i._username == textBoxUsername.Text).First();

                        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                         password: textBoxPassword.Text,
                                         salt: Convert.FromBase64String(user._salt),
                                         prf: KeyDerivationPrf.HMACSHA256,
                                         iterationCount: 100000,
                                         numBytesRequested: 256 / 8));

                        if (hashed == user._password) {
                            userA = new UserAnonim(user._id, user._name, user._prenume, user._username);
                            await Task.Run(() => startUserForm(this, userA));

                        }
                        else {
                            MessageBox.Show("Parola gresita!");
                        }


                    }
                    catch (InvalidOperationException ee) {
                        MessageBox.Show("Userul nu exista!");
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


        public delegate void closeFormDelegate(MagazinForm form);
        public void closeForm(MagazinForm form) {
            if (form != null) {
                form.Close();
            }
        }
        private async void startUserForm(MagazinForm _form, UserAnonim user) {

            await Task.Run(async () => {

                _newMainThread = new Thread(() => {
                    Application.Run(new User(user));

                });
                _newMainThread.SetApartmentState(ApartmentState.STA);
                _newMainThread.Start();

                if (_form.InvokeRequired) {
                    object[] f = new object[1];
                    f[0] = _form;

                    _form.BeginInvoke(new closeFormDelegate(closeForm), f);
                }
                else {
                    closeForm(_form);
                }


            });
        }

        private void buttonAdmin_Click(object sender, EventArgs e) {
            AdminLoginForm admin = new AdminLoginForm(this);
            admin.ShowDialog();
        }

        private async void createAdminIfDontExist() {

            await Task.Run(async () => {

                using (AdminDbContext adminDbContext = new AdminDbContext()) {
                    
                    var query = from a in adminDbContext._admin
                                where a._username == "admin"
                                select a;

                    
                    if (query.Count() == 0) {

                        Admin a = new Admin();

                        byte[] salt = new byte[128 / 8];
                        using (var rngCsp = new RNGCryptoServiceProvider()) {
                            rngCsp.GetNonZeroBytes(salt);
                        }

                        a._salt = Convert.ToBase64String(salt);

                        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                         password: "admin",
                                         salt: salt,
                                         prf: KeyDerivationPrf.HMACSHA256,
                                         iterationCount: 100000,
                                         numBytesRequested: 256 / 8));


                       
                        a._id = 1;
                        a._password = hashed;
                        a._username = "admin";

                        try {
                            adminDbContext._admin.Add(a);
                            adminDbContext.SaveChanges();
                        }catch(InvalidOperationException e) {
                            MessageBox.Show("Adminul nu exista in baza de date si nu poate fi creat!");
                        }
                    }
                    
                }
            });
        }


    } 
}
