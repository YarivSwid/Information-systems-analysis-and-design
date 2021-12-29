using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;


namespace BiotestCompany
{
    public class BusinessMeeting
    {
        private int meetingID;
        private DateTime meetingDT;
        private string notes;
        private User creator; // references to createdBy in BUSINESSMEETINGS table
        private List<Customer> customerParticipants;
        private List<User> userParticipants;

        public BusinessMeeting(int meetingID, DateTime meetingDT, string notes, User creator, Boolean isNew)
        {   // from DB
            this.meetingID = meetingID;
            this.meetingDT = meetingDT;
            this.notes = notes;
            this.creator = creator;
            populateCustomerParticipants();
            populateUserParticipants();
        }

        public BusinessMeeting(DateTime meetingDT, string notes, User creator, List<Customer> customerParticipants, List<User> userParticipants)
        {   // from GUI, only NEW objects
            this.meetingID = generateID(); // call function that generates ID
            this.meetingDT = meetingDT;
            this.notes = notes;
            this.creator = creator;
            this.customerParticipants = customerParticipants;
            this.userParticipants = userParticipants;
            this.createBusinessMeeting();
            Program.BusinessMeetings.Add(this);
        }



        public Boolean addParticipants(Customer cust, User user)
        { // returns false if no cust or user given
            if (cust != null)
            {
                customerParticipants.Add(cust);
                return true;
            }
            else if (user != null)
            {
                userParticipants.Add(user);
                return true;
            }
            else
                return false;
        }

        // getters:

        public int getMeetingID()
        {
            return this.meetingID;
        }
        public DateTime getMeetingDT()
        {
            return this.meetingDT;
        }
        public string getNotes()
        {
            return this.notes;
        }
        public User getCreator()
        {
            return this.creator;
        }

        // setters:

        public void setMeetingDT(DateTime DT)
        {
            this.meetingDT = DT;
        }
        public void setNotes(string notes)
        {
            this.notes = notes;
        }
        // set creator?

        // general:

        private int generateID()
        {
            int maxID = Program.BusinessMeetings.Max(t => t.meetingID);
            return maxID + 1;
        }

        public void createBusinessMeeting()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddBusinessMeeting @meetingID,@meetingDT,@notes,@creator"; // CREATE THIS SP
            c.Parameters.AddWithValue("@meetingID", this.meetingID);
            c.Parameters.AddWithValue("@meetingDT", this.meetingDT);
            c.Parameters.AddWithValue("@notes", this.notes);
            c.Parameters.AddWithValue("@creator", this.creator.getID()); // inserts the creators userId
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateBusinessMeeting()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateBusinessMeeting @meetingID,@meetingDT,@notes,@creator"; // CREATE THIS SP
            c.Parameters.AddWithValue("@meetingID", this.meetingID);
            c.Parameters.AddWithValue("@meetingDT", this.meetingDT);
            c.Parameters.AddWithValue("@notes", this.notes);
            c.Parameters.AddWithValue("@creator", this.creator.getID()); // inserts the creators userId
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void populateCustomerParticipants()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetCustomersFromCustomerInvits @meetingID";
            c.Parameters.AddWithValue("@meetingID", this.meetingID);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            int cusID;

            while (rdr.Read())
            {
                cusID = (int.Parse(rdr.GetValue(0).ToString()));
                this.customerParticipants.Add(Program.FindMyCustomer(cusID)); // finds object of type Customer, then adds to vector
            }
        }
        public void populateUserParticipants()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetUsersFromUserInvits @meetingID";
            c.Parameters.AddWithValue("@meetingID", this.meetingID);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            int userID;

            while (rdr.Read())
            {
                userID = (int.Parse(rdr.GetValue(0).ToString()));
                this.userParticipants.Add(Program.FindMyUser(userID)); // finds object of type Customer, then adds to vector
            }
        }

        public void generateForm() // CREATE
        {

        }
    }
}