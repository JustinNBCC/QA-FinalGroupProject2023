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


            /*

            //-----------------------------------------------------------------------Tag Test Start

            // Run the tag test
            bool TagTest001 = SiteTest.TagTest001(driver);

            if (TagTest001)
            {
                Console.WriteLine("TagTest001 - Title Test: Passed!");
            }
            else
            {
                Console.WriteLine("TagTest001 - Title Test: Failled...");
            }
            
            // Run the tag test
            bool TagTest002 = SiteTest.TagTest002(driver);

            if (TagTest002)
            {
                Console.WriteLine("TagTest002 - Logo Test Success: Passed!");
            }
            else
            {
                Console.WriteLine("TagTest002 - Logo Test Success: Failled...");
            }
            
             // Run the tag test
            bool TagTest003 = SiteTest.TagTest003(driver);

            if (TagTest003)
            {
                Console.WriteLine("TagTest003 - Login page Success: Passed!");
            }
            else
            {
                Console.WriteLine("TagTest003 - Login page Success: Failled...");
            }

            // Run the tag test
            bool TagTest004 = SiteTest.TagTest004(driver);

            if (TagTest004)
            {
                Console.WriteLine("TagTest004 - Login page Success: Passed!");
            }
            else
            {
                Console.WriteLine("TagTest004 - Login page Success: Failled...");
            }

            // Run the tag test
            bool TagTest005 = SiteTest.TagTest005(driver);

            if (TagTest005)
            {
                Console.WriteLine("TagTest005 - Login page Success: Passed!");
            }
            else
            {
                Console.WriteLine("TagTest005 - Login page Success: Failled...");
            }

            // Run the tag test
            bool TagTest006 = SiteTest.TagTest006(driver);

            if (TagTest006)
            {
                Console.WriteLine("TagTest006 - Login page Success: Passed!");
            }
            else
            {
                Console.WriteLine("TagTest006 - Login page Success: Failled...");
            }

            // Run the tag test
            bool TagTest007 = SiteTest.TagTest007(driver);

            if (TagTest007)
            {
                Console.WriteLine("TagTest007 - Login page Success: Passed!");
            }
            else
            {
                Console.WriteLine("TagTest007 - Login page Success: Failled...");
            }

            // Run the tag test
            bool TagTest008 = SiteTest.TagTest008(driver);

            if (TagTest008)
            {
                Console.WriteLine("TagTest008 - Login page Success: Passed!");
            }
            else
            {
                Console.WriteLine("TagTest008 - Login page Success: Failled...");
            }
            
            // Run the tag test
            bool TagTest00 = SiteTest.TagTest00(driver);

            if (LogTest00)
            {
                Console.WriteLine("TagTest00 - Login page Success: Passed!");
            }
            else
            {
                Console.WriteLine("TagTest00 - Login page Success: Failled...");
            }

            // Run the tag test
            bool TagTest00 = SiteTest.TagTest00(driver);

            if (LogTest00)
            {
                Console.WriteLine("TagTest00 - Login page Success: Passed!");
            }
            else
            {
                Console.WriteLine("TagTest00 - Login page Success: Failled...");
            }
            */



            //-----------------------------------------------------------------------Link Test Start



            //// Run the Link test
            //bool LnkTest001 = SiteTest.LnkTest001(driver);

            //if (LnkTest001)
            //{
            //    Console.WriteLine("LnkTest001 - Signup Link Test: Passed!");
            //}
            //else
            //{
            //    Console.WriteLine("LnkTest001 - Signup Link Test: Failled...");
            //}



            // Run the Link test
            bool LnkTest002 = SiteTest.LnkTest002(driver);

            if (LnkTest002)
            {
                Console.WriteLine("LnkTest002 - Email Link Test: Passed!");
            }
            else
            {
                Console.WriteLine("LnkTest002 - Email Link Test: Failled...");
            }

            //// Run the Link test
            //bool LnkTest003 = SiteTest.LnkTest003(driver);

            //if (LnkTest003)
            //{
            //    Console.WriteLine("LnkTest003 - Logo to index Link Test: Passed!");
            //}
            //else
            //{
            //    Console.WriteLine("LnkTest003 - Logo to index Link Test: Failled...");
            //}



            /*
            //-----------------------------------------------------------------------Log Test Start

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

            // Run the login test
            bool LogTest002 = SiteTest.LogTest002(driver);

            if (LogTest002)
            {
                Console.WriteLine("LogTest002 - Login page Success: Passed!");
            }
            else
            {
                Console.WriteLine("LogTest002 - Login page Success: Failled...");
            }

            */

            // Short delay so we can see reults.
            Thread.Sleep(10000);

            driver.Quit();

        }
    }
}
