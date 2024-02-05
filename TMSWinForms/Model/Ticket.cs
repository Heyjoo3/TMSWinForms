using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSWinForms.Model.Enumerations;


namespace TMSWinForms.Model
{
     internal class Ticket
    {
        // fields
        private int ticketID = Program.ticketManager.TicketID;
        private string assignedUser;

        private string ticketName;
        private string ticketDescription;
        private StatusEnum ticketStatus;
        private int ticketPriority;
        private string ticketCreateDate;

        private bool isAssigned;
       
        // properties
        public int TicketID
        {
            get { return ticketID; }
            set { ticketID = value; }
        }   
        public string AssignedUser
        {
            get { return assignedUser; }
            set { assignedUser = value; }
        }
            
        public string TicketName
        {
            get { return ticketName; }
            set { ticketName = value; }
        }

        public string TicketDescription
        {
            get { return ticketDescription; }
            set { ticketDescription = value; }
        }

           public StatusEnum TicketStatus
        {
            get { return ticketStatus; }
            set { ticketStatus = value; }
        }      

        public int TicketPriority
        {
            get { return ticketPriority; }
            set { ticketPriority = value; }
        }
         
        public string TicketCreateDate
        {
            get { return ticketCreateDate; }
            set { ticketCreateDate = value; }
        }

        public bool IsAssigned
        {
            get { return isAssigned; }
            set { isAssigned = value; }
        }


        // constructor
        public Ticket()
        {
            ticketID = 0;
            assignedUser = "";
            ticketName = "";
            ticketDescription = "";
            StatusEnum ticketStatus = StatusEnum.Unassigned;
            ticketPriority = 1;
            ticketCreateDate = "";
            isAssigned = false;
        }

        public Ticket(string assignedUser, string ticketName, string ticketDescription, StatusEnum ticketStatus, int ticketPriority, string ticketCreateDate, bool isAssigned)
        {
            this.TicketID = this.ticketID;
            this.assignedUser = assignedUser;
            this.ticketName = ticketName;
            this.ticketDescription = ticketDescription; 
            this.ticketStatus = ticketStatus;
            this.ticketPriority = ticketPriority;
            this.ticketCreateDate = ticketCreateDate;
            this.isAssigned = isAssigned;

            ticketID++;
        }

        

        // methods
        public override string ToString()
        {
            return ticketName;
        }

    }
}
