using System;

namespace SystemUnderTest.Blazor.Store
{
    public class UpdateNumberAction
    {
        public UpdateNumberAction(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }

    public class UpdateNumberSuccessAction
    {
        public UpdateNumberSuccessAction(int number, DateTime date)
        {
            Number = number;
            Date = date;
        }

        public int Number { get; }
        public DateTime Date { get; }
    }

    public class UpdateNumberFailureAction
    {
        public UpdateNumberFailureAction(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }

}