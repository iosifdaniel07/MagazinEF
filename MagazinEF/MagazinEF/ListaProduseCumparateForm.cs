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
    public partial class ListaProduseCumparateForm : Form {

        private UserAnonim _user;
        private BackgroundWorker _worker;
        public ListaProduseCumparateForm(UserAnonim user) {
            InitializeComponent();
            _user = user;

            _worker = new BackgroundWorker();
            _worker.DoWork += loadData;
            _worker.RunWorkerCompleted += actualizareGrid;
            _worker.RunWorkerAsync();

        }

        private void actualizareGrid(object sender, RunWorkerCompletedEventArgs e){
            dataGridView.DataSource = e.Result as List<VanzariAnonime>;
       }

    private void loadData(object sender, DoWorkEventArgs e) {

            using (IstoricVanzariDbContext vanzariDbContext = new IstoricVanzariDbContext()) {

                List<VanzariAnonime> vanzariList = new List<VanzariAnonime>();

                IEnumerable<IstoricVanzari> res = from v in vanzariDbContext._istoricVanzari
                                                  where v._id_user == _user.Id
                                                  select v;

                foreach (IstoricVanzari vanzare in res) {
                    VanzariAnonime vanzari = new VanzariAnonime(vanzare._id_user, vanzare._denumire, vanzare._cantitate);
                    vanzariList.Add(vanzari);
                }

                e.Result = vanzariList;

            }
        }

       

    }
}
