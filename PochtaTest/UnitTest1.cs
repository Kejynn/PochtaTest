using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace PochtaTest
{
    public class Tests
    {ä
        private IWebDriver driver;

        private readonly By pochtaButton = By.XPath("//button[@weight='500']");
        private readonly By LoginInputButton = By.XPath("//input[@name='login']");
        private readonly By signInnButton = By.XPath("//button[@type='submit']");
        private readonly By PassButton = By.XPath("//input[@name='passwd']");
        private readonly By enterButton = By.XPath("//button[@type='submit']");
        private readonly By letterButton = By.XPath("//a[@aria-describedby='tooltip-0-1']");
        private readonly By toButton = By.XPath("//div[@id='compose-field-1']");
        private readonly By themeButton = By.XPath("//input[@id='compose-field-subject-4']");
        private readonly By textButton = By.XPath("//div[@role='textbox']");
        private readonly By otpravButton = By.XPath("//div[@class='ComposeSendButton-Text']");

        private const string _login = "kejyn";
        private const string _to = "Kejyn@yandex.ru";
        private const string _pass = "testpasswd1234";
        private const string _theme = "test";
        private const string _text = "Hi!";

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver("C:/Users/User/Desktop/dnjofa");
            driver.Navigate().GoToUrl("https://mail.yandex.ru/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(400);
            var poc = driver.FindElement(pochtaButton);
            poc.Click();

            Thread.Sleep(400);
            var login = driver.FindElement(LoginInputButton);
            login.SendKeys(_login);

            Thread.Sleep(400);
            var signIn = driver.FindElement(signInnButton);
            signIn.Click();

            Thread.Sleep(400);
            var pass = driver.FindElement(PassButton);
            pass.SendKeys(_pass);

            Thread.Sleep(1000);
            var enter = driver.FindElement(enterButton);
            enter.Click();

            Thread.Sleep(5000);
            var letter = driver.FindElement(letterButton);
            letter.Click();

            Thread.Sleep(2000);
            var to = driver.FindElement(toButton);
            to.SendKeys(_to);

            Thread.Sleep(1000);
            var theme = driver.FindElement(themeButton);
            theme.SendKeys(_theme);

            Thread.Sleep(1000);
            var text = driver.FindElement(textButton);
            text.SendKeys(_text);
            Assert.Pass();

            Thread.Sleep(1000);
            var otpr = driver.FindElement(otpravButton);
            otpr.Click();
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}