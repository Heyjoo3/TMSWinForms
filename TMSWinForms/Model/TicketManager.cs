﻿using System.Collections.Generic;
using System.Linq;
using TMSWinForms.Model;
using TMSWinForms.Model.Enumerations;

namespace TMSWinForms.Model
{
    internal class TicketManager
    {
        // fields
        List<Ticket> tickets = new List<Ticket>();
        private int ticketID = 0;


        // properties
        public List<Ticket> Tickets
        {
            get { return tickets; }
            set { tickets = value; }
        }

        public int TicketID
        {
            get { return ticketID; }
            set { ticketID = value; }
        }
      
        // constructor
        public TicketManager()
        {
            tickets = new List<Ticket>();
        }

        // methods
        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
            TicketID++;

        }

        public Ticket GetTicketByID(int ticketID)
        {
            foreach (Ticket t in tickets)
            {
                if (t.TicketID == ticketID)
                {
                    //string ticketName = t.TicketName;
                    //string ticketDescription = t.TicketDescription;
                    //string ticketStatus = t.TicketStatus;
                    //int ticketPriority = t.TicketPriority;
                    //string ticketCreateDate = t.TicketCreateDate;
                    //string assignedUser = t.AssignedUser;

                    return t;

                }
            }

            return null;
        }

        public void RemoveTicket(Ticket ticket)
        {
            tickets.Remove(ticket);
        }

        public void EditTicket(Ticket ticket)
        {
            foreach (Ticket t in tickets)
            {
                if (t.TicketID == ticket.TicketID)
                {
                    t.TicketName = ticket.TicketName;
                    t.TicketDescription = ticket.TicketDescription;
                    t.TicketStatus = ticket.TicketStatus;
                    t.TicketPriority = ticket.TicketPriority;
                    t.TicketCreateDate = ticket.TicketCreateDate;
                    t.AssignedUser = ticket.AssignedUser;
                }
            }
        }

        public List<Ticket> GetUnassingedTickets()
        {
            List<Ticket> unassignedTickets = new List<Ticket>();
            foreach (Ticket t in tickets)
            {
                if (t.AssignedUser == "")
                {
                    unassignedTickets.Add(t);
                }
            }
            return unassignedTickets;
        }

        public List<Ticket> GetPersonalTickets(string user)
        {
            List<Ticket> personalTickets = new List<Ticket>();
            foreach (Ticket t in tickets)
            {
                if (t.TicketStatus == StatusEnum.Unassigned)
                {
                    personalTickets.Add(t);
                }
            }
            return personalTickets;
        }

        public List<Ticket> GetAssignedTickets()
        {
            List<Ticket> assignedTickets = new List<Ticket>();
            foreach (Ticket t in tickets)
            {
                if (t.TicketStatus == StatusEnum.Assigned)
                {
                    assignedTickets.Add(t);
                }
            }
            return assignedTickets;
        }

        public List<Ticket> GetFinishedTickets()
        {
            List<Ticket> finishedTickets = new List<Ticket>();
            foreach (Ticket t in tickets)
            {
                if (t.TicketStatus == StatusEnum.Finished)
                {
                    finishedTickets.Add(t);
                }
            }
            return finishedTickets;
        }

        public List<Ticket> SortByDate()
        {
            List<Ticket> sortedTickets = tickets.OrderBy(t => t.TicketCreateDate).ToList();
            return sortedTickets;
        }

        public List<Ticket> SortByPriority()
        {
            List<Ticket> sortedTickets = tickets.OrderBy(t => t.TicketPriority).ToList();
            return sortedTickets;
        }

        public List<Ticket> SortbyTitle()
        {
            List<Ticket> sortedTickets = tickets.OrderBy(t => t.TicketName).ToList();
            return sortedTickets;
        }
    }
}
