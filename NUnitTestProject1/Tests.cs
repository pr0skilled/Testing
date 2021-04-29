using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;
using OpenQA.Selenium;
using System.Threading;

namespace NUnitTestProject1
{
    public class Tests
    {
        //Task 1
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            Thread.Sleep(500);
            driver.Url = "http://rozklad.kpi.ua/Schedules/ScheduleGroupSelection.aspx";
        }
        [Test]
        public void Test1()
        {
            IWebElement searchField = driver.FindElement(By.XPath("//*[@id=\"ctl00_MainContent_ctl00_txtboxGroup\"]"));
            searchField.Click();
            searchField.SendKeys(text: "КП-91");
            IWebElement searchButton = driver.FindElement(By.XPath("//*[@id=\"ctl00_MainContent_ctl00_btnShowSchedule\"]"));
            searchButton.SendKeys(Keys.Enter);
            IWebElement searchLesson = driver.FindElement(By.XPath("//*[@id=\"ctl00_MainContent_FirstScheduleTable\"]/tbody/tr[2]/td[4]/span/a"));
            if (searchLesson.Text.Contains("Компоненти програмної інженерії"))
            {
                Console.Beep(); Console.Beep();
            }
            else
                Console.Beep();
            Thread.Sleep(timeout: TimeSpan.FromSeconds(15));
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

        //Task 2 
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            Thread.Sleep(500);
            driver.Url = "https://www.google.com/";
        }

        [Test]
        public void Test2()
        {
            IWebElement googleSearchField = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
            googleSearchField.Click();
            googleSearchField.SendKeys(text: "Епіцентр");
            googleSearchField.SendKeys(Keys.Enter);
            Thread.Sleep(timeout: TimeSpan.FromSeconds(1));
            IWebElement epicentrUrlHref = driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/div/div/div[1]/a"));
            epicentrUrlHref.Click();
            IWebElement epicentrUselessInfo = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/span"));
            epicentrUselessInfo.Click();
            IWebElement epicentrInfo = driver.FindElement(By.XPath("/html/body/div[2]/header/div/div[8]/div/div[2]/div[1]"));
            epicentrInfo.Click();
            IWebElement epicentrContactInfo = driver.FindElement(By.XPath("/html/body/div[2]/header/div/div[8]/div/div[2]/div[2]/a[2]"));
            epicentrContactInfo.Click();
            Thread.Sleep(timeout: TimeSpan.FromSeconds(1));
            IWebElement searchText = driver.FindElement(By.XPath("/html/body/main/div[2]/div/section/h3"));
            if (searchText.Text.Contains("Контакт-центр працює для Вас щоденно з 07:30 до 22:30"))
            {
                Console.Beep(); Console.Beep();
            }
            else
            {
                Console.Beep();
            }
            Thread.Sleep(timeout: TimeSpan.FromSeconds(15));
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            Thread.Sleep(500);
            driver.Url = "https://www.gentoo.org/";
        }
        [Test]
        public void Test1()
        {
            IWebElement donate = driver.FindElement(By.XPath("/html/body/header/nav/div/div/div[2]/ul[2]/li/a"));
            donate.Click();
            IWebElement amount = driver.FindElement(By.XPath("//*[@id=\"donation-amount\"]"));
            amount.SendKeys("1488");
            IWebElement submit = driver.FindElement(By.XPath("//*[@id=\"donation-input-group\"]/span[2]/button"));
            submit.Click();
        }


        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}