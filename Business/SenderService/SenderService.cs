using System;
using System.Threading.Tasks;

namespace Business.SenderService
{
    public class SenderService: ISenderService
    {
        private readonly IMessageDispatcher messageDispatcher;
        private readonly IReceiversRepository recieversRepository;

        public SenderService(IMessageDispatcher messageDispatcher, IReceiversRepository recieversRepository)
        {
            this.messageDispatcher = messageDispatcher;
            this.recieversRepository = recieversRepository;
        }
        
        public async Task Send(){

        }
    }
}