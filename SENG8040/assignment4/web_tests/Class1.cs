using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class AddVehicleInputEmptyExpetedErrorMessages
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void AddVehicle_InputEmpty_ExpetedErrorMessages()
        {
            driver.Navigate().GoToUrl("http://localhost/website/index.html");
            driver.FindElement(By.XPath("//input[@value='New']")).Click();
            driver.FindElement(By.Id("save_button")).Click();
            Assert.AreEqual("Input not valid", driver.FindElement(By.Id("sellerError")).Text);
            Assert.AreEqual("Input not valid", driver.FindElement(By.Id("phoneError")).Text);
            Assert.AreEqual("Input not valid", driver.FindElement(By.Id("addressError")).Text);
            Assert.AreEqual("Input not valid", driver.FindElement(By.Id("cityError")).Text);
            Assert.AreEqual("Input not valid", driver.FindElement(By.Id("emailError")).Text);
            Assert.AreEqual("Input not valid", driver.FindElement(By.Id("modelError")).Text);
            Assert.AreEqual("Input not valid", driver.FindElement(By.Id("manufacturerError")).Text);
            Assert.AreEqual("Input not valid", driver.FindElement(By.Id("yearError")).Text);
        }
        [Test]
        public void AddVehicle_InputIncorrectPhone_ExpectedErrorMessage()
        {
            driver.Navigate().GoToUrl("http://localhost/website/index.html");
            driver.FindElement(By.XPath("//input[@value='New']")).Click();
            driver.FindElement(By.Id("seller")).Click();
            driver.FindElement(By.Id("seller")).Clear();
            driver.FindElement(By.Id("seller")).SendKeys("Tymur Koltunov");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("some home");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-123");
            driver.FindElement(By.Id("vehicleModel")).Click();
            driver.FindElement(By.Id("vehicleModel")).Clear();
            driver.FindElement(By.Id("vehicleModel")).SendKeys("supra");
            driver.FindElement(By.Id("vehicleManufacturer")).Click();
            driver.FindElement(By.Id("vehicleManufacturer")).Clear();
            driver.FindElement(By.Id("vehicleManufacturer")).SendKeys("toyota");
            driver.FindElement(By.Id("vehicleYear")).Click();
            driver.FindElement(By.Id("vehicleYear")).Clear();
            driver.FindElement(By.Id("vehicleYear")).SendKeys("2000");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("some@email.com");
            driver.FindElement(By.Id("save_button")).Click();
            Assert.AreEqual("Input not valid", driver.FindElement(By.Id("phoneError")).Text);
        }
        [Test]
        public void AddVehicle_InputIncorrectEmail_ExpectedErrorMessage()
        {
            driver.Navigate().GoToUrl("http://localhost/website/index.html");
            driver.FindElement(By.XPath("//input[@value='New']")).Click();
            driver.FindElement(By.Id("seller")).Click();
            driver.FindElement(By.Id("seller")).Clear();
            driver.FindElement(By.Id("seller")).SendKeys("Tymur Koltunov");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("some home");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Kitchener");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("vehicleModel")).Click();
            driver.FindElement(By.Id("vehicleModel")).Clear();
            driver.FindElement(By.Id("vehicleModel")).SendKeys("supra");
            driver.FindElement(By.Id("vehicleManufacturer")).Click();
            driver.FindElement(By.Id("vehicleManufacturer")).Clear();
            driver.FindElement(By.Id("vehicleManufacturer")).SendKeys("toyota");
            driver.FindElement(By.Id("vehicleYear")).Click();
            driver.FindElement(By.Id("vehicleYear")).Clear();
            driver.FindElement(By.Id("vehicleYear")).SendKeys("2000");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("some@email");
            driver.FindElement(By.Id("save_button")).Click();
            Assert.AreEqual("Input not valid", driver.FindElement(By.Id("emailError")).Text);
        }
        [Test]
        public void AddVehicle_InputCorrectInfo_ExpectedNextPageWithInfoAndLink()
        {
            driver.Navigate().GoToUrl("http://localhost/website/index.html");
            driver.FindElement(By.XPath("//input[@value='New']")).Click();
            driver.FindElement(By.Id("seller")).Click();
            driver.FindElement(By.Id("seller")).Clear();
            driver.FindElement(By.Id("seller")).SendKeys("Some Name");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("Some street");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("toronto");
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("321-321-0321");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("valid@email.com");
            driver.FindElement(By.Id("vehicleModel")).Clear();
            driver.FindElement(By.Id("vehicleModel")).SendKeys("tundra");
            driver.FindElement(By.Id("vehicleManufacturer")).Clear();
            driver.FindElement(By.Id("vehicleManufacturer")).SendKeys("toyota");
            driver.FindElement(By.Id("vehicleYear")).Clear();
            driver.FindElement(By.Id("vehicleYear")).SendKeys("2000");
            driver.FindElement(By.Id("save_button")).Click();
            Assert.AreEqual("Some Name / Some street / toronto / 321-321-0321 / valid@email.com / tundra / toyota / 2000 /", driver.FindElement(By.Id("added")).Text);
            Assert.AreEqual("http://jdpower.com/cars/toyota/tundra/2000", driver.FindElement(By.Id("link")).Text);
        }
        [Test]
        public void TheSearchInput2VehiclesExpected2VehiclesOnDisplayPageTest()
        {
            driver.Navigate().GoToUrl("http://localhost/website/index.html");
            driver.FindElement(By.Id("button_display")).Click();
            driver.FindElement(By.Id("button_clear")).Click();
            driver.FindElement(By.Id("back_from_display")).Click();
            driver.FindElement(By.XPath("//input[@value='New']")).Click();
            driver.FindElement(By.Id("seller")).Click();
            driver.FindElement(By.Id("seller")).Clear();
            driver.FindElement(By.Id("seller")).SendKeys("seller one");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("address one");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("city one");
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("email@one.com");
            driver.FindElement(By.Id("vehicleModel")).Clear();
            driver.FindElement(By.Id("vehicleModel")).SendKeys("tundra");
            driver.FindElement(By.Id("vehicleManufacturer")).Clear();
            driver.FindElement(By.Id("vehicleManufacturer")).SendKeys("toyota");
            driver.FindElement(By.Id("vehicleYear")).Clear();
            driver.FindElement(By.Id("vehicleYear")).SendKeys("2000");
            driver.FindElement(By.Id("save_button")).Click();
            driver.FindElement(By.Id("button_back_added")).Click();
            driver.FindElement(By.XPath("//input[@value='New']")).Click();
            driver.FindElement(By.Id("seller")).Click();
            driver.FindElement(By.Id("seller")).Clear();
            driver.FindElement(By.Id("seller")).SendKeys("seller two");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("address two");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("city two");
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("456-456-4567");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("email@two.com");
            driver.FindElement(By.Id("vehicleModel")).Click();
            driver.FindElement(By.Id("vehicleModel")).Clear();
            driver.FindElement(By.Id("vehicleModel")).SendKeys("4c");
            driver.FindElement(By.Id("vehicleManufacturer")).Click();
            driver.FindElement(By.Id("vehicleManufacturer")).Clear();
            driver.FindElement(By.Id("vehicleManufacturer")).SendKeys("alpha-romeo");
            driver.FindElement(By.Id("vehicleYear")).Click();
            driver.FindElement(By.Id("vehicleYear")).Clear();
            driver.FindElement(By.Id("vehicleYear")).SendKeys("2015");            
            driver.FindElement(By.Id("save_button")).Click();
            driver.FindElement(By.Id("button_back_added")).Click();
            driver.FindElement(By.Id("button_display")).Click();
            Assert.AreEqual("seller one address one city one 123-123-1234 email@one.com tundra toyota 2000 \r\nseller two address two city two 456-456-4567 email@two.com 4c alpha-romeo 2015 ", driver.FindElement(By.Id("display")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
