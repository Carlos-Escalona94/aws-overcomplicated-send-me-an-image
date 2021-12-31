

using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace UI.SenderApi{
    public class Function{

        public Function(){

        }

        public async Task FunctionHandler(SQSEvent.SQSMessage message, ILambdaContext context){
            
        }
    }
}