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
    // define the events that the view will raise 
        event Action<string, string> LoginRequested;
        event Action<string, string, string, string, bool> RegistrationRequested;
       
    // define the methods that the view will implement
        void ShowErrorMessage(string message);
        void CloseView();
        DialogResult DialogResult();
    }
}
