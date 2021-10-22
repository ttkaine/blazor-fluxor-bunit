using System;

namespace SystemUnderTest.Blazor.Store
{
    public record SystemState
    {
        public int Number { get; init; }
        public DateTime Date { get; init; }
        public bool IsUpdating { get; init; }
        public string Error { get; init; }
    }
}