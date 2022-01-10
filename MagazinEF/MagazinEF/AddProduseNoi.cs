using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinEF {
    public partial class AddProduseNoiForm : Form {
        public AddProduseNoiForm() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdaugare_Click(object sender, EventArgs e) {
            btnAdaugare.Enabled = false;
            Task.Run(() => adaugare(this,btnAdaugare));
        }

        public delegate void enableButtonDelegate(Button button);

        public void enableButton(Button button) {
            if (button != null) {
                button.Enabled = true;
            }
        }

        public delegate void CloseFormDelegate(AddProduseNoiForm form);

        public void CloseForm(AddProduseNoiForm form) {
            if (form != null) {
                form.Close();
            }
        }
        public async Task adaugare(AddProduseNoiForm form, Button button) {

            await Task.Run(() => {

                using(MagazinDbContext magazinDbContext = new MagazinDbContext()) {

                    Produse p = new Produse();
                    p._denumire = this.txtDenumire.Text;
                    p._descriere = this.txtDescriere.Text;
                    p._dataIntrare = DateTime.Now;
                    p._dataExpirare = this.txtexpirare.Value;
                    p._cantitate = int.Parse(this.txtCantitate.Text);

                    try {
                        magazinDbContext._produse.Add(p);
                        magazinDbContext.SaveChanges();

                        MessageBox.Show("Produs adaugat cu succes");

                        if (form.InvokeRequired) {

                            object[] f = new object[1];
                            f[0] = form;
                            form.BeginInvoke(new CloseFormDelegate(CloseForm), f);
                        }
                        else {
                            CloseForm(form);
                        }
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex) {
                        MessageBox.Show("Nu ati completat toate campurile");
                    }
                   
                }

                if (button.InvokeRequired) {
                    object[] b = new object[1];
                    b[0] = button;
                    button.BeginInvoke(new enableButtonDelegate(enableButton), b);
                }
                else {
                    enableButton(button);
                }

            });
        }

    }
}
