using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Threading;

class Test
{
    static void Main()
    {
        string url = "http://demoqa.com/selectable/";

        //Selectors
        string nameSelector = "";
        string idSelector = "nav_menu-2";
        string cssPathSelector = "#post-41 > header > h1";
        string xPathSelector = "";

        IWebDriver driver = new ChromeDriver();


        //Elements
        //IWebElement elementName = driver.FindElement(By.Name(nameSelector));
        IWebElement elementId;
        IWebElement elementCssPath;
        //IWebElement elementXPath = driver.FindElement(By.XPath(xPathSelector));

        driver.Navigate().GoToUrl(url);

        try
        {
            elementId = driver.FindElement(By.Id(idSelector));

            if (elementId.Displayed)
            {
                GreenMessage("I can see the ID element");
                Debug.WriteLine(elementId.Text);
            }
           
        }
        catch (NoSuchElementException)
        {
            RedMessage("I don't see the ID element");
        }

        Thread.Sleep(1000);

        try
        {
            elementCssPath = driver.FindElement(By.Id(cssPathSelector));

            if (elementCssPath.Displayed)
            {
                GreenMessage("I can see the ID element");
                Console.WriteLine(elementCssPath.Text);
            }

        }
        catch (NoSuchElementException)
        {
            RedMessage("I don't see the ID element");
        }


    }

    
    

    static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }



}

