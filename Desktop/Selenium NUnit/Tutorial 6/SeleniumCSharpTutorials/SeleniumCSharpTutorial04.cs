using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class SeleniumCSharpTutorial4

    {
        [Test]
        [Author("Denu", "denuwanthirathnayaka@gmail.com")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/r.php";
                driver.Url = urlName;
                //IWebElement EmailTextField = driver.FindElement(By.Name("email"));
                IWebElement EmailTextField = driver.FindElement(By.Name("abcd"));
                EmailTextField.SendKeys("Selenium c#");
                driver.Quit();
            }

            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\ccc\\Desktop\\NUnit 3\\Tutorial 4\\SeleniumCSharpTutorials\\Screenshots\\Screenshot1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
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

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");

            return list;

        }

        //[Test]
        //[Author("Denu","denuwanthirathnayaka@gmail.com")]
        //[Description("Facebook login verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com/r.php";
        //    IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
        //    emailTextField.SendKeys("Selenium C#");
        //    driver.Quit();
        //}

    }

}
