using System;
using System.Threading.Tasks;
using Fluxor;

namespace SystemUnderTest.Blazor.Store
{
    public class UpdateNumberEffect : Effect<UpdateNumberAction>
    {
        public async override Task HandleAsync(UpdateNumberAction action, IDispatcher dispatcher)
        {
            DateTime dateTime = DateTime.UtcNow;
            int number = action.Number;
            if (number < 0)
            {
                dispatcher.Dispatch(new UpdateNumberFailureAction("Stop being so negative!"));
            }
            else
            {
                dispatcher.Dispatch(new UpdateNumberSuccessAction(number, dateTime));
            }
        }
    }
}