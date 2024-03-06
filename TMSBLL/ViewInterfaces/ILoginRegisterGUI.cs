using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSBLL.Interfaces
{
    public interface ILoginRegisterGUI
    {
        // This is an interface for the LoginRegisterGUI class
        // This interface is used to define the methods that the LoginRegisterGUI class must implement
        // The LoginRegisterGUI class is used to handle the login and registration of users
        event Action<string, string> LoginRequested;
        event Action<string, string, string, string, bool> RegistrationRequested;
       

        void ShowErrorMessage(string message);
        void CloseView();

        DialogResult DialogResult();
    }
}
