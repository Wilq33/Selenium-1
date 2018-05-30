using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Paths
{
    class Paths
    {
        static void Main()
        {
            string url = "http://testing.todvachev.com/selectors/css-path/";
            //Incorrect selector to check if RedMessage is displayed
            //string cssPathSelector = "#post-108 > div > figure > imga"; 
            string cssPathSelector = "#post-108 > div > figure > img";
            string xPathSelector = "//*[@id=\"post-108\"]/div/figure/img";

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);


            //Elements
            IWebElement cssPathElement;
            IWebElement xPathElement;

            try
            {
                cssPathElement = driver.FindElement(By.CssSelector(cssPathSelector));
                if (cssPathElement.Displayed)
                {
                    GreenMessage("I can see CssPath");
                }
                            }
            catch(NoSuchElementException)
            {
                RedMessage("I don't see CssPath");
            }

            try
            {
                xPathElement = driver.FindElement(By.XPath(xPathSelector));
                if (xPathElement.Displayed)
                {
                    GreenMessage("I can see XPath");
                }
            }
            catch (NoSuchElementException)
            {
                GreenMessage("I can see XPath");
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
