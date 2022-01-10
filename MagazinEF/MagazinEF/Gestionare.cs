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
    public partial class GestionareForm : Form {
        public GestionareForm() {
            InitializeComponent();

            idProdusTool.Text = "";
            toolStripVanzare.Text = "";
            Task.Run(() => LoadData());
           
        }

        private delegate void actualizareGridDelegat(DataGridView grid, List<ProdusAnonim> list);

        private void actualizareGrid(DataGridView grid, List<ProdusAnonim> list) {


            grid.DataSource = list;


        }

        private async void LoadData() {

            await Task.Run(() => {

                using (MagazinDbContext magazinDbContext = new MagazinDbContext()) {

                    List<ProdusAnonim> produseList = new List<ProdusAnonim>();

                    IEnumerable<Produse> res = from p in magazinDbContext._produse
                                               select p;

                    foreach(Produse produs in res) { 
                        ProdusAnonim prod = new ProdusAnonim(produs._id,produs._denumire,produs._descriere,produs._cantitate);
                        produseList.Add(prod);
                    }
                   

                    if (dataGridView.InvokeRequired) {
                        object[] o = new object[2];
                        o[0] = dataGridView;
                        o[1] = produseList;
                        dataGridView.BeginInvoke(new actualizareGridDelegat(actualizareGrid), o);
                    }
                    else {
                        actualizareGrid(dataGridView, produseList);
                    }

                }

            });
        }
        private void produseeNoiToolStripMenuItem_Click(object sender, EventArgs e) {
            AddProduseNoiForm form = new AddProduseNoiForm();
            form.ShowDialog();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

            Produse p = new Produse();
            p._id = int.Parse(dataGridView.Rows[e.RowIndex].Cells["_id"].Value.ToString());
            p._denumire = dataGridView.Rows[e.RowIndex].Cells["_denumire"].Value.ToString();
            p._cantitate = int.Parse(dataGridView.Rows[e.RowIndex].Cells["_cantitate"].Value.ToString());

            VanzareForm vanzare = new VanzareForm(p);
            if (vanzare.ShowDialog() == DialogResult.OK) {
                Task.Run(() => LoadData());
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e) {
            Task.Run(() => LoadData());
        }

        private void ActualizareStrip_Click(object sender, EventArgs e) {
            if (idProdusTool.Text != "" && int.Parse(idProdusTool.Text) >= 0) {

                ProdusAnonim produs = null;

                using (MagazinDbContext magazinDbContext = new MagazinDbContext()) {

                    int id = int.Parse(idProdusTool.Text);
                    List<Produse> query = magazinDbContext._produse.Where(i => i._id == id).ToList();

                    if (query != null) {
                        foreach (Produse p in query) {
                            produs = new ProdusAnonim(p._id, p._denumire, p._descriere, p._cantitate);
                        }
                    }

                }

                if (produs != null) {
                    ActualizareForm actualizare = new ActualizareForm(produs);
                    if (actualizare.ShowDialog() == DialogResult.OK) {
                        Task.Run(() => LoadData());
                    }
                }
                else {
                    MessageBox.Show("Produsul cu indexul " + idProdusTool.Text + " nu exista!");
                }
            }
            else {
                MessageBox.Show("Nu ati introdus id-ul pt produsul pe care doriti sa-l modificati!");
            }
        }

        private void vanzareProdusToolStripMenuItem_Click(object sender, EventArgs e) {
            if(toolStripVanzare.Text != "" && int.Parse(toolStripVanzare.Text) >= 0) {

                Produse produs = null;

                using (MagazinDbContext magazinDbContext = new MagazinDbContext()) {

                    int id = int.Parse(toolStripVanzare.Text);
                    List<Produse> query = magazinDbContext._produse.Where(i => i._id == id).ToList();

                    if (query != null) {
                        foreach (Produse p in query) {
                            produs = p;
                        }
                    }

                }

                if (produs != null) {
                    VanzareForm vanzare = new VanzareForm(produs);
                    if (vanzare.ShowDialog() == DialogResult.OK) {
                        Task.Run(() => LoadData());
                    }
                }
                else {
                    MessageBox.Show("Produsul cu indexul " + idProdusTool.Text + " nu exista!");
                }
            }
            else {
                MessageBox.Show("Nu ati introdus id-ul pt produsul pe care doriti sa-l vindeti!");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            Task.Run(() => cautare(this, dataGridView));
        }

        
        private async void cautare(GestionareForm form,DataGridView grid) {

            await Task.Run(() => {

                using (MagazinDbContext mdb = new MagazinDbContext()) {

                    List<ProdusAnonim> produseList = new List<ProdusAnonim>();

                    IEnumerable<Produse> res = from p in mdb._produse
                                               where p._denumire.Contains(form.textBoxSearch.Text)
                                               select p;

                    foreach (Produse produs in res) {
                        ProdusAnonim prod = new ProdusAnonim(produs._id, produs._denumire, produs._descriere, produs._cantitate);
                        produseList.Add(prod);
                    }

                    if (dataGridView.InvokeRequired) {
                        object[] o = new object[2];
                        o[0] = dataGridView;
                        o[1] = produseList;
                        dataGridView.BeginInvoke(new actualizareGridDelegat(actualizareGrid), o);
                    }
                    else {
                        actualizareGrid(dataGridView, produseList);
                    }

                }
            });
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e) {
            IstoricVanzariForm form = new IstoricVanzariForm();
            form.ShowDialog();
        }

        private void stergeUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e) {
            DeleteUsers u = new DeleteUsers();
            u.ShowDialog();
        }
    }
}
