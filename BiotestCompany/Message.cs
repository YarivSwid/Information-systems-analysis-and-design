using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace BiotestCompany
{
    public class Message
    {
        private User sentBy { get; }
        private DateTime messageDT { get; }
        private string content { get; } // we assume that we cant edit messages
        private string attachedPhoto { get; }
        private Message asaResponseTo { get; }
        private int chatID;

        public Message(User sentBy, string content, string attachedPhoto, Message asaResponseTo, int chatID, Boolean isNew) //add user sent by
        {
            this.sentBy = sentBy;
            this.messageDT = DateTime.Now;
            this.content = content;
            this.attachedPhoto = attachedPhoto;
            this.asaResponseTo = asaResponseTo;
            this.chatID = chatID;
            if (isNew)
            {
                //this.createMessage();
                Program.Messages.Add(this);
            }
        }

        // getters & setters:

        public User getSentBy()
        {
            return this.sentBy;
        }
        public DateTime getMessageDT()
        {
            return this.messageDT;
        }
        public Message getAsaResponseTo()
        {
            return this.asaResponseTo;
        }

        public void createMessage()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddMessage @sentBy, @messageDT, @content, @attachedPhoto, @asaResponseToUser, @asaResponseToDT, @partOfChat";
            c.Parameters.AddWithValue("@sentBy", this.sentBy);
            c.Parameters.AddWithValue("@messageDT", this.messageDT);
            c.Parameters.AddWithValue("@content", this.content);
            c.Parameters.AddWithValue("@attachedPhoto", this.attachedPhoto);
            c.Parameters.AddWithValue("@asaResponseToUser", this.getAsaResponseTo().getSentBy().getID()); // need to insert USER ID, so retrieve the message, then the User that sent it, then the user's id.
            c.Parameters.AddWithValue("@asaResponseToDT", this.getAsaResponseTo().getMessageDT());
            c.Parameters.AddWithValue("@partOfChat", this.chatID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateMessage()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateMessage @sentBy, @messageDT, @content, @attachedPhoto, @asaResponseToUser, @asaResponseToDT, @partOfChat";
            c.Parameters.AddWithValue("@sentBy", this.sentBy);
            c.Parameters.AddWithValue("@messageDT", this.messageDT);
            c.Parameters.AddWithValue("@content", this.content);
            c.Parameters.AddWithValue("@attachedPhoto", this.attachedPhoto);
            c.Parameters.AddWithValue("@asaResponseToUser", this.getAsaResponseTo().getSentBy().getID()); // need to insert USER ID, so retrieve the message, then the User that sent it, then the user's id.
            c.Parameters.AddWithValue("@asaResponseToDT", this.getAsaResponseTo().getMessageDT());
            c.Parameters.AddWithValue("@partOfChat", this.chatID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}