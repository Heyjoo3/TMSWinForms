using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSLibrary;

namespace TMSWinForms.Model
{
    public class ManageStates
    {
      //fields 

    private UserModel loggedUser;

        //properties
        public UserModel LoggedUser
        {
            get { return loggedUser; }
            set { loggedUser = value; }
        }

     //constructor
        public ManageStates()
        {
            loggedUser = new UserModel();
        }

        

    }
}
