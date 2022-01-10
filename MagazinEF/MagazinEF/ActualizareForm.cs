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
    public partial class ActualizareForm : Form {

        private ProdusAnonim _produs;
        
        public ActualizareForm(ProdusAnonim produs) {

            InitializeComponent();

            _produs = produs;
            labelProdus.Text = _produs._denumire;
            
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private delegate void closeFormDelegate(ActualizareForm form);
        private void closeForm(ActualizareForm form) {
            form.DialogResult = DialogResult.OK;
            form.Close();
        }

        private async void actualizare(ActualizareForm form) {

            await Task.Run(() => {
                using (MagazinDbContext mdb = new MagazinDbContext()) {

                    var res = mdb._produse.SingleOrDefault(p => p._id == _produs._id);

                    if (res != null) {

                        res._cantitate += int.Parse(txtCantitate.Text);

                        try {
                            mdb.Entry(res).State = System.Data.Entity.EntityState.Modified;
                            mdb.SaveChanges();
                            MessageBox.Show("Actualizare finalizata!");
                            if (this.InvokeRequired) {
                                object o = new object();
                                o = this;
                                this.BeginInvoke(new closeFormDelegate(closeForm),o);
                            }
                            else {
                                closeForm(this);
                            }
                        }
                        catch (InvalidOperationException es) {
                            MessageBox.Show("Probleme!");
                        }


                    }
                }
            });
        }
        private void btnSave_Click(object sender, EventArgs e) {

            Task.Run(() => actualizare(this));
        }
    }
}
