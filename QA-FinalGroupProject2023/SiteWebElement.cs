using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FinalGroupProject2023
{
    class SiteWebElement
    {
        public static IWebElement Username(IWebDriver driver)
        {
            IWebElement txtLoginUsername = driver.FindElement(By.Id("username"));
            return txtLoginUsername;
        }
        
        public static IWebElement Password(IWebDriver driver)
        {
            IWebElement txtLoginPassword = driver.FindElement(By.Id("password"));
            return txtLoginPassword;
        }
        
        public static IWebElement LoginButton(IWebDriver driver)
        {
            IWebElement btnLogin = driver.FindElement(By.Id("button"));
            return btnLogin;
        }
        
        public static IWebElement EmailLink(IWebDriver driver)
        {
            IWebElement lnkEmail = driver.FindElement(By.CssSelector("p > a[href*='mailto:']"));
            return lnkEmail;
        }
        
        public static IWebElement Logo(IWebDriver driver)
        {
            IWebElement imgLogo = driver.FindElement(By.CssSelector("a.navbar-brand > img.logo"));
            return imgLogo;
        }

        public static IWebElement ContactUsEmailLink(IWebDriver driver)
        {
            IWebElement contactUsEmailLink = driver.FindElement(By.CssSelector("a[href='mailto:realemail@gmail.com']"));
            return contactUsEmailLink;
        }

        public static IWebElement SignUpLink(IWebDriver driver)
        {
            IWebElement signUpLink = driver.FindElement(By.CssSelector("a[href='signup.php']"));
            return signUpLink;
        }

        public static IWebElement Navbar(IWebDriver driver)
        {
            IWebElement navbar = driver.FindElement(By.CssSelector(".navbar"));
            return navbar;
        }

        public static IWebElement ScreenNameLabel(IWebDriver driver)
        {
            IWebElement screenNameLabel = driver.FindElement(By.CssSelector("label[for='username']"));
            return screenNameLabel;
        }

        public static IWebElement PasswordLabel(IWebDriver driver)
        {
            IWebElement passwordLabel = driver.FindElement(By.CssSelector("label[for='password']"));
            return passwordLabel;
        }



        //*****************************************
        public static IWebElement DontHaveAccountLink(IWebDriver driver)
        {
            IWebElement dontHaveAccountLink = driver.FindElement(By.LinkText("Click Here"));
            return dontHaveAccountLink;
        }

        public static IWebElement LinkSignup(IWebDriver driver)
        {
            IWebElement linkSignup = driver.FindElement(By.LinkText("Click Here"));
            return linkSignup;
        }
        //*****************************************



        //for successfull login: *******************************************************************************
        public static IWebElement divLoginSuccess(IWebDriver driver)
        {
            IWebElement divLoginSuccess = driver.FindElement(By.Id(""));//*******************************************************************************
            return divLoginSuccess;
        }
    }
}
