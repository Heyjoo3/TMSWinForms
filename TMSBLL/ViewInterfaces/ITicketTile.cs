using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSLibrary;

namespace TMSBLL.Interfaces
{
    public interface ITicketTile
    {
        //methods

        ITicketTile CreateTicketTile(TicketModel ticket);
    }
}
