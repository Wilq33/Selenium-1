using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace IdSelector
{
    class Program
    {

        //Navigating to website
        static void Main()
        {
            string idSelector = "http://testing.todvachev.com/selectors/id/";
            string ID = "testImage";

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(idSelector);

            IWebElement element = driver.FindElement(By.Id(ID));

            if(element.Displayed)
            {
                GreenMessage("Yes, I can see the image");
            }
            else
            {
                RedMessage("I don't see the image");
            }

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
