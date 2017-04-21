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


namespace OpeningTemplates
{
    public class TestCaseOpeningTemplates : Constants
    {
        string messgNSEE = "Элемент не найден, проверьте корректность локатора.";
        string messgIOE = "Элемент некликабельный, возможно обработчик событий элемента не успел подгрузиться.";
        string messgEx = "Что-то пошло не так.";
        string messgDone = "Тест пройден успешно.";
        string captErr = "Ошибка";
        string captDone = "Готово";
        IWebDriver driver;
        MessageBoxButtons btnBoxOK = MessageBoxButtons.OK;
        MessageBoxIcon icBoxErr = MessageBoxIcon.Error;
        MessageBoxIcon icBoxInf = MessageBoxIcon.Information;
        MessageBoxOptions optBoxSN = MessageBoxOptions.ServiceNotification;
        public void OpenTemp(string selBrw)
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

                driver.Navigate().GoToUrl(baseUrl);
                AuthFD.AuthUsingBtnEnter(driver);
                try
                {
                    driver.Navigate().GoToUrl(baseUrl + "/dogovor/agenskie_dogovory/_dogovor_agentskiy/");
                    driver.WaitShowElement(btnSave);
                }
                catch
                {

                }
                driver.Navigate().GoToUrl(baseUrl + "/dogovor/agentskie_dogovory/_agentskiy_dogovor_na_priobretenie_nedvijimosti/");
                driver.WaitShowElement(btnSave);

                driver.Navigate().GoToUrl(baseUrl + "/dogovor/agentskie_dogovory/_agentskiy_dogovor_na_priobretenie_tovara/");
                driver.WaitShowElement(btnSave);

                driver.Navigate().GoToUrl(baseUrl + "/dogovor/agentskie_dogovory/_agentskiy_dogovor_na_priobretenie_uslug/");
                driver.WaitShowElement(btnSave);

                driver.Navigate().GoToUrl(baseUrl + "/dogovor/agentskie_dogovory/agentskiy_dogovor_na_poisk_klientov/");
                driver.WaitShowElement(btnSave);

                driver.Navigate().GoToUrl(baseUrl + "/dogovor/agentskie_dogovory/_subagentskiy_dogovor/");
                driver.WaitShowElement(btnSave);

                driver.Navigate().GoToUrl(baseUrl + "/dogovor/agentskie_dogovory/_agentskiy_dogovor_prodaji_uslug/");
                driver.WaitShowElement(btnSave);

                driver.Navigate().GoToUrl(baseUrl + "/dogovor/agentskie_dogovory/_agentskiy_dogovor_prodaji_nedvijimosti/");
                driver.WaitShowElement(btnSave);

                driver.Navigate().GoToUrl(baseUrl + "/dogovor/agentskie_dogovory/_agentskiy_dogovor_prodaji_tovara/");
                driver.WaitShowElement(btnSave);
            
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
            TestCaseOpeningTemplates tcot = new TestCaseOpeningTemplates();
            tcot.OpenTemp(selBrw);
        }
    }
}