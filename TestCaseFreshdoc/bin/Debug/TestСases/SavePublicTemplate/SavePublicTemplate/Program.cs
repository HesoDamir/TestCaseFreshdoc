using ElementWaiting;
using Logger;
using Login;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Media;
using System.Windows.Forms;

namespace SavePublicTemplate
{
    public class TestCaseSavePublicTemplate : Constants
    {
        string messgNSEE = "Элемент не найден, проверьте корректность локатора.";
        string messgIOE = "Элемент некликабельный, возможно обработчик событий элемента не успел подгрузится.";
        string messgEx = "Что-то пошло не так.";
        string messgDone = "Тест пройден успешно.";
        string captErr = "Ошибка";
        string captDone = "Готово";
        IWebDriver driver;
        MessageBoxButtons btnBoxOK = MessageBoxButtons.OK;
        MessageBoxIcon icBoxErr = MessageBoxIcon.Error;
        MessageBoxIcon icBoxInf = MessageBoxIcon.Information;
        MessageBoxOptions optBoxSN = MessageBoxOptions.ServiceNotification;
        public void SavePT(string selBrw)
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

                AuthFD.AuthUsingBtnEnter(driver);

                driver.WaitShowElement(btnSave);
                driver.FindElement(btnSave).Click();

                driver.WaitShowElement(capSaveDoc);

                driver.FindElement(btnUpLvl).Click();
                System.Threading.Thread.Sleep(1000);

                driver.FindElement(dirMyTem).Click();
                System.Threading.Thread.Sleep(1000);
                try
                {
                    Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='qd-catalog__content']/div/div/div[2][@title='Агентский договор']")).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }
                driver.FindElement(btnUpLvl).Click();

                driver.Navigate().GoToUrl(baseUrl + "/kadry/_procedura-predostavleniya-uchebnogo-otpuska/");

                String baseWind = driver.CurrentWindowHandle;

                System.Threading.Thread.Sleep(1000);
                driver.WaitShowElement(btnPrt);
                driver.FindElement(btnPrt).Click();

                System.Threading.Thread.Sleep(500);
                driver.SwitchTo().Window(baseWind);
                driver.WaitShowElement(capSaveDoc);

                driver.FindElement(btnUpLvl).Click();
                System.Threading.Thread.Sleep(1000);

                driver.FindElement(dirMyTem).Click();
                System.Threading.Thread.Sleep(1000);
                try
                {
                    Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='qd-catalog__content']/div/div/div[2][@title='Предоставление учебного отпуска']")).Displayed);
                }
                catch (NoSuchElementException ex)
                {
                    Log.WriteElNotDisplayed(ex);
                }

                driver.FindElement(btnUpLvl).Click();
                System.Threading.Thread.Sleep(1000);

                driver.Navigate().GoToUrl(baseUrl + "/iski/procedury/semejnye_spory/alimenty/");

                driver.WaitShowElement(btnDwnld);
                driver.FindElement(btnDwnld).Click();

                System.Threading.Thread.Sleep(2000);
                driver.FindElement(btnDwnldDoc).Click();

                driver.WaitShowElement(capSaveDoc);

                driver.FindElement(btnUpLvl).Click();
                System.Threading.Thread.Sleep(1000);

                driver.FindElement(dirMyTem).Click();
                System.Threading.Thread.Sleep(1000);
                try
                {
                    Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='qd-catalog__content']/div/div/div[2][@title='Взыскание алиментов']")).Displayed);
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
            TestCaseSavePublicTemplate tcspt = new TestCaseSavePublicTemplate();
            tcspt.SavePT(selBrw);
        }
    }
}
