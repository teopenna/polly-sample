using Microsoft.Extensions.Options;
using PollySample.API.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollySample.API.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private MessageOptions _messageOptions;

        public MessageRepository(IOptions<MessageOptions> messageOptions)
        {
            _messageOptions = messageOptions.Value;
        }

        public async Task<string> GetGoodbyeMessage()
        {
            Console.WriteLine("MessageRepository GetGoodbyeMessage running");
            ThrowRandomException();
            return _messageOptions.GoodbyeMessage;
        }

        public async Task<string> GetHelloMessage()
        {
            Console.WriteLine("MessageRepository GetHelloMessage running");
            ThrowRandomException();
            return _messageOptions.HelloMessage;
        }

        private void ThrowRandomException()
        {
            var diceRoll = new Random().Next(0, 10);

            if (diceRoll > 5)
            {
                Console.WriteLine("ERROR! Throwing exception");
                throw new Exception("Exception in MessageRepository");
            }
        }
    }
}
