// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class OrderSkipAttribute
    {      
        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/r.php";
            IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            Assert.Ignore("Defect 1234");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/r.php";
            IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}

