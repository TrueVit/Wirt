using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Wirt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test!!!");
            Console.WriteLine("FromMainToNotebook");
            Console.WriteLine("FromLaptopToPC");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://virtonomica.ru";
            IWebElement elem = driver.FindElement(By.ClassName("dialog_login_opener"));
            elem.Click();
            //string page_text = driver.PageSource;
            //Console.WriteLine(page_text);
            //driver.Quit();
        }
    }
}
