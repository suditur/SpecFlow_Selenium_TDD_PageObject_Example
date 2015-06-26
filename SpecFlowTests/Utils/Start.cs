using SpecFlowPages;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    public class Start : Driver
    {
        [BeforeScenario]
        public void Setup()
        {
            Intitialize();
            Instance.Navigate().GoToUrl(BaseAddress);
        }

        [AfterScenario]
        public void TearDown()
        {
            Close();
        }
    }
}