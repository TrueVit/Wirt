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
            driver.Manage().Window.Maximize();
            driver.Url = "https://virtonomica.ru";
            //driver.Manage().Window.Maximize();
            IWebElement elem = driver.FindElement(By.ClassName("dialog_login_opener"));
            elem.Click();
            driver.FindElement(By.Id("mail_or_login_field")).SendKeys("truevit");
            driver.FindElement(By.XPath("//*[@id=\"old\"]/form/label[2]/input")).SendKeys("wo7Kg0oB");
            driver.FindElement(By.XPath("//*[@id=\"old\"]/form/input[1]")).Click();
            driver.Url = "https://virtonomica.ru/vera/main/management_action/4785020/investigations/technologies";
            IWebElement subelem;
            foreach (IWebElement row in driver.FindElements(By.ClassName("tech_row")))
            {
                try
                {
                    subelem = row.FindElement(By.ClassName("tech_title_cell"));
                }
                catch
                {
                    continue;
                }
                Console.Write(subelem.Text.Split('\r')[0] + ":   ");
                var TechLevel = 1;
                foreach (IWebElement tech in row.FindElements(By.ClassName("tech_cell")))
                {
                    try
                    {
                        subelem = tech.FindElement(By.TagName("a"));
                    }
                    catch
                    {
                        continue;
                    }
                    TechLevel = Convert.ToInt32(subelem.Text,10);
                    break;
                }
                Console.WriteLine(TechLevel);
            }

            //driver.Url = "https://virtonomica.ru/vera/main/company/view/4785020/unit_list";
            //driver.FindElement(By.XPath("//*[@id=\"mainContent\"]/table/tbody/tr[1]/td/a[3]")).Click();
            
            //string page_text = driver.PageSource;
            //Console.WriteLine(page_text);
            Console.ReadLine();
            driver.Quit();
        }
    }
}
