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
        //private int ticketPriority;
        private PriorityEnum ticketPriority;
        private string ticketDueDate;

        
       
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

        //public int TicketPriority
        //{
        //    get { return ticketPriority; }
        //    set { ticketPriority = value; }
        //}

        public PriorityEnum TicketPriority
        {
            get { return ticketPriority; }
            set { ticketPriority = value; }
        }
         
        public string TicketDueDate
        {
            get { return ticketDueDate; }
            set { ticketDueDate = value; }
        }

     


        // constructor
        public Ticket()
        {
            ticketID = 0;
            assignedUser = "";
            ticketName = "";
            ticketDescription = "";
            ticketStatus = StatusEnum.Unassigned;
            ticketPriority = PriorityEnum.Low;
            ticketDueDate = "";
        }

        public Ticket(string assignedUser, string ticketName, string ticketDescription, PriorityEnum ticketPriority, string ticketDueDate)
        {
            this.TicketID = this.ticketID;
            this.assignedUser = assignedUser;

            if (assignedUser == "")
            {
                this.TicketStatus = StatusEnum.Unassigned;
            }
            else
            {
                this.TicketStatus = StatusEnum.Assigned;
            }

            this.ticketName = ticketName;
            this.ticketDescription = ticketDescription; 
            this.ticketPriority = ticketPriority;
            this.ticketDueDate = ticketDueDate;

            ticketID++;
        }
    }
}
