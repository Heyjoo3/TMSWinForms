using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSBLL.Interfaces
{
    public interface ITicketGUI
    {
        

        //events
        //event EventHandler<EventArgs> NewTicket;
        //event EventHandler<EventArgs> EditUser;
        //event EventHandler<EventArgs> ShowMyOnlyTickets;
        //event EventHandler<EventArgs> Logout;
        //event EventHandler<EventArgs> Refresh;
        //event EventHandler<EventArgs> SelectUser;
        //event EventHandler<EventArgs> SortBy;

        //methods
        Task InitializeTaskTiles(FlowLayoutPanel unassignedPanel, FlowLayoutPanel assignedPanel, FlowLayoutPanel finishedPanel, string sortBy);
        void RefreshuserList();
        void RefeshPanels();
        Task UpdateBySort(string sortBy);
    }
}
