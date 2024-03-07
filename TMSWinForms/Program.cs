namespace TMSWinForms
{
    using System.Windows.Forms;
    using TMSWinForms.View;
    using TMSLibrary;
    using TMSBLL;
    using TMSBLL.Interfaces;
    using TMSBLL.Services;
    using TMSBLL.Enumerations;

    public class Program
    {
        // Declare the manager variable as a static field
        internal static ManageStates manageStates;
        internal static ManageLoginEvents manageEvents;
        internal static SqliteDataAccess sqliteDataAccess;

        // Declare the form variable as a static field
        internal static TicketGUI ticketForm;
        internal static LoginReigsterGUI loginForm;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create instances
       

            sqliteDataAccess = new SqliteDataAccess();
            manageStates = new ManageStates(sqliteDataAccess);

            loginForm = new LoginReigsterGUI(sqliteDataAccess);
            manageEvents = new ManageLoginEvents(sqliteDataAccess, loginForm, manageStates);

            // Show the login form and wait for the user to close it
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                ticketForm = new TicketGUI();
                Application.Run(ticketForm);
            }
        }
    }
}
