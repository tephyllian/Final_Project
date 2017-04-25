using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public class RoomViewController : ViewController
    {

        // private MainForm mainForm;
        public RoomViewController(MainForm mainForm);
        this.mainForm = mainForm;
        mainForm.roomTable.DataError += RoomsTable_DataError;
        mainForm.roomSaveToolStripButton.Click += RoomSaveToolStripButton_Click;
    }

    private void RoomsTable_DataError(object sender, DataGridViewDataErrorEventArgs e)

    {
        e.ThrowException = false;

    }

    private void RoomSaveTooStripButton_Click(object sender, EventArgs e)
    {
        try
        {
            mainForm.roomsTableAdapter.Update(mainForm.RoomDataSet);
            MessageBox.Show("Update Successful", "Rooms Table", MessageBoxButton.OK, MessageBoxIcon.Asterisk);
        }
        catch (Exception saveException)
        {

            MessageBox.Show("Unexpected error:" + saveException.Message, "Error", MessageBoxButton.OK, MessageBoxIcon.Error);
        }
    }


    public override void onLogin(String username)
    {
        mainForm.roomsTableAdapter.Update(mainForm.RoomDataSet);
        mainForm.panelRooms.Enabled = true;
        mainForm.roomsTable.Show();

    }

    public override void onLogout()
    {
        mainForm.panelRooms.Enabled = false;
        mainForm.roomsTable.Hide();
    }

    public override void resetView()
    {
        mainForm.roomsTableAdapter.Fill(mainForm.RoomDataSet.Rooms);
    }

}

