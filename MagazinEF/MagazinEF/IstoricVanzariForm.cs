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
    public partial class IstoricVanzariForm : Form {
        public IstoricVanzariForm() {
            InitializeComponent();
            Task.Run(() => LoadSaleData(dataGridVanzari));
        }

        public delegate void actualizareGridSaleDelegat(DataGridView grid, List<VanzariAnonime> list);

        public void actualizareGridSale(DataGridView grid, List<VanzariAnonime> list) {

            grid.DataSource = list;

        }

        private async void LoadSaleData(DataGridView grid) {

            await Task.Run(() => {

                using (IstoricVanzariDbContext vanzariDbContext = new IstoricVanzariDbContext()) {

                    List<VanzariAnonime> vanzariList = new List<VanzariAnonime>();

                    IEnumerable<IstoricVanzari> res = from v in vanzariDbContext._istoricVanzari
                                                      select v;

                    foreach (IstoricVanzari vanzare in res) {
                        VanzariAnonime vanzari = new VanzariAnonime(vanzare._id_user, vanzare._denumire, vanzare._cantitate);
                        vanzariList.Add(vanzari);
                    }


                    if (grid.InvokeRequired) {
                        object[] o = new object[2];
                        o[0] = grid;
                        o[1] = vanzariList;
                        grid.BeginInvoke(new actualizareGridSaleDelegat(actualizareGridSale), o);
                    }
                    else {
                        actualizareGridSale(grid, vanzariList);
                    }

                }

            });
        }

       
    }

}
