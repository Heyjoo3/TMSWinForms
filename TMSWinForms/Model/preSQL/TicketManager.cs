using System.Collections.Generic;
using System.Linq;
using TMSWinForms.Model;
using TMSWinForms.Model.Enumerations;
using System;
using System.Collections;

namespace TMSWinForms.Model
{
    internal class TicketManager
    {
        // fields
        List<Ticket> tickets = new List<Ticket>();
        List<Ticket> unassignedTickets = new List<Ticket>();
        List<Ticket> assignedTickets = new List<Ticket>();
        List<Ticket> finishedTickets = new List<Ticket>();
        private int ticketID = 0;


        // properties
        public List<Ticket> Tickets
        {
            get { return tickets; }
            set { tickets = value; }
        }

        public List<Ticket> UnassignedTickets
        {
            get { return unassignedTickets; }
            set { unassignedTickets = value; }
        }

        public List<Ticket> AssignedTickets
        {
            get { return assignedTickets; }
            set { assignedTickets = value; }
        }

        public List<Ticket> FinishedTickets
        {
            get { return finishedTickets; }
            set { finishedTickets = value; }
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
            //if (ticket.TicketStatus == StatusEnum.Unassigned)
            //{
            //    UnassignedTickets.Add(ticket);
            //}
            //else if (ticket.TicketStatus == StatusEnum.Assigned)
            //{
            //    AssignedTickets.Add(ticket);
            //}
            //else if (ticket.TicketStatus == StatusEnum.Finished)
            //{
            //    FinishedTickets.Add(ticket);
            //}


        }

        public void AddTicketToSubList()
        {
            foreach (Ticket ticket in Tickets)
            {
                if (ticket.TicketStatus == StatusEnum.Unassigned)
                {
                    UnassignedTickets.Add(ticket);
                }
                else if (ticket.TicketStatus == StatusEnum.Assigned)
                {
                    AssignedTickets.Add(ticket);
                }
                else if (ticket.TicketStatus == StatusEnum.Finished)
                {
                    FinishedTickets.Add(ticket);
                }
                else
                {
                    throw new System.Exception("Invalid status");
                }
            }   
        }

        public void SortTickets(List<Ticket> ticketList, SortEnum sortCriteria)
        {
            if (sortCriteria == SortEnum.Date)
            {
                ticketList.Sort((t1, t2) => DateTime.Compare(DateTime.Parse(t1.TicketDueDate), DateTime.Parse(t2.TicketDueDate)));
            }
            else if (sortCriteria == SortEnum.Priority)
            {
                ticketList.Sort((t1, t2) => t1.TicketPriority.CompareTo(t2.TicketPriority));
            }
            else if (sortCriteria == SortEnum.Title)
            {
                ticketList.Sort((t1, t2) => string.Compare(t1.TicketName, t2.TicketName));
            }
            else
            {
                throw new System.Exception("Invalid sort criteria");
            }
        }

        public List<Ticket> filterTickets(List<Ticket> TicketList)
        {
            List<Ticket> filteredList = new List<Ticket>();
            foreach (Ticket ticket in TicketList)
            {
                if (ticket.AssignedUser == Program.userManager.CurrentUser.UserName)
                {
                    filteredList.Add(ticket);
                }
            }
            return filteredList;
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
                    //string ticketDueDate = t.TicketDueDate;
                    //string assignedUser = t.AssignedUser;

                    return t;

                }
            }

            return null;
        }

        public void ChangeStatus(int ticketID, StatusEnum status)
        {
            foreach (Ticket t in tickets)
            {
                if (t.TicketID == ticketID)
                {
                    t.TicketStatus = status;
                }
            }
        }

        public void ChangeAssigendUser(int ticketID, string assignedUser)
        {
            foreach (Ticket t in tickets)
            {
                if (t.TicketID == ticketID)
                {
                    t.AssignedUser = assignedUser;
                }
            }
        }

        public void DeleteTicket(int ticketID)
        {
            List<Ticket> ticketsToRemove = new List<Ticket>();

            foreach (Ticket t in tickets)
            {
                if (t.TicketID == ticketID)
                {
                    ticketsToRemove.Add(t);
                }
            }

            foreach (Ticket t in ticketsToRemove)
            {
                tickets.Remove(t);
            }
        }

        public void EditTicket(int ticketID, string ticketName, string ticketDescription, string ticketStatus, string ticketPriority, string ticketDueDate, string assignedUser)
        {
            foreach (Ticket t in tickets)
            {
                if (t.TicketID == ticketID)
                {
                    if (ticketStatus == "Unassigned")
                    {
                        t.TicketStatus = StatusEnum.Unassigned;
                    }
                    else if (ticketStatus == "Assigned")
                    {
                        t.TicketStatus = StatusEnum.Assigned;
                    }
                    else if (ticketStatus == "Finished")
                    {
                        t.TicketStatus = StatusEnum.Finished;
                    }

                    if (ticketPriority == "High")
                    {
                        t.TicketPriority = PriorityEnum.High;
                    }
                    else if (ticketPriority == "Medium")
                    {
                        t.TicketPriority = PriorityEnum.Medium;
                    }
                    else if (ticketPriority == "Low")
                    {
                        t.TicketPriority = PriorityEnum.Low;
                    }

                    t.TicketName = ticketName;
                    t.TicketDescription = ticketDescription;
                    t.TicketDueDate = ticketDueDate;
                    t.AssignedUser = assignedUser;
                }
            }
        }

        //public List<Ticket> GetUnassingedTickets()
        //{
        //    List<Ticket> unassignedTickets = new List<Ticket>();
        //    foreach (Ticket t in tickets)
        //    {
        //        if (t.AssignedUser == "")
        //        {
        //            unassignedTickets.Add(t);
        //        }
        //    }
        //    return unassignedTickets;
        //}

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

        //public List<Ticket> GetAssignedTickets()
        //{
        //    List<Ticket> assignedTickets = new List<Ticket>();
        //    foreach (Ticket t in tickets)
        //    {
        //        if (t.TicketStatus == StatusEnum.Assigned)
        //        {
        //            assignedTickets.Add(t);
        //        }
        //    }
        //    return assignedTickets;
        //}

        //public List<Ticket> GetFinishedTickets()
        //{
        //    List<Ticket> finishedTickets = new List<Ticket>();
        //    foreach (Ticket t in tickets)
        //    {
        //        if (t.TicketStatus == StatusEnum.Finished)
        //        {
        //            finishedTickets.Add(t);
        //        }
        //    }
        //    return finishedTickets;
        //}

      
    }
}
