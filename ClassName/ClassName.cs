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

            if (element.Displayed)
            {
                GreenMessage("Yes, I see it");
            }
            else
            {
                RedMessage("No, I don't see it");
            }

            Thread.Sleep(3000);
            driver.Quit();
        }

        //changing color to red
        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //changing color to green
        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
