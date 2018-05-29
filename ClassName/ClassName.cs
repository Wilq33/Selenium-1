using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace ClassName
{
    class ClassName
    {
        static void Main()
        {
            string url = "http://testing.todvachev.com/selectors/class-name/";
            string name = "testClass";

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.ClassName(name));

            Console.WriteLine(element.Text);

            Thread.Sleep(3000);
            driver.Quit();
        }

    }
}
