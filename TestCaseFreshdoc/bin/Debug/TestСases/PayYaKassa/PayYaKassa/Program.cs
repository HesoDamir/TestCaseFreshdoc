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

namespace PayYaKassa
{
    public class TestCasePayYaKassa
    {
        string messgNSEE = "Элемент не найден, проверьте корректность локатора.";
        string messgIOE = "Элемент некликабельный, возможно обработчик событий элемента не успел подгрузиться.";
        string messgEx = "Что-то пошло не так.";
        string messgDonePayDO = "Введите код подтверждения из SMS.";
        string captErr = "Ошибка";
        string captDone = "Готово";
        IWebDriver driver;
        MessageBoxButtons btnBoxOK = MessageBoxButtons.OK;
        MessageBoxIcon icBoxErr = MessageBoxIcon.Error;
        MessageBoxIcon icBoxInf = MessageBoxIcon.Information;
        MessageBoxOptions optBoxSN = MessageBoxOptions.ServiceNotification;
        public void PayYK(string selBrw)
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
                AuthFD.AuthForPayDO(driver); 

                var itCardNum = By.XPath("//input[@name='skr_card-number']");
                driver.WaitShowElement(itCardNum);
                driver.FindElement(itCardNum).Clear();
                driver.FindElement(itCardNum).SendKeys("4281160000381677");

                var itExpMnth = By.XPath("//input[@name='skr_month']");
                driver.FindElement(itExpMnth).Clear();
                driver.FindElement(itExpMnth).SendKeys("07");

                var itExpYear = By.XPath("//input[@name='skr_year']");
                driver.FindElement(itExpYear).Clear();
                driver.FindElement(itExpYear).SendKeys("17");

                var itCardCode = By.XPath("//input[@name='skr_cardCvc']");
                driver.FindElement(itCardCode).Clear();
                driver.FindElement(itCardCode).SendKeys("730");

                driver.FindElement(By.XPath("//button[@type='button']")).Click();
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show(messgDonePayDO, captDone, btnBoxOK, icBoxInf);
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
            TestCasePayYaKassa tcpyk = new TestCasePayYaKassa();
            tcpyk.PayYK(selBrw);
        }
    }
}