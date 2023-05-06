using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTestByOrnikar.drivers
{
    public class Driver
    {
        public static IWebDriver chromeDriver = new ChromeDriver("chromedriver.exe");
    }
}
