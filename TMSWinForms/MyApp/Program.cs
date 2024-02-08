namespace TMSWinForms
{
    using System.Windows.Forms;
    using TMSWinForms.Model;
    using TMSWinForms.View;
    internal class Program
    {
        // Declare the ticketManager variable as a static field
        internal static TicketManager ticketManager;
        internal static TicketGUI ticketForm;
        internal static UserManager userManager;
        internal static ManageStates manageStates;

        static void Main()
        {
            // Initialize the ticketManager variable
            ticketManager = new TicketManager();
            userManager = new UserManager();
            manageStates = new ManageStates();

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
