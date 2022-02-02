using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestProject1
{
    public class DriverHolder
    {
        public static IWebDriver driver { get; set; }
    }
}
