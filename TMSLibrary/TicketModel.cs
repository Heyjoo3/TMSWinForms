namespace TMSLibrary
{
    using System.Collections.Generic;
    public class TicketModel
    {

        // fields 
        private int id;
        private string title;
        private string description;
        private string status;
        private string priority;
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
            
        public string Priority
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

        // constructor
        public TicketModel()
        {
            this.Id = 0;
            this.Title = "";
            this.Description = "";
            this.Status = "";
            this.Priority = "";
            this.DueDate = "";
            this.AssignedUserId = 0;
            this.AssignedUserName = "";
        }

        public TicketModel(int id, string title, string description, string status, string priority, string dueDate, int assignedUserId, string assignedUserName)
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

        public TicketModel(string title, string description, string priority, string dueDate, string assignedUserName)
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

            List<UserModel> users = SqliteDataAccess.LoadUsers();


            foreach (UserModel user in users)
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
