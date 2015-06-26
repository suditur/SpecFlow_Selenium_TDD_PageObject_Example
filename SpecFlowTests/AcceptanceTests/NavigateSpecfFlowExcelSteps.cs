using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowPages;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class NavigateSpecfFlowExcelSteps : Start
    {        
        [Given(@"the specflow page")]
        public void GivenTheSpecflowPage()
        {
            
        }
        
        [When(@"I press Specflow\+")]
        public void WhenIPressSpecflow()
        {
            NavigateToSpecFlowExcel.ClickSpecflowPlus();
        }
        
        [When(@"Specflow\+-Excel")]
        public void WhenSpecflow_Excel()
        {
            NavigateToSpecFlowExcel.ClickSpecflowPlusExcel();
        }
        
        [Then(@"I'(.*)'Get Started Now with SpecFlow\+ Excel!' button")]
        public void ThenIGetStartedNowWithSpecFlowExcelButton(string p0)
        {
            Assert.AreEqual(ConstantsUtils.GetStartedExcelButtonText, 
                NavigateToSpecFlowExcel.GetButtonGetStartedText());                
        }
    }
}
