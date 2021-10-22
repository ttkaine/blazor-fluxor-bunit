using Fluxor;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Internal.Account.Manage;

namespace SystemUnderTest.Blazor.Store
{
    public class UpdateNumberActionsReducer
    {
        [ReducerMethod]
        public static SystemState ReduceUpdateNumberAction(SystemState state, UpdateNumberAction _) =>
            state with
            {
                IsUpdating = true
            };
      
        [ReducerMethod]
        public static SystemState ReduceUpdateNumberSuccessAction(SystemState state, UpdateNumberSuccessAction _) =>
            state with
            {
                IsUpdating = false,
                Number = _.Number,
                Date = _.Date,
                Error = ""
            };

        [ReducerMethod]
        public static SystemState ReduceUpdateNumberAction(SystemState state, UpdateNumberFailureAction _) =>
            state with
            {
                IsUpdating = false,
                Error = _.Message
            };
    }
}