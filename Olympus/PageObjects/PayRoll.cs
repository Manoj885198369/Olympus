using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Olympus.PageObjects
{
    class PayRoll
    {
        public PayRoll(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How=How.XPath,Using = "//li[@ref='admin_Payroll']")]
        private IWebElement payroll;
            [FindsBy(How = How.XPath, Using = "https://icehrmpro.gamonoid.com/?g=admin&n=salary&m=admin_Payroll")]
        private IWebElement salary;
            [FindsBy(How = How.XPath, Using = "//span[text()=' Add New']")]
        private IWebElement addnewsalary;
            [FindsBy(How = How.XPath, Using = "//input[@id='code']")]
        private IWebElement code;
            [FindsBy(How = How.XPath, Using = "//input[@id='name']")]
        private IWebElement name;
            [FindsBy(How = How.XPath, Using = "//span[text()='Save']")]
        private IWebElement savebutton;

        public IWebElement Payroll { get => payroll; set => payroll = value; }
        public IWebElement Salary { get => salary; set => salary = value; }
        public IWebElement Addnewsalary { get => addnewsalary; set => addnewsalary = value; }
        public IWebElement Code { get => code; set => code = value; }
        public IWebElement Name { get => name; set => name = value; }
        public IWebElement Savebutton { get => savebutton; set => savebutton = value; }

        
      
    }
}
