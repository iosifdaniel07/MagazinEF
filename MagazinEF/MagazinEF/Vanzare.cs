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
    public partial class VanzareForm : Form {

        private Produse _produs;
        
        public VanzareForm( Produse produs) {

            InitializeComponent();

            this._produs = produs;
            
            this.labelProdus.Text = _produs._denumire.ToString();
            this.lblCantitate.Text = _produs._cantitate.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private delegate void butonvanzareDelegate( Button save);

        private void butonvanzare( Button save) {
            save.Enabled = true;
        }
        private delegate void closeFormDelegate(VanzareForm vanzareForm);

        private void closeForm(VanzareForm vanzareForm) {

            vanzareForm.DialogResult = DialogResult.OK;
           vanzareForm.Close();
        }

        private async void vanzareTask( Button save, VanzareForm form) {

            await Task.Run(() => {

                using (MagazinDbContext mdb = new MagazinDbContext()) {

                    var res = mdb._produse.SingleOrDefault(p => p._id == _produs._id);

                    if (res != null) {

                        if (int.Parse(txtCantitate.Text) <= res._cantitate) {
                            res._cantitate -= int.Parse(txtCantitate.Text);
                            if (res._cantitate == 0) {
                                //sterge din baza de date
                                try {
                                    mdb.Entry(res).State = System.Data.Entity.EntityState.Deleted;
                                }
                                catch (InvalidOperationException es) {
                                    MessageBox.Show("Probleme la stergerea din baza de date!");
                                }

                            }
                        }
                        else {
                            MessageBox.Show("Nu avem suficiente produse!");
                        }

                        try {
                            mdb.SaveChanges();

                            using (IstoricVanzariDbContext vanzareDbContext = new IstoricVanzariDbContext() ) {

                                IstoricVanzari vaznare = new IstoricVanzari();
                                vaznare._id_user = 0; //0 pt admin
                                vaznare._denumire = res._denumire;
                                vaznare._cantitate = int.Parse(txtCantitate.Text);

                                vanzareDbContext._istoricVanzari.Add(vaznare);
                                try {
                                    MessageBox.Show("Vanzare realizata cu succes!");
                                    vanzareDbContext.SaveChanges();
                                }catch (InvalidOperationException ex) { MessageBox.Show("Probleme la salvarea tranzactiei"); }
                            }
                        }
                        catch (InvalidOperationException ex) { MessageBox.Show("Ceva nu a mers bine"); }
                    }
                }

                if (save.InvokeRequired) {
                    object o = new object();
                    o = save;
                    save.BeginInvoke(new butonvanzareDelegate(butonvanzare), o);
                }
                else {
                    butonvanzare(save);
                }

                if (form.InvokeRequired) {

                    object o = new object();
                    o = form;
                    form.BeginInvoke(new closeFormDelegate(closeForm),o);
                }
                else {
                    form.DialogResult = DialogResult.OK;
                   form.Close();
                }

            });

        }

    private void btnSave_Click(object sender, EventArgs e) {

           btnSave.Enabled = false;
            Task.Run(() => vanzareTask(btnSave, this));
    }

   }
}
