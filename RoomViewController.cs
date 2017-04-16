using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class RoomViewController: ViewController
    {
      
      // private MainForm mainForm;
      public RoomViewController(MainForm mainForm);
        this.mainForm = mainForm;
    }

    public override void onLogin(String username)
    {
        mainForm.panelRooms.Enabled = true;

    }

    public override void onLogout()
    {
        mainForm.panelRooms.Enabled = false;
    }


}

