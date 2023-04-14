using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QA_FinalGroupProject2023
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver(@"C:\Selenium");

            // Run the login test
            bool LogTest001 = SiteTest.LogTest001(driver);

            if (LogTest001)
            {
                Console.WriteLine("LogTest001 - Login page Success: Passed!");
            }
            else
            {
                Console.WriteLine("LogTest001 - Login page Success: Failled...");
            }


            // Short delay so we can see reults.
            Thread.Sleep(10000);

            driver.Quit();

        }
    }
}
