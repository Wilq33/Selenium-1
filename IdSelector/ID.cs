using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace IdSelector
{
    class ID
    {

        //Navigating to website
        static void Main()
        {
            string idSelector = "http://testing.todvachev.com/selectors/id/";
            string ID = "testImagee";

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(idSelector);

            IWebElement element = driver.FindElement(By.Id(ID));

            Console.WriteLine(element.Text);

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
