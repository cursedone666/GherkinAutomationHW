using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using Xunit;
using OpenQA.Selenium;

namespace TestProject1
{
    [Binding]
    public class SearchSteps : BaseTest
    {
        [Given(@"user in on the homepage")]
        public void GivenUserInOnTheHomepage()
        {
            DriverHolder.driver = StartDriverWithURL("https://animego.org/");
        }

        [When(@"user ckick on search icon")]
        public void WhenUserCkickOnSearchIcon()
        {
            IWebElement iconElement = DriverHolder.driver.FindElement(By.Id("navbar-search"));
            iconElement.Click();
        }

        [When(@"user clicks on search field")]
        public void WhenUserClicksOnSearchField()
        {
            IWebElement searchFieldElement = DriverHolder.driver.FindElement(By.Name("q"));
            searchFieldElement.Click();
        }

        [When(@"user enters '(.*)'in search field")]
        public void WhenUserEntersInSearchField(string p0)
        {
            IWebElement searchFieldElement = DriverHolder.driver.FindElement(By.Name("q"));
            searchFieldElement.Click();
            searchFieldElement.SendKeys("Kanasuba");
        }

        [When(@"user presses Enter button")]
        public void WhenUserPressesEnterButton()
        {
            IWebElement searchFieldElement = DriverHolder.driver.FindElement(By.Name("q"));
            //searchFieldElement.Click();
            searchFieldElement.SendKeys(Keys.Enter);
        }

        [When(@"user enters character '(.*)' in search field")]
        public void WhenUserEntersCharacterInSearchField(string p0)
        {
            IWebElement searchElement = DriverHolder.driver.FindElement(By.Name("q"));
            searchElement.SendKeys("Tanjiro");
        }

        [When(@"user enters '(.*)' manga in search field")]
        public void WhenUserEntersMangaInSearchField(string p0)
        {
            IWebElement searchElement = DriverHolder.driver.FindElement(By.Name("q"));
            searchElement.SendKeys("Tokyo ghoul");
        }

        [When(@"user clicks on button '(.*)' in filter")]
        public void WhenUserClicksOnButtonInFilter(string p0)
        {
            IWebElement manga = DriverHolder.driver.FindElement(By.XPath("//main[@id='content']/div/div[2]/ul/li[3]/a/span"));
            manga.Click();
        }

        [When(@"user enters name '(.*)' in search field")]
        public void WhenUserEntersNameHayaoInSearchField(string p0)
        {
            IWebElement searchElement = DriverHolder.driver.FindElement(By.Name("q"));
            searchElement.SendKeys("Miyadzaki Hayao");
        }


        [When(@"user clicks on '(.*)' button")]
        public void WhenUserClicksOnButton(string p0)
        {
            IWebElement personElement = DriverHolder.driver.FindElement(By.XPath("//main[@id='content']/div/div[2]/ul/li[2]/a"));
            personElement.Click();
        }

        [Then(@"user appears on search page with results")]
        public void ThenUserAppearsOnSearchPageWithResults()
        {
            IWebElement resultPageElement = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'Поиск «Kanasuba»')]"));
            string actualSearchResult = resultPageElement.Text;
            Assert.Equal("Поиск «Kanasuba»", actualSearchResult);
        }

        [Then(@"user sees anime '(.*)'")]
        public void ThenUserSeesAnime(string p0)
        {
            IWebElement animeElement = DriverHolder.driver.FindElement(By.LinkText("Этот замечательный мир!"));
            string actualAnime = animeElement.Text;
            Assert.Equal("Этот замечательный мир!", actualAnime);
        }

        [Then(@"user appears on result page")]
        public void ThenUserAppearsOnResultPage()
        {
            IWebElement resultPageElement = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'Поиск «Tanjiro»')]"));
            string actualSearchResult = resultPageElement.Text;
            Assert.Equal("Поиск «Tanjiro»", actualSearchResult);
        }

        [Then(@"user appears on page with result")]
        public void ThenUserAppearsOnPageWithResult()
        {
            IWebElement personElement = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'Поиск «Miyadzaki Hayao»')]"));
            string actualPersonFilter = personElement.Text;
            Assert.Equal("Поиск «Miyadzaki Hayao»", actualPersonFilter);
        }


        [Then(@"user clicks on '(.*)' filter button")]
        public void ThenUserClicksOnFilterButton(string p0)
        {
            IWebElement filterButton = DriverHolder.driver.FindElement(By.XPath("//main[@id='content']/div/div[2]/ul/li[3]/a/span"));
            filterButton.Click();
        }

        [Then(@"user must appear on characters search page")]
        public void ThenUserMustAppearOnCharactersSearchPage()
        {
            IWebElement charactersElement = DriverHolder.driver.FindElement(By.XPath("//main[@id='content']/div/div[3]/div[2]/a/h2"));
            string actualFilter = charactersElement.Text;
            Assert.Equal("Персонажи", actualFilter);
        }

        [Then(@"user sees character '(.*)'")]
        public void ThenUserSeesCharacter(string p0)
        {
            IWebElement character = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Тандзиро Камадо')]"));
            string actualCharacter = character.Text;
            Assert.Equal("Тандзиро Камадо", actualCharacter);
        }

        [Then(@"user sees sorted page with manga")]
        public void ThenUserSeesSortedPageWithManga()
        {
            IWebElement searchElement = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'Поиск «Tokyo ghoul»')]"));
            string actualSearch = searchElement.Text;
            Assert.Equal("Поиск «Tokyo ghoul»", actualSearch);
        }

        [Then(@"user sees manga '(.*)'")]
        public void ThenUserSeesManga(string p0)
        {
            IWebElement mangaResult = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Токийский гуль')]"));
            string actualManga = mangaResult.Text;
            Assert.Equal("Токийский гуль", actualManga);
        }

        [Then(@"user sees Miyadzaki Hayao")]
        public void ThenUserSeesMiyadzakiHayao()
        {
            IWebElement person = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Миядзаки Хаяо')]"));
            string actualPerson = person.Text;
            Assert.Equal("Миядзаки Хаяо", actualPerson);
        }

    }
}
