using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMSWinForms.Model;
using TMSWinForms.View;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using User = TMSWinForms.Model.User;

namespace TMSWinForms
{
     internal class Program
    {
        // Declare the ticketManager variable as a static field
        internal static TicketManager ticketManager;
        internal static TicketGUI ticketForm;
        internal static UserManager userManager;

       

        static void Main()
        {
            // Initialize the ticketManager variable
            ticketManager = new TicketManager();
            userManager = new UserManager();

            User user = new User("name", "email", "password", "roll");
            userManager.AddUser(user);

            User user1 = new User( "name1", "email1", "password1", "roll1");
            userManager.AddUser(user1);

            User user2 = new User( "name2", "email2", "password2", "roll2");
            userManager.AddUser(user2);

            User user3 = new User("name3", "email3", "password3", "roll3");
            userManager.AddUser(user3);

            User user4 = new User( "name4", "email4", "password4", "roll4");
            userManager.AddUser(user4);
   

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginReigsterGUI loginForm = new LoginReigsterGUI();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Benutzer hat sich erfolgreich angemeldet, öffne das TicketGUI-Formular
                ticketForm = new TicketGUI();
                Application.Run(ticketForm);
            }
        }
    }

    
}
