using System;
using Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace ElementWaiting
{
    public static class WebDriverExtensions
    {
        public static void WaitHideElement(this IWebDriver driver, By iClassName)
        {
            WebDriverWait iWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            iWait.Until(ExpectedConditions.InvisibilityOfElementLocated(iClassName));
        }
        public static void WaitShowElement(this IWebDriver driver, By iClassName)
        {
            WebDriverWait iWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            iWait.Until(ExpectedConditions.ElementIsVisible(iClassName));
        }
    }
}
