using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using Xunit;
using OpenQA.Selenium;

namespace TestProject1
{
    [Binding]
    public class WatchAnimeAndManga : BaseTest
    {
        [Given(@"user is on '(.*)' homepage")]
        public void GivenUserIsOnHomepage(string p0)
        {
            DriverHolder.driver = StartDriverWithURL("https://animego.org");
        }

        [When(@"user clicks on '(.*)' button in header")]
        public void WhenUserClicksOnButtonInHeader(string p0)
        {
            IWebElement animeButton = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Аниме')]"));
            animeButton.Click();

        }

        [When(@"user clicks on '(.*)' in header")]
        public void WhenUserClicksOnInHeader(string p0)
        {
            IWebElement mangaElement = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Манга')]"));
            mangaElement.Click();
        }

        [When(@"user clicks on '(.*)' button in filter")]
        public void WhenUserClicksOnButtonInFilter(string p0)
        {
            IWebElement genreButton = DriverHolder.driver.FindElement(By.XPath("(//button[@type='button'])[3]"));
            genreButton.Click();
        }

        [When(@"user chooses '(.*)' genre")]
        public void WhenUserChoosesGenre(string p0)
        {
            IWebElement fantasyGenre = DriverHolder.driver.FindElement(By.XPath("//div[@id='filter']/div[3]/form/div[2]/div[2]/div/div/span[39]/span"));
            fantasyGenre.Click();
        }

        [When(@"user presses on '(.*)' button in header")]
        public void WhenUserPressesOnButtonInHeader(string p0)
        {
            IWebElement charactersButtonElement = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Персонажи')]"));
            charactersButtonElement.Click();
        }

        [Then(@"user appears on '(.*)' page")]
        public void ThenUserAppearsOnPage(string p0)
        {
            IWebElement titleElement = DriverHolder.driver.FindElement(By.XPath("//div[@id='anime-list-title']/h1"));
            string actualTitle = titleElement.Text;
            Assert.Equal("Список аниме", actualTitle);
        }

        [Then(@"user appears on page with Manga")]
        public void ThenUserAppearsOnPageWithManga()
        {
            IWebElement mangaTitleElement = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'Манга')]"));
            string actualMangaTitle = mangaTitleElement.Text;
            Assert.Equal("Манга", actualMangaTitle);
        }

        [Then(@"user sees manga with '(.*)' genre")]
        public void ThenUserSeesMangaWithGenre(string p0)
        {
            IWebElement genreElement = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Фэнтези')]"));
            string actualGenre = genreElement.Text;
            Assert.Equal("Фэнтези", actualGenre);
        }

        [Then(@"user sees list of anime characters")]
        public void ThenUserSeesListOfAnimeCharacters()
        {
            IWebElement titleElement = DriverHolder.driver.FindElement(By.XPath("//h1[contains(.,'Аниме персонажи')]"));
            string actualTitleText = titleElement.Text;
            Assert.Equal("Аниме персонажи", actualTitleText);
        }

        [Then(@"user sees '(.*)' in body")]
        public void ThenUserSeesInBody(string p0)
        {
            IWebElement scheduleElement = DriverHolder.driver.FindElement(By.XPath("//div[@id='wrap']/div[5]/div/div/div[2]/div/div/h3"));
            string actualTitleName = scheduleElement.Text;
            Assert.Equal("Расписание аниме", actualTitleName);
        }

        [Then(@"user clicks on '(.*)' button in schedule")]
        public void ThenUserClicksOnButtonInSchedule(string p0)
        {
            IWebElement dayElement = DriverHolder.driver.FindElement(By.XPath("//a[contains(@href, '#slide-toggle-thursday')]"));
            dayElement.Click();
        }

        [Then(@"user sees '(.*)' in schedule list")]
        public void ThenUserSeesInScheduleList(string p0)
        {
            IWebElement animeNameElement = DriverHolder.driver.FindElement(By.XPath("//div[@id='slide-toggle-thursday']/div/div/div[2]/div/div/a/span"));
            string actualAnimeName = animeNameElement.Text;
            Assert.Equal("Шаман Кинг (2021)", actualAnimeName);
        }
    }
}
