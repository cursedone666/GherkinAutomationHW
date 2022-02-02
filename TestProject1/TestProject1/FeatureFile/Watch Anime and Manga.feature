Feature: Watch Anime and Manga
	I as a user
	want to get acquinted with anime culture
	in order to spend my spare time


Background: 
	Given user is on 'Animego' homepage

@mytag
Scenario: Get accuainted with anime list
	When user clicks on 'Anime' button in header
	Then user appears on 'Anime list' page

Scenario: Read fantasy manga
	When user clicks on 'Manga' in header
	Then user appears on page with Manga
	When user clicks on 'Genre' button in filter
	And user chooses 'Fantasy' genre
	Then user sees manga with 'Fantasy' genre

Scenario: Look at anime characters
	When user presses on 'Characters' button in header
	Then user sees list of anime characters
	
Scenario: See when new episodes of Anime come out
	Then user sees 'Anime schedule' in body
	And user clicks on 'Thursday' button in schedule
	Then user sees 'Shaman king' in schedule list