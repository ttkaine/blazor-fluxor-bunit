using Fluxor;

namespace SystemUnderTest.Blazor.Store
{
    public class SystemFeature : Feature<SystemState>
    {
        public override string GetName()
        {
            return "system";
        }

        protected override SystemState GetInitialState()
        {
            return new SystemState();
        }
    }
}