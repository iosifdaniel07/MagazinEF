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
    public partial class User : Form {

        private UserAnonim _user;
       
        public User(UserAnonim user) {
            InitializeComponent();
            _user = user;
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

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

            Produse p = new Produse();
            p._id = int.Parse(dataGridView.Rows[e.RowIndex].Cells["_id"].Value.ToString());
            p._denumire = dataGridView.Rows[e.RowIndex].Cells["_denumire"].Value.ToString();
            p._cantitate = int.Parse(dataGridView.Rows[e.RowIndex].Cells["_cantitate"].Value.ToString());

            CumparareForm form = new CumparareForm(p,_user);
            
            if (form.ShowDialog() == DialogResult.OK) {
                Task.Run(() => LoadData());
            }
        }

        private void produseCumparateToolStripMenuItem_Click(object sender, EventArgs e) {
            ListaProduseCumparateForm form = new ListaProduseCumparateForm(_user);
            form.ShowDialog();
        }
    }
}
