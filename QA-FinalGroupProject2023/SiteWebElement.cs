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
        
    }
}
