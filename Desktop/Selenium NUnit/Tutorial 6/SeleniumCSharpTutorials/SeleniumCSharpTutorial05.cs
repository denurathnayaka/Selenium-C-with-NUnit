using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class SeleniumCSharpTutorial05
    {
        ExtentReports extent = null;
        [OneTimeSetUp]
        public void Extentstart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\ccc\Desktop\Selenium NUnit\Tutorial 5\SeleniumCSharpTutorials\ExtentReports\SeleniumCSharpTutorial05.html");
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }
        [Test]
        public void Test1()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("Test1").Info("Test Started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome browser launched");
                driver.Url = "https://www.facebook.com/r.php";
                IWebElement EmailTextField = driver.FindElement(By.Name("reg_email__"));
                EmailTextField.SendKeys("Selenium c#");
                test.Log(Status.Info, "Email id entered");
                driver.Quit();
                test.Log(Status.Pass, "Test1 passed");              
            }

            catch (Exception e)
            {

                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

        }

        [Test]
        public void Test2()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("Test1").Info("Test Started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome browser launched");
                driver.Url = "https://www.facebook.com/r.php";
                IWebElement EmailTextField = driver.FindElement(By.Name("reg_abcd__"));
                EmailTextField.SendKeys("Selenium c#");
                test.Log(Status.Info, "Email id entered");
                driver.Quit();
                test.Log(Status.Pass, "Test1 passed");
            }

            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

        }
    }
}