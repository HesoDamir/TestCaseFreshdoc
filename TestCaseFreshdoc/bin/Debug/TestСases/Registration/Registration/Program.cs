using ElementWaiting;
using Logger;
using Login;
using System;
using System.Media;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace Registration
{
    public class TestCaseRegistration : Constants
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
        public void UserReg(string selBrw)
        {
            try
            {
                switch (selBrw)
                {
                    case "Chrome":
                        driver = new ChromeDriver(@"..\..\..\..\..\BrowserDrivers\");
                        break;
                    case "Firefox":
                        System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", "geckodriver.exe");
                        driver = new FirefoxDriver();
                        break;
                    case "IE":
                        driver = new InternetExplorerDriver();
                        break;
                }
                driver.Navigate().GoToUrl(baseUrl);
                RegFD.RegUsingBtnEnter(driver);
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
            TestCaseRegistration tcr = new TestCaseRegistration();
            tcr.UserReg(selBrw);
        }
    }
}