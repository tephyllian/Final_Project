using Final_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.ViewControllers {
    public class RoomViewController : ViewController {
       
        public RoomViewController(MainForm mainForm) {
            this.mainForm = mainForm;
            mainForm.roomsTable.DataError += RoomsTable_DataError;
            mainForm.roomSaveToolStripButton.Click += RoomSaveToolStripButton_Click;
        }

        private void RoomsTable_DataError(object sender, DataGridViewDataErrorEventArgs e){
            e.ThrowException = false;
        }

        private void RoomSaveToolStripButton_Click(object sender, EventArgs e){
            try{
                mainForm.roomsTableAdapter.Update(mainForm.hotelDataSet);
                MessageBox.Show("Update Successful", "Rooms Table", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }catch(Exception saveException){
                MessageBox.Show("Unexpected error: " + saveException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void onLogin(String username) {
            mainForm.roomsTableAdapter.Fill(mainForm.hotelDataSet.Rooms);
            mainForm.panelRooms.Enabled = true;
            mainForm.roomsTable.Show();
        }

        public override void onLogout() {
            mainForm.panelRooms.Enabled = false;
            //mainForm.roomsTable.Rows.Clear();
            mainForm.roomsTable.Hide();
        }

        public override void resetView() {
            mainForm.roomsTableAdapter.Fill(mainForm.hotelDataSet.Rooms);
        }
    }
}
