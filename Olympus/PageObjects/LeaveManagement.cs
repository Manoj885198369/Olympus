using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Olympus.PageObjects
{
    class LeaveManagement
    {
        public LeaveManagement(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How=How.XPath,Using = "//span[text()='Leave']")]
        private IWebElement leavebutton;
             [FindsBy(How = How.XPath, Using = "//a[@href='https://icehrmpro.gamonoid.com/?g=modules&n=leaves&m=module_Leave']")]
        private IWebElement leavemanagement;
             [FindsBy(How = How.XPath, Using = "//button[text()='Apply Leave ']")]
        private IWebElement applyleave;
             [FindsBy(How = How.XPath, Using = "//select[@id='leave_type']")]
        private IWebElement leavetype;
             [FindsBy(How = How.XPath, Using = "//input[@id='date_start']")]
        private IWebElement leavestartdate;
             [FindsBy(How = How.XPath, Using = "//input[@id='date_start']")]
        private IWebElement leaveenddate;
             [FindsBy(How = How.XPath, Using = "//textarea[@id='details']")]
        private IWebElement reason;
             [FindsBy(How = How.XPath, Using = "//button[text()='Continue']")]
        private IWebElement Continue;

        public IWebElement Leavebutton { get => leavebutton; set => leavebutton = value; }
        public IWebElement Leavemanagement { get => leavemanagement; set => leavemanagement = value; }
        public IWebElement Applyleave { get => applyleave; set => applyleave = value; }
        public IWebElement Leavetype { get => leavetype; set => leavetype = value; }
        public IWebElement Leavestartdate { get => leavestartdate; set => leavestartdate = value; }
        public IWebElement Leaveenddate { get => leaveenddate; set => leaveenddate = value; }
        public IWebElement Reason { get => reason; set => reason = value; }
        public IWebElement Continue1 { get => Continue; set => Continue = value; }
    }
}
