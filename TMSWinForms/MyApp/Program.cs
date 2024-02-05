using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMSWinForms.Model;
using TMSWinForms.View;

namespace TMSWinForms
{
     internal class Program
    {
        // Declare the ticketManager variable as a static field
        internal static TicketManager ticketManager;

       

        static void Main()
        {
            // Initialize the ticketManager variable
            ticketManager = new TicketManager();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginReigsterGUI loginForm = new LoginReigsterGUI();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Benutzer hat sich erfolgreich angemeldet, öffne das TicketGUI-Formular
                TicketGUI ticketForm = new TicketGUI();
                Application.Run(ticketForm);
            }
        }
    }

    
}
