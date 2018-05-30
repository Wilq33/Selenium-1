using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Test
{
    static void Main()
    {
        //tested urls
        string urlName = "http://testing.todvachev.com/selectors/name/";
        string urlSelectable = "http://demoqa.com/selectable/";
        string urlMenu = "http://demoqa.com/menu/";

        //Selectors
        string nameSelector = "myName";
        string idSelector = "nav_menu-2";
        string cssPathSelector = "#post-41 > header > h1";
        string xPathSelector = "//*[@id=\"breadcrumbs\"]/li[1]/a";

        IWebDriver driver = new ChromeDriver();


        //Elements
        IWebElement elementName;
        IWebElement elementId;
        IWebElement elementCssPath;
        IWebElement elementXPath;


        driver.Navigate().GoToUrl(urlName);

        try
        {
            elementName = driver.FindElement(By.Name(nameSelector));

            if (elementName.Displayed)
            {
                GreenMessage("I can see the name element");
            }

        }
        catch (NoSuchElementException)
        {
            RedMessage("I don't see the name element");
        }

        driver.Navigate().GoToUrl(urlSelectable);

        try
        {
            elementId = driver.FindElement(By.Id(idSelector));

            if (elementId.Displayed)
            {
                GreenMessage("I can see the ID element");
                Console.WriteLine(elementId.Text);
            }
           
        }
        catch (NoSuchElementException)
        {
            RedMessage("I don't see the ID element");
        }

        Thread.Sleep(1000);

        try
        {
            elementCssPath = driver.FindElement(By.CssSelector(cssPathSelector));

            if (elementCssPath.Displayed)
            {
                GreenMessage("I can see the CssPath element");
                Console.WriteLine(elementCssPath.Text);
            }

        }
        catch (NoSuchElementException)
        {
            RedMessage("I don't see the CssPath element");
        }

        driver.Navigate().GoToUrl(urlMenu);

        try
        {
            elementXPath = driver.FindElement(By.XPath(xPathSelector));

            if (elementXPath.Displayed)
            {
                GreenMessage("I can see the XPath element");
                Console.WriteLine(elementXPath.Text);
            }

        }
        catch (NoSuchElementException)
        {
            RedMessage("I don't see the XPath element");
        }

        driver.Quit();
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

