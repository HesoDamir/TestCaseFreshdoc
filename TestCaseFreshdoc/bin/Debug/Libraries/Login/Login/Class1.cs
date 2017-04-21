using ElementWaiting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Login
{
    public abstract class Constants
    {
        public static By btnFllScr = By.XPath("//button[@title='На весь экран']");
        public static By btnOpenWinAuth = By.CssSelector("button.DD-button.qd-button_auth.DD-button__action-target > span.DD-button__caption");
        public static By itEmail = By.XPath("//input[@type='email']");
        public static By itPswrd = By.XPath("//input[@type='password']");
        public static By itName = By.XPath("//input[@type='text']");
        public static By itPhone = By.XPath("//input[@type='tel']");
        public static By cboxAgree = By.CssSelector("p.qd-overlay-auth__choose > label.qd-overlay-auth__checkbox");
        public static By btnReg = By.CssSelector("form.qd-overlay-auth__form > button.expand.qd-overlay-auth__button");
        public static By btnCloseWinAuth = By.CssSelector("div.qd-overlay-auth > button.qd-overlay-auth__close");
        public static By btnAuth = By.CssSelector("form.qd-overlay-auth__form > button.expand.qd-overlay-auth__button");
        public static By btnUpLvl = By.XPath("//button[@title ='На уровень выше']");
        public static By dirMyTem = By.XPath("//div[@data-oid ='-19']");
        public static By btnSave = By.XPath("//button[@title='Сохранить']");
        public static By btnPayXRub = By.CssSelector("button.DD-button.qd-carcass-download-form-btnAction_single.DD-button__action-target > span.DD-button__caption");
        public static By doc1ForTestPay = By.XPath("//div[@data-oid ='9611758']");
        public static By rbtnOnlnPay = By.XPath("//div[@class='order-button-pay-button']");
        public static By btnGoToReg = By.CssSelector("div.qd-overlay-auth__content > button.button.expand.secondary.qd-overlay-auth__button");
       
        public string baseUrl = "http://www.freshdoc.ru";
        public By btnAddCmnt = By.CssSelector("div.qd-disc-block.qd-disc-answer > div.qd-block-data > div.qd-disc-block-footer > div.qd-disc-block-toolbar > div.qd-control-button.qd-control-button__button_submit.qd-control-button__action-target.qd-disc-btn-answer");
        public By btnFllScrActv = By.XPath("//button[@title='Свернуть']");
        public By lblQuesLst = By.CssSelector("div.DD-component > div.DD-label.qd-carcass__button--settings.DD-label__action-target");
        public By btnPackDoc = By.CssSelector("div.DD-component > button.DD-button.qd-carcass__button--contents.DD-button__action-target");
        public By lblPayDoc = By.CssSelector("div.DD-component > div.DD-label.qd-carcass__button--tplcost.DD-label__action-target");
        public By btnDwnld = By.CssSelector("div.column.large-12.qd-carcass-block.qd-doc-contents > button.qd-carcass-download-button.qd-carcass-download-button__action-target");
        public By btnDwnldDoc = By.CssSelector("div.qd-carcass-download-form > button.DD-button.qd-carcass-download-form-btnAction.qd-carcass-download-form-btnAction_main.DD-button__action-target >span.DD-button__caption");
        public By itDiscus = By.CssSelector("div.qd-disc-block.qd-disc-answer > div.qd-block-data > div.qd-disc-contents-container");
        public By btnDiscus = By.XPath("//button[@title='Обсудить']");
        public By btnCloseDoc = By.XPath("//button[@title='Закрыть']");
        public By capSaveDoc = By.XPath("//div[@class='qd-tooltip-title']/span[contains(text(), 'Документ сохранен в Личном кабинете')]");
        public static By btnPrt = By.XPath("//button[@title='Печать']");

        public static string lgnEmailProf = "test.qds.27@mail.ru";
        public static string lgnEmailFree = "test.qds.25@mail.ru"; //101
        public static string lgnPswrd = "q123123a";
        public static string lgnName = "Test";
        public static string lgnPhone = "82222222222";
    }
    public class AuthFD : Constants
    {
        public static void AuthUsingBtnEnter(IWebDriver driver)
        {
            driver.FindElement(btnFllScr).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(btnOpenWinAuth).Click();

            System.Threading.Thread.Sleep(500);
            driver.FindElement(itEmail).Clear();
            driver.FindElement(itEmail).SendKeys(lgnEmailProf);

            driver.FindElement(itPswrd).Clear();
            driver.FindElement(itPswrd).SendKeys(lgnPswrd);

            driver.FindElement(btnAuth).Click();
            driver.WaitHideElement(btnAuth);
        }
        public static void AuthUsingDirPA(IWebDriver driver)
        {
            driver.FindElement(btnFllScr).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(btnUpLvl).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(dirMyTem).Click();

            System.Threading.Thread.Sleep(500);
            driver.FindElement(itEmail).Clear();
            driver.FindElement(itEmail).SendKeys(lgnEmailProf);

            driver.FindElement(itPswrd).Clear();
            driver.FindElement(itPswrd).SendKeys(lgnPswrd);

            driver.FindElement(btnAuth).Click();
            driver.WaitHideElement(btnAuth);
        }
        public static void AuthUsingPublicDoc(IWebDriver driver)
        {
            driver.FindElement(btnFllScr).Click();

            System.Threading.Thread.Sleep(1000);
            driver.WaitShowElement(btnSave);
            driver.FindElement(btnSave).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(btnPayXRub).Click();

            System.Threading.Thread.Sleep(500);
            driver.FindElement(itEmail).Clear();
            driver.FindElement(itEmail).SendKeys(lgnEmailProf);

            driver.FindElement(itPswrd).Clear();
            driver.FindElement(itPswrd).SendKeys(lgnPswrd);

            driver.FindElement(btnAuth).Click();
            driver.WaitHideElement(btnAuth);
        }
        public static void AuthForPayDO(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.freshdoc.ru/?oid=9609188");
            driver.FindElement(btnFllScr).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(btnOpenWinAuth).Click();

            System.Threading.Thread.Sleep(500);
            driver.FindElement(itEmail).Clear();
            driver.FindElement(itEmail).SendKeys(lgnEmailFree);

            driver.FindElement(itPswrd).Clear();
            driver.FindElement(itPswrd).SendKeys(lgnPswrd);

            driver.FindElement(btnAuth).Click();
            driver.WaitHideElement(btnAuth);

            System.Threading.Thread.Sleep(2000);
            driver.FindElement(doc1ForTestPay).Click();

            driver.WaitShowElement(btnSave);
            driver.FindElement(btnSave).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(btnPayXRub).Click();

            driver.WaitShowElement(rbtnOnlnPay);
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(rbtnOnlnPay).Click();
        }
    }

    public class RegFD : Constants
    {
        private static int seed = Environment.TickCount;
        private static ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>(() =>
        new Random(Interlocked.Increment(ref seed))
        );
        public static Random GetThreadRandom()
        {
            return randomWrapper.Value;
        }
        public static void RegUsingBtnEnter(IWebDriver driver)
        {
            driver.FindElement(btnFllScr).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(btnOpenWinAuth).Click();

            System.Threading.Thread.Sleep(500);
            driver.FindElement(btnGoToReg).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(itEmail).Clear();
            driver.FindElement(itEmail).SendKeys("test.qds." + seed + "@mail.ru");

            driver.FindElement(itName).Clear();
            driver.FindElement(itName).SendKeys(lgnName);

            driver.FindElement(itPhone).Clear();
            driver.FindElement(itPhone).SendKeys(lgnPhone);

            driver.FindElement(cboxAgree).Click();

            driver.FindElement(btnReg).Click();
            driver.WaitHideElement(btnReg);

            System.Threading.Thread.Sleep(500);
            driver.FindElement(btnCloseWinAuth).Click();
        }
        public static void RegUsingDirPA(IWebDriver driver)
        {
            driver.FindElement(btnFllScr).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(btnUpLvl).Click();

            driver.WaitShowElement(dirMyTem);
            driver.FindElement(dirMyTem).Click();

            System.Threading.Thread.Sleep(500);
            driver.FindElement(btnGoToReg).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(itEmail).Clear();
            driver.FindElement(itEmail).SendKeys("test.qds." + seed + "@mail.ru");

            driver.FindElement(itName).Clear();
            driver.FindElement(itName).SendKeys(lgnName);

            driver.FindElement(itPhone).Clear();
            driver.FindElement(itPhone).SendKeys(lgnPhone);

            driver.FindElement(cboxAgree).Click();

            driver.FindElement(btnReg).Click();
            driver.WaitHideElement(btnReg);

            System.Threading.Thread.Sleep(500);
            driver.FindElement(btnCloseWinAuth).Click();
        }
        public static void RegUsingPublicDoc(IWebDriver driver)
        {
            driver.FindElement(btnFllScr).Click();

            System.Threading.Thread.Sleep(1000);
            driver.WaitShowElement(btnSave);
            driver.FindElement(btnSave).Click();

            driver.WaitShowElement(btnPayXRub);
            driver.FindElement(btnPayXRub).Click();

            System.Threading.Thread.Sleep(500);
            driver.FindElement(btnGoToReg).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(itEmail).Clear();
            driver.FindElement(itEmail).SendKeys("test.qds." + seed + "@mail.ru");

            driver.FindElement(itName).Clear();
            driver.FindElement(itName).SendKeys(lgnName);

            driver.FindElement(itPhone).Clear();
            driver.FindElement(itPhone).SendKeys(lgnPhone);

            driver.FindElement(cboxAgree).Click();

            driver.FindElement(btnReg).Click();
            driver.WaitHideElement(btnReg);

            System.Threading.Thread.Sleep(500);
            driver.FindElement(btnCloseWinAuth).Click();
        }
        public static void RegForPayDO(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.freshdoc.ru/?oid=9609188");
            driver.FindElement(btnFllScr).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(doc1ForTestPay).Click();

            driver.WaitShowElement(btnPrt);
            driver.FindElement(btnPrt).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(btnPayXRub).Click();

            System.Threading.Thread.Sleep(500);
            driver.FindElement(btnGoToReg).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(itEmail).Clear();
            driver.FindElement(itEmail).SendKeys("test.qds." + seed + "@mail.ru");

            driver.FindElement(itName).Clear();
            driver.FindElement(itName).SendKeys(lgnName);

            driver.FindElement(itPhone).Clear();
            driver.FindElement(itPhone).SendKeys(lgnPhone);

            driver.FindElement(cboxAgree).Click();

            driver.FindElement(btnReg).Click();

            driver.WaitHideElement(itEmail);

            driver.WaitShowElement(btnCloseWinAuth);
            driver.FindElement(btnCloseWinAuth).Click();

            driver.WaitShowElement(rbtnOnlnPay);
            System.Threading.Thread.Sleep(1500);
            driver.FindElement(rbtnOnlnPay).Click();
        }
    }
}