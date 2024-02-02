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
        static void Main()
        {   
            TicketManager ticketManager = new TicketManager();

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
