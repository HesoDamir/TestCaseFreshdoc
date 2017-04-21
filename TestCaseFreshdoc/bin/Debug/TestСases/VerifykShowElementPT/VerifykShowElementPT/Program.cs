using ElementWaiting;
using Logger;
using Login;
using NUnit.Framework;
using System;
using System.Media;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace VerifykShowElementPT
{
    public class TestCaseVerifykShowElementPT : Constants
    {
        string messgNSEE = "Элемент не найден, проверьте корректность локатора.";
        string messgIOE = "Элемент некликабельный, возможно обработчик событий элемента не успел подгрузится.";
        string messgEx = "Что-то пошло не так.";
        string messgDone = "Тест пройден успешно. Чтобы убедиться, что все элементы присутствуют на странице передите к логам.";
        string captErr = "Ошибка";
        string captDone = "Готово";
        IWebDriver driver;
        MessageBoxButtons btnBoxOK = MessageBoxButtons.OK;
        MessageBoxIcon icBoxErr = MessageBoxIcon.Error;
        MessageBoxIcon icBoxInf = MessageBoxIcon.Information;
        MessageBoxOptions optBoxSN = MessageBoxOptions.ServiceNotification;
        public void VerifykShowEl(string selBrw)
        {
            try
            {
                switch (selBrw)
                {
                    case "Chrome":
                        driver = new ChromeDriver();
                        break;
                    case "Firefox":
                        System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", "geckodriver.exe");
                        driver = new FirefoxDriver();
                        break;
                    case "IE":
                        driver = new InternetExplorerDriver();
                        break;
                }

                driver.Navigate().GoToUrl(baseUrl + "/dogovor/agentskie_dogovory/_dogovor_agentskiy/");
                System.Threading.Thread.Sleep(1000);
                try
                {
                    Assert.IsTrue(driver.FindElement(btnCloseDoc).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnSave).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnPrt).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnDiscus).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnOpenWinAuth).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnFllScr).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(lblQuesLst).Displayed); 
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnPackDoc).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(lblPayDoc).Displayed); 
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnDwnld).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(itDiscus).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnAddCmnt).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }

                AuthFD.AuthUsingBtnEnter(driver);
                driver.WaitShowElement(lblQuesLst);
                System.Threading.Thread.Sleep(500);

                try
                {
                    Assert.IsTrue(driver.FindElement(btnCloseDoc).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnSave).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnPrt).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnDiscus).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnOpenWinAuth).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnFllScrActv).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(lblQuesLst).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnPackDoc).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnDwnld).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(itDiscus).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                try
                {
                    Assert.IsTrue(driver.FindElement(btnAddCmnt).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(messgDone, captDone, btnBoxOK, icBoxInf, 0, optBoxSN);
                Console.ReadKey();
                driver.Quit();
            }
            catch (NoSuchElementException ex)
            {
                Log.Write(ex);
                Log.TakeScreenshot(driver);
                SystemSounds.Hand.Play();
                MessageBox.Show(messgNSEE, captErr, btnBoxOK, icBoxErr, 0, optBoxSN);
            }
            catch (InvalidOperationException ex)
            {
                Log.Write(ex);
                Log.TakeScreenshot(driver);
                SystemSounds.Hand.Play();
                MessageBox.Show(messgIOE, captErr, btnBoxOK, icBoxErr, 0, optBoxSN);
            }
            catch (Exception ex)
            {
                Log.Write(ex);
                Log.TakeScreenshot(driver);
                SystemSounds.Hand.Play();
                MessageBox.Show(messgEx, captErr, btnBoxOK, icBoxErr, 0, optBoxSN);
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            string selBrw = string.Empty;
            if (args.Length == 1)
            {
                selBrw = args[0];
            }
            else
            {
                selBrw = "Chrome";
            }
            TestCaseVerifykShowElementPT tcvsept = new TestCaseVerifykShowElementPT();
            tcvsept.VerifykShowEl(selBrw);
        }
    }
}