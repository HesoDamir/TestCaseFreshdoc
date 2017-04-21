using NUnit.Framework;
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using System.Drawing.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace Logger
{
    public class Log
    {
        public static string pathToLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
        private static object sync = new object();
        public static void Write(Exception ex)
        {
            try
            {
                if (!Directory.Exists(pathToLog))
                    Directory.CreateDirectory(pathToLog);
                string filenameLog = Path.Combine(pathToLog, string.Format("{0}_{1:dd.MM.yyy}.log",
                    AppDomain.CurrentDomain.FriendlyName, DateTime.Now));
                string fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] [{1}.{2}()] {3}\r\n--------\n",
                DateTime.Now, ex.TargetSite.DeclaringType, ex.TargetSite.Name, ex.Message);

                lock (sync)
                {
                    File.AppendAllText(filenameLog, fullText, Encoding.GetEncoding("Windows-1251"));
                }
            }
            catch
            {

            }
        }

        public static void TakeScreenshot(IWebDriver driver)
        {
            try
            {
            string filenameScr = Path.Combine(pathToLog, string.Format("{0}_{1:dd.MM.yyy_HH-mm-ss}",
               AppDomain.CurrentDomain.FriendlyName, DateTime.Now));
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(filenameScr, 0);
            }
            catch
            {

            }
        }

        public static void WriteElDisplayed()
        {

                if (!Directory.Exists(pathToLog))
                    Directory.CreateDirectory(pathToLog);
                string filenameLog = Path.Combine(pathToLog, string.Format("{0}_{1:dd.MM.yyy}.log",
                    AppDomain.CurrentDomain.FriendlyName, DateTime.Now));
                string fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] Element is displayed on the page.\n--------\n",
                DateTime.Now);

                lock (sync)
                {
                    File.AppendAllText(filenameLog, fullText, Encoding.GetEncoding("Windows-1251"));
                }
        }

        public static void WriteElNotDisplayed(Exception ex)
        {
            if (!Directory.Exists(pathToLog))
                Directory.CreateDirectory(pathToLog);
            string filenameLog = Path.Combine(pathToLog, string.Format("{0}_{1:dd.MM.yyy}.log",
                AppDomain.CurrentDomain.FriendlyName, DateTime.Now));
            string fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] Element NOT is displayed on the page!!!{1}\r\n--------\n",
                DateTime.Now, ex.Message);

            lock (sync)
            {
                File.AppendAllText(filenameLog, fullText, Encoding.GetEncoding("Windows-1251"));
            }
        }
    }
}