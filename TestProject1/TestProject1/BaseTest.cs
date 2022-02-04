using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestProject1
{
    public class BaseTest : IDisposable
    {
        public void StartDriverWithURL(string url)
        {
            DriverHolder.driver = new ChromeDriver();
            DriverHolder.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            DriverHolder.driver.Manage().Window.Maximize();
            DriverHolder.driver.Navigate().GoToUrl(url);
            
        }
        public void Dispose()
        {
            DriverHolder.driver.Quit();
        }
    }
}
