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

        internal static TicketGUI ticketForm;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the LoginReigsterGUI form
            //LoginReigsterGUI loginForm = new LoginReigsterGUI();

            sqliteDataAccess = new SqliteDataAccess();
            manageStates = new ManageStates(sqliteDataAccess);

            


            LoginReigsterGUI loginForm = new LoginReigsterGUI(sqliteDataAccess);
            manageEvents = new ManageLoginEvents(sqliteDataAccess, loginForm, manageStates);

            // Show the login form and wait for the user to close it
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Create an instance of the TicketGUI form
                ticketForm = new TicketGUI();

                // Run the ticket form
                Application.Run(ticketForm);
            }
        }
    }
}
