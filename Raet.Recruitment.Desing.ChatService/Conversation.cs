using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Desing.ChatService
{
    class Conversation
    {
        private int Id;
        private List<int> ContactIds;
        private List<string> Messages;
        
        public Conversation(List<int> contacIds)
        {
            this.ContactIds = contacIds;
            this.Messages = new List<string>();
        }

        public void SendMessage(string message)
        {            
            Messages.Add(message);
        }

        public List<string> ReadMessages()
        {
            return Messages;
        }
    }
}
