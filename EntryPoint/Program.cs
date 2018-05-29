using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Threading;

class NameSelector
    {

    //Checking if element myName exists
        static void Main()
        {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");

        IWebElement element = driver.FindElement(By.Name("myName"));

        if (element.Displayed)
          {
            GreenMessage("Yes, I can see the element");
            //Debug.WriteLine("Yes, I can see the element");
            //System.Console.WriteLine("Yes, I can see the element");
        }
        else
          {
            RedMessage("I don't see the element");
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

