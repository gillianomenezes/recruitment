using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Desing.ChatService
{
    class User
    {
        public string Profile { get; set; }
        public string StatusMessage { get; set; }
        private int Id;
        private List<int> ContactIds;
        private List<int> ConversationIds;

        public User()
        {
            this.ContactIds = new List<int>();
            this.ConversationIds = new List<int>();
        }

        public string GetProfile()
        {
            return this.Profile;
        }

        public void AddContact(User contact)
        {
            if(!ContactIds.Contains(contact.Id))
                this.ContactIds.Add(contact.Id);
        }    
        
        public void UpdateStatusMessage(string statusMessage)
        {
            StatusMessage = statusMessage;
        }           

        public string GetUserProfile()
        {
            return Profile;
        }
    }
}
