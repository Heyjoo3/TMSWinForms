using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMSBLL.Enumerations;
using TMSBLL.Interfaces;
using TMSLibrary;

namespace TMSBLL.Services
{
    //Not used
    public class TicketGUIServices : ITicketGUI
    {
        //interfaces
        private IDataAccess dataAccess;
        private ITicketGUI ticketGUI;
        private IStateManagementService manageStates;
        private ITicketTile ticketTile;

        //constructor
        public TicketGUIServices(IDataAccess dataAccess, ITicketGUI ticketGUI, IStateManagementService manageStates, ITicketTile ticketTile)
        {
            this.dataAccess = dataAccess;
            this.ticketGUI = ticketGUI;
            this.manageStates = manageStates;
            this.ticketTile = ticketTile;
        }

        //fields
        public bool showOnlyMyTickets { get; set; }
        public string sortBy { get; set;  }


        //methods

        public async Task InitializeTaskTiles(FlowLayoutPanel unassignedPanel, FlowLayoutPanel assignedPanel, FlowLayoutPanel finishedPanel, string sortBy)
        {
            this.sortBy = sortBy;

            await UpdateBySort(sortBy);

            foreach (TicketModel ticket in manageStates.AllTickets)
            {
                //TicketTile ticketTile = new TicketTile(ticket.Title, ticket.AssignedUserName, ticket.DueDate, ticket.Priority, ticket.Id, ticket.Status.ToString(), dataAccess);
                ITicketTile tile = ticketTile.CreateTicketTile(ticket);

                if (ticket.Status == StatusEnum.Unassigned.ToString())
                {
                    unassignedPanel.Controls.Add((Control)tile);
                }
                else if (showOnlyMyTickets && ticket.AssignedUserId != manageStates.LoggedUser.Id)
                {
                    continue; // Skips
                }
                else if (ticket.Status == StatusEnum.Assigned.ToString())
                {
                    assignedPanel.Controls.Add((Control)tile);
                }
                else if (ticket.Status == StatusEnum.Finished.ToString())
                {
                    finishedPanel.Controls.Add((Control)tile);
                }
                else
                {
                    throw new Exception("Invalid status");
                }
            }
        }
    

        public void RefeshPanels()
        {
            throw new NotImplementedException();
        }

        public void RefreshuserList()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateBySort(string SortBy)
        {
            this.sortBy = SortBy;

            if (sortBy == SortEnum.Date.ToString())
            {
                await manageStates.SortByDate();
            }
            else if (sortBy == SortEnum.Priority.ToString())
            {
                await manageStates.SortByPriority();
            }
            else if (sortBy == SortEnum.Name.ToString())
            {
                await manageStates.SortByName();
            }
            else if (sortBy == SortEnum.Title.ToString())
            {
                await manageStates.SortByTitle();
            }
            else
            {
                await manageStates.UpdateAllTickets();
            }
        }

     
    }
}
