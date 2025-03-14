using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Olympus.PageObjects
{
    class AttendanceManagement
    {
        public AttendanceManagement(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//span[text()='Time Management']")]
        private IWebElement TimeManagement;
        [FindsBy(How = How.XPath, Using = "//a[@href='https://icehrmpro.gamonoid.com/?g=modules&n=attendance&m=module_Time_Management']")]
        private IWebElement attendance;
        [FindsBy(How = How.XPath, Using = "//span[text()='Punch In']")]
        private IWebElement punchin;
        [FindsBy(How = How.XPath, Using = "//div[@class='ant-picker ant-picker-middle ant-picker-outlined css-dev-only-do-not-override-240cud']")]
        private IWebElement Time;
        [FindsBy(How = How.XPath, Using = "Save")]
        private IWebElement savebutton;

        public IWebElement TimeManagement1 { get => TimeManagement; set => TimeManagement = value; }
        public IWebElement Attendance { get => attendance; set => attendance = value; }
        public IWebElement Punchin { get => punchin; set => punchin = value; }
        public IWebElement Time1 { get => Time; set => Time = value; }
        public IWebElement Savebutton { get => savebutton; set => savebutton = value; }
    }
}
