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
    public partial class DeleteUsers : Form {
        public DeleteUsers() {
            InitializeComponent();

           Task.Run(() => LoadUsersData(dataGridView));
        }

        public delegate void actualizareGridUserseDelegat(DataGridView grid, List<UserAnonim> list);

        public void actualizareGridUsers(DataGridView grid, List<UserAnonim> list) {

            grid.DataSource = list;

        }

        private async void LoadUsersData(DataGridView grid) {

            await Task.Run(() => {

                using (UsersDbContext userDbContext = new UsersDbContext()) {

                    List<UserAnonim> userList = new List<UserAnonim>();

                    IEnumerable<Utilizatori> res = from u in userDbContext._users
                                                   select u;

                    foreach (Utilizatori utilizator in res) {
                        UserAnonim user = new UserAnonim(utilizator._id, utilizator._name, utilizator._prenume, utilizator._username);
                        userList.Add(user);
                    }


                    if (grid.InvokeRequired) {
                        object[] o = new object[2];
                        o[0] = grid;
                        o[1] = userList;
                        grid.BeginInvoke(new actualizareGridUserseDelegat(actualizareGridUsers), o);
                    }
                    else {
                        actualizareGridUsers(grid, userList);
                    }

                }

            });
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

            string message = "Vrei sa stergi userul?";
            string caption = "Stergere user";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes) {

                using (UsersDbContext userDbContext = new UsersDbContext()) {

                    int id = int.Parse(dataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var res = userDbContext._users.SingleOrDefault(u => u._id == id);

                    try {
                        userDbContext.Entry(res).State = System.Data.Entity.EntityState.Deleted;
                        userDbContext.SaveChanges();
                        MessageBox.Show("User sters cu succes!");
                    }
                    catch (InvalidOperationException es) {
                        MessageBox.Show("Probleme la stergerea din baza de date!");
                    }

                }
                Task.Run(() => LoadUsersData(dataGridView));
            }
        }
    }
}
