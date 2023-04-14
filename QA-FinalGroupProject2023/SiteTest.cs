﻿using NUnit.Framework;
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

        //public bool VerifyLogoOnThePage()
        //{
        //    return SiteWebElement.Logo(driver).Displayed;
        //}


        //public bool VerifyPageTitle()
        //{
        //    string expectedTitle = "Login - Bitter";
        //    string actualTitle = driver.Title;
        //    return expectedTitle == actualTitle;
        //}



        //public static void VerifyEmailLink(IWebDriver driver){

        //    SiteWebElement.EmailLink(driver).Click();
        //    string expectedEmail = "realemail@gmail.com";
        //    string actualEmail = driver.FindElement(By.LinkText(expectedEmail)).Text;
        //    //return expectedEmail == actualEmail;

        //}

        //Display tag Checks:

        //check page title
        public static bool TagTest001(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://remote.faedine.com/site6/Login.php";

                // Check the page title
                if (driver.Title.Equals("Login - Bitter"))
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
        }//end title method


        //check if logo is displayed 
        public static bool TagTest002(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://remote.faedine.com/site6/Login.php";

                // Find the logo image element
                //IWebElement logoImage = driver.FindElement(By.CssSelector(".logo"));
                IWebElement logoImage = SiteWebElement.Logo(driver);

                // Verify that the logo image exists and is displayed
                bool isDisplayed = logoImage.Displayed;

                return isDisplayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }//end logo method



        public static bool TagTest003(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://remote.faedine.com/site6/Login.php";
                // Get Element
                IWebElement navbar = driver.FindElement(By.CssSelector(".navbar"));

                // bool to change to true if displayed 
                bool navbarExistsAndIsDisplayed = false;

                return navbarExistsAndIsDisplayed = navbar.Displayed;

            }
            catch (Exception ex)
            {
                return false;
            }
        }//end logo method


        //username lable test
        public static bool TagTest004(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://remote.faedine.com/site6/Login.php";

                // Get Element
                IWebElement screenNameLabel = driver.FindElement(By.CssSelector("label[for='username']"));

                // Verify that the label exists and is displayed
                try
                {
                    Assert.That(screenNameLabel.Displayed, Is.True);
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }//end username lable method



        //password lable test
        public static bool TagTest005(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://remote.faedine.com/site6/Login.php";

                // Find the password label
                IWebElement passwordLabel = driver.FindElement(By.CssSelector("label[for='password']"));

                // Check that the label is displayed
                bool isDisplayed = passwordLabel.Displayed;

                return isDisplayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }//end password lable method 




        //username input test
        public static bool TagTest006(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://remote.faedine.com/site6/Login.php";

                //Get Element
                IWebElement inputField = SiteWebElement.Username(driver);

                //Check if displayed 
                return inputField.Displayed;

            }
            catch (Exception ex)
            {
                return false;
            }
        }



        //password input test
        public static bool TagTest007(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://remote.faedine.com/site6/Login.php";

                //Get Element
                IWebElement inputField = SiteWebElement.Password(driver);

                //Check if displayed 
                return inputField.Displayed;

            }
            catch (Exception ex)
            {
                return false;
            }
        }



        // Verify that the "Login" button exists and is displayed
        public static bool TagTest008(IWebDriver driver)
        {
            try
            {
                //Get Element
                IWebElement loginButton = SiteWebElement.LoginButton(driver);

                //check if displayed
                return loginButton.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Verify that the "Don't have a Bitter Account?" link exists
        public static bool TagTest009(IWebDriver driver)
        {
            try
            {
                //Get Element
                IWebElement dontHaveAccountLink = driver.FindElement(By.LinkText("Click Here"));
                
                //Check if displayed
                return dontHaveAccountLink.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //Link Tests:

        //signup link test
        public static bool LnkTest001(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://remote.faedine.com/site6/Login.php";

                //Get Element
                IWebElement linkSignup = driver.FindElement(By.LinkText("Click Here"));

                linkSignup.Click();

                //Check if page changed 
                if (driver.Url.Contains("signup.php"))
                {
                    driver.Quit();
                    return true;
                }
                else
                {
                    driver.Quit();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }//end signup link method



        //email link test
        public static bool LnkTest002(IWebDriver driver)
        {
            try
            {
                //Get Element
                IWebElement emailLink = driver.FindElement(By.XPath("//a[contains(@href,'mailto:')]"));

                //create both emails for comparison
                string expectedEmail = "realemail@gmail.com";
                string actualEmail = emailLink.Text;

                // Click the email address link
                emailLink.Click();
                try
                {
                    // Verify that it opens up the default email application
                    Assert.IsTrue(driver.Url.StartsWith("mailto:"), "Failed to open default email application");

                    // Verify that the email address is correct
                    Assert.AreEqual(expectedEmail, actualEmail, "Email address is incorrect");
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                
                Assert.Fail("Test failed: " + ex.Message);
                return false;
            }
        }//end email link method 



        //Login test

        //default login steps:
        public static void Login(IWebDriver driver, string strUsername, string strPassword){
            
            driver.Url = "http://remote.faedine.com/site6/Login.php";
            // Get elements
            IWebElement txtUsername = SiteWebElement.Username(driver);
            IWebElement txtPassword = SiteWebElement.Password(driver);
            IWebElement btnLogin = SiteWebElement.LoginButton(driver);

            // Enter valid username and password
            txtUsername.SendKeys(strUsername);
            txtPassword.SendKeys(strPassword);

            // Click login button
            btnLogin.Click();

        }//end login method 

    
        //Login Tests:
        public static bool LogTest001(IWebDriver driver){
            try
            {
                //try login-in
                Login(driver, "ValidLogin", "ValidPWD");

                //Get Elements
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

        //public static bool Test002(IWebDriver driver) {
        //    try
        //    {
        //        Login(driver, "inValidLogin", "inValidPWD");

        //        IWebElement divSuc = SiteWebElement.divLoginSuccess(driver);

        //        string strSuc = divSuc.Text;
        //        if (strSuc.Contains(""))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        return false;

        //    }
        //}

        //Invalid Login Test
        public static bool LogTest002(IWebDriver driver)
        {
            try
            {
                Login(driver, "inValidLogin", "inValidPWD");
                try
                {
                    // Verify that an error alert box message appears
                    IAlert alert = driver.SwitchTo().Alert();
                    string errorMessage = alert.Text;
                    Assert.That(errorMessage, Is.EqualTo("User name and password are not matched. Please try again!"));
                    alert.Accept();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                return false;

            }
        }//end invalid login test


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
