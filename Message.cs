using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace BiotestCompany
{
    class Message
    {
        private User sentBy { get; }
        private DateTime messageDT { get; }
        private string content { get; } // we assume that we cant edit messages
        private string attachedPhoto { get; }
        private Message asaResponseTo { get; }

        public Message(string content, string attachedPhoto, Message asaResponseTo) //add user sent by
        {
            this.messageDT = DateTime.Now;
            //this.user = sentBy;
            this.content = content;
            this.attachedPhoto = attachedPhoto;
            this.asaResponseTo = asaResponseTo;
        }
    }
}