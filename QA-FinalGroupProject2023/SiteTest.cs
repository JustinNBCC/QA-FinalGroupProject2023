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

        public bool VerifyLogoOnThePage()
        {
            return SiteWebElement.Logo(driver).Displayed;
        }


        public bool VerifyPageTitle()
        {
            string expectedTitle = "Login - Bitter";
            string actualTitle = driver.Title;
            return expectedTitle == actualTitle;
        }


        
        public static void VerifyEmailLink(IWebDriver driver){

            SiteWebElement.EmailLink(driver).Click();
            string expectedEmail = "realemail@gmail.com";
            string actualEmail = driver.FindElement(By.LinkText(expectedEmail)).Text;
            return expectedEmail == actualEmail;

        }



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
            try
            {
                ValidLogin(driver, "ValidLogin", "ValidPWD");

                IWebElement divSuc = SiteWebElement.divLoginSuccess(driver);

                string strSuc = divSuc.Text;
                if (strSuc.Contains(""))
                {
                    return true;
                }else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;

            }
        }

        public static bool Test002(IWebDriver driver) {

            
            try
            {
                InvalidLogin(driver, "inValidLogin", "inValidPWD");

                IWebElement divSuc = SiteWebElement.divLoginSuccess(driver);

                string strSuc = divSuc.Text;
                if (strSuc.Contains(""))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;

            }
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
