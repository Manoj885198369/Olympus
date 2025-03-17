using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using IceHRM.GenericUtils;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Olympus.TestScripts
{
   public  class HardCore1
    {
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            WebDriverUtils wd = new WebDriverUtils();
            wd.MaximizeWindow(driver);
            wd.ImplicitWait(driver, 10);
            driver.Url = "https://icehrmpro.gamonoid.com/login.php?logout=1";
            driver.FindElement(By.Id("username")).SendKeys("user1");
            driver.FindE
        }
    }
}
