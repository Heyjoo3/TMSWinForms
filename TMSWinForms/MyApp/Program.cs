﻿namespace TMSWinForms
{
    using System.Windows.Forms;
    using TMSWinForms.Model;
    using TMSWinForms.View;
    public class Program
    {
        // Declare the manager variable as a static field
        internal static ManageStates manageStates;

        internal static TicketGUI ticketForm;

        static void Main()
        {
            // Create an instance of the ManageStates class
            manageStates = new ManageStates();


    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the LoginReigsterGUI form
            LoginReigsterGUI loginForm = new LoginReigsterGUI();

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
