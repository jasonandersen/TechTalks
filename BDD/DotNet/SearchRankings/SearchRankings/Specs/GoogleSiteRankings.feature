Feature: GoogleSiteRankings
	As the marketing team
	We want to ensure that HMSA.com is on the first page of Google search results
	So that our products are easy to find for our customers

@Google
Scenario: We are on the first page for 'hawaii health insurance'
	Given I'm on the Google home page
	When I search for 'hawaii health insurance'
	Then 'www.hmsa.com' is on the first page of results

