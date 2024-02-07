using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLibrary
{
    public class TicketModel
    {

        // fields 
        private int id;
        private string title;
        private string description;
        private int status;
        private int priority;
        private string dueDate;
        private int assignedUserID;
        private string assignedUserName;

        // properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
            
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public int AssignedUserID
        {
            get { return assignedUserID; }
            set { assignedUserID = value; }
        }
        public string AssignedUserName
        {
            get { return assignedUserName; }
            set { assignedUserName = value; }
        } 
    }
}
