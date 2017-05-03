using NUnit.Framework;
using SearchRankings.Pages;
using TechTalk.SpecFlow;

namespace SearchRankings.Specs.StepDefinitions
{
    [Binding]
    public class SiteRankingSteps : BaseSteps
    {
        [Given(@"I'm on the Google home page")]
        public void GivenIMOnTheGoogleHomePage()
        {
            GoogleHomePage homePage = new GoogleHomePage(Browser);
            Set<GoogleHomePage>(homePage);
        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchGoogleFor(string query)
        {
            GoogleHomePage googleHome = Get<GoogleHomePage>();
            GoogleSearchResultsPage resultsPage = googleHome.Search(query);
            Set<GoogleSearchResultsPage>(resultsPage);
        }

        [Then(@"'(.*)' is on the first page of results")]
        public void ThenIsOnTheFirstPageOfResults(string siteUrl)
        {
            GoogleSearchResultsPage resultsPage = Get<GoogleSearchResultsPage>();
            Assert.IsTrue(resultsPage.ContainsResult(siteUrl));
        }


    }
}
