using ElementWaiting;
using Logger;
using Login;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace TestCase1
{
    public class TestCaseAuthorization : Constants
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
        public void UserAuth(string selBrw)
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
                AuthFD.AuthUsingDirPA(driver);
                System.Threading.Thread.Sleep(1000);

                driver.FindElement(By.XPath("//div[@class='qd-catalog__content']/div/div/div[7]")).Click();
                //IList<IWebElement> elements = driver.FindElements(By.CssSelector("div.qd-filelist-table-fields"));

                //driver.FindElements(By.XPath("//button[text()="Агентский"]"));

                        /*----Тест-сьюты (после каждого close нужно объявлять драйвер и указывать baseUrl)----*/

                //driver.Close();
                //AuthFD.AuthUsingDirPA(driver);
                //driver.Close();
                //AuthFD.AuthUsingPublicDoc(driver);

                //RegFD.RegUsingBtnEnter(driver);
                //driver.Close();
                //RegFD.RegUsingDirPA(driver);
                //driver.Close();
                //RegFD.RegUsingPublicDoc(driver);

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
            TestCaseAuthorization TestCase1 = new TestCaseAuthorization();
            TestCase1.UserAuth(selBrw);
        }
    }
}