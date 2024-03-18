using System.Collections.Generic;

namespace TMSLibrary
{
    public class TicketModel
    {

        // fields 
        private int id;
        private string title;
        private string description;
        private string status;
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
        public string Status
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
        public int AssignedUserId
        {
            get { return assignedUserID; }
            set { assignedUserID = value; }
        }
        public string AssignedUserName
        {
            get { return assignedUserName; }
            set { assignedUserName = value; }
        }


        //all fileds constructor e.g. für editnng
        public TicketModel(int id, string title, string description, string status, int priority, string dueDate, int assignedUserId, string assignedUserName)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Status = status;
            this.Priority = priority;
            this.DueDate = dueDate;
            this.AssignedUserId = assignedUserId;
            this.AssignedUserName = assignedUserName;
        }

        //new ticket constructor, assigns user id based on username, automatically sets status
        public TicketModel(string title, string description, int priority, string dueDate, string assignedUserName, List<UserModel> userList)
        {
            this.Id = 0;
            this.Title = title;
            this.Description = description;
            this.Priority = priority;
            this.DueDate = dueDate;
            this.AssignedUserName = assignedUserName;

            if (assignedUserName == "" || assignedUserName == null)
            {
                this.Status = "Unassigned";
            }
            else
            {
                this.Status = "Assigned";
            }

            foreach (UserModel user in userList)
            {
                if (user.Name == assignedUserName)
                {
                    this.AssignedUserId = user.Id;
                    break; 
                }
            }   
        }
    }
}
