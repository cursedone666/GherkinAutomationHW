Feature: Search
	
Background: 
	Given user in on the homepage
	When user ckick on search icon
	And user clicks on search field

@mytag
Scenario: Search by Anime by its name
	When user enters 'Kanasuba'in search field
	And user presses Enter button
	Then user appears on search page with results
	And user sees anime 'Kanasuba'

Scenario: Find character
	When user enters character 'Tanjiro' in search field
	And user presses Enter button
	Then user appears on result page
	And user clicks on 'Characters' filter button 
	Then user must appear on characters search page 
	And user sees character 'Tanjiro Kamado'

Scenario: Find Manga by its name
	When user enters 'Tokyo ghoul' manga in search field
	And user presses Enter button
	And user clicks on button 'Manga' in filter
	Then user sees sorted page with manga
	And user sees manga 'Tokyo ghoul'

Scenario: Find anime director
	When user enters name 'Miyadzaki Hayao' in search field
	And user presses Enter button
	Then user appears on page with result
	When user clicks on 'Persons' button
	Then user sees Miyadzaki Hayao