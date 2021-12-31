

using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;
using Business.SenderService;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace UI.SenderApi{
    public class Function{

        private readonly ISenderService senderService;

        public Function(){
            this.senderService = new SenderService();
        }

        public async Task FunctionHandler(SQSEvent.SQSMessage message, ILambdaContext context){

        }
    }
}