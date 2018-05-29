using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;

class EntryPoint
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

        driver.Quit();
        }

    private static void RedMessage(string v)
    {
        
    }

    private static void GreenMessage(string v)
    {
        
    }
}

