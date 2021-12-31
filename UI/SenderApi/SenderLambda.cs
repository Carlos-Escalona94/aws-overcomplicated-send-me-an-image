

using System.Linq;
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

        public async Task FunctionHandler(SQSEvent events, ILambdaContext context){
            events.Records.Select(e => new {

            });
            context.Logger.Log("OIIII");
        }
    }
}