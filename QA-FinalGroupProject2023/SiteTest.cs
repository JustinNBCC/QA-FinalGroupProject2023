using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FinalGroupProject2023
{
    class SiteTest
    {
        public static void ValidLogin(IWebDriver driver, string strUsername, string strPassword){
            
            driver.Url = "/site6/login.php";
            // Get elements
            IWebElement txtUsername = SiteWebElement.Username(driver);
            IWebElement txtPassword = SiteWebElement.Password(driver);
            IWebElement btnLogin = SiteWebElement.LoginButton(driver);

            // Enter valid username and password
            txtUsername.SendKeys(strUsername);
            txtPassword.SendKeys(strPassword);

            // Click login button
            btnLogin.Click();
            driver.Quit();

        }

        

        public static void InvalidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url = "/site6/login.php";
            // Get elements
            IWebElement txtUsername = SiteWebElement.Username(driver);
            IWebElement txtPassword = SiteWebElement.Password(driver);
            IWebElement btnLogin = SiteWebElement.LoginButton(driver);

            // Enter valid username and password
            txtUsername.SendKeys(strUsername);
            txtPassword.SendKeys(strPassword);

            // Click login button
            btnLogin.Click();
            driver.Quit();

        }



        public static bool Test001(IWebDriver driver){

            ValidLogin(driver, "ValidLogin", "ValidPWD");
            
            return true;
        }

        public static bool Test002(IWebDriver driver) {

            InvalidLogin(driver, "inValidLogin", "inValidPWD");

            return true;
        }


        /*
        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }



        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }



        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }



        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }



        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }



        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }



        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }



        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }



        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }



        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }



        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }



        public static bool ValidLogin(IWebDriver driver, string strUsername, string strPassword){

            driver.Url("/site6/login.php");


        }*/
    }
}
