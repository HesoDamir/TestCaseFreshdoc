using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace TestCaseFreshdoc
{
    public partial class frmTestFD : Form
    {
        string pathCase, pathLogFl, pathLogDir, selBrw;
        string messgEx = "Что-то пошло не так.";
        string messgIOE = "Выберите тест кейс.";
        string messgW32E = "По выбранному тесту нет сегодняшних логов. Открыть папку с логами, созданных ранее?";
        string captErr = "Ошибка";
        string captQues = "TestCaseFreshdoc.exe";
        MessageBoxButtons btnBoxOK = MessageBoxButtons.OK;
        MessageBoxButtons btnBoxYN = MessageBoxButtons.YesNo;
        MessageBoxIcon icBoxErr = MessageBoxIcon.Error;
        MessageBoxIcon icBoxQues = MessageBoxIcon.Question;
        MessageBoxDefaultButton defBoxBtn1 = MessageBoxDefaultButton.Button1;
        MessageBoxOptions optBoxSN = MessageBoxOptions.ServiceNotification;

        public frmTestFD()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSelCase.Text)
            {
                case "Авторизация":
                    pathCase = @"TestСases\TestCase1\TestCase1\bin\Debug\TestCase1.exe";
                    pathLogDir = @"TestСases\TestCase1\TestCase1\bin\Debug\Log";
                    pathLogFl = Path.Combine(pathLogDir, string.Format("{0}_{1:dd.MM.yyy}.log", "TestCase1.exe", DateTime.Now));
                    tbDescrTestCase.Text = "Тест авторизации в сервисе Freshdoc." + Environment.NewLine + "Проверка работоспособности авторизации пользователя в сервисе Freshdoc.";
                    break;
                case "Регистрация":
                    pathCase = @"TestСases\Registration\Registration\bin\Debug\Registration.exe";
                    pathLogDir = @"TestСases\Registration\Registration\bin\Debug\Log";
                    pathLogFl = Path.Combine(pathLogDir, string.Format("{0}_{1:dd.MM.yyy}.log", "Registration.exe", DateTime.Now));
                    tbDescrTestCase.Text = "Тест регистрации в сервисе Freshdoc." + Environment.NewLine + "Проверка работоспособности регистрации пользователя в сервисе Freshdoc.";
                    break;
                case "Оплата банковской картой":
                    pathCase = @"TestСases\PayYaKassa\PayYaKassa\bin\Debug\PayYaKassa.exe";
                    pathLogDir = @"TestСases\PayYaKassa\PayYaKassa\bin\Debug\Log";
                    pathLogFl = Path.Combine(pathLogDir, string.Format("{0}_{1:dd.MM.yyy}.log", "PayYaKassa.exe", DateTime.Now));
                    tbDescrTestCase.Text = "Тест оплат банковской картой продуктов сервиса Freshdoc." + Environment.NewLine + "В случае успешного теста необходимо ввести код подтверждения из смс.";
                    break;
                case "Проверка наличия элементов в публичном документе":
                    pathCase = @"TestСases\VerifykShowElementPT\VerifykShowElementPT\bin\Debug\VerifykShowElementPT.exe";
                    pathLogDir = @"TestСases\VerifykShowElementPT\VerifykShowElementPT\bin\Debug\Log";
                    pathLogFl = Path.Combine(pathLogDir, string.Format("{0}_{1:dd.MM.yyy}.log", "PayDO.exe", DateTime.Now));
                    tbDescrTestCase.Text = "Тест публичного шаблона на наличие установленных элементов." + Environment.NewLine + "Проверка элементов происходит под неавторизованным и авторизованным пользователем. Проверяется наличие:"
                        + Environment.NewLine + "Кнопка 'Закрыть'"
                        + Environment.NewLine + "Кнопка 'Сохранить'"
                        + Environment.NewLine + "Кнопка 'Печать'"
                        + Environment.NewLine + "Кнопка 'Обсудить'"
                        + Environment.NewLine + "Кнопка 'Войти'"
                        + Environment.NewLine + "Кнопка 'На весь экран'"
                        + Environment.NewLine + "Надпись 'Опросный лист' в шаблоне/документе"
                        + Environment.NewLine + "Кнопка 'Документ()' в шаблоне/документе"
                        + Environment.NewLine + "Оранжевая иконка '500Р/250Р'"
                        + Environment.NewLine + "Кнопка 'Скачать документ'"
                        + Environment.NewLine + "Поле ввода комментария"
                        + Environment.NewLine + "Кнопка 'Добавить комментарий'"
                        + Environment.NewLine + "Таже самая проверка происходит под авторизованным пользователем, за исключением иконки '500Р/250Р'. Также в место кнопки 'На весь экран' проверяется наличие кнопки 'Свернуть'";
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cbSelBwr.Text)
            {
                case "Chrome":
                    selBrw = "Chrome";
                    tbDescrBrw.Text = "Запуск теста будет произведен в браузере Chrome";
                    break;
                case "Firefox":
                    selBrw = "Firefox";
                    tbDescrBrw.Text = "Запуск теста будет произведен в браузере Firefox";
                    break;
                case "Internet Explorer":
                    selBrw = "IE";
                    tbDescrBrw.Text = "Запуск теста будет произведен в браузере Internet Explorer";
                    break;
                default:
                    break;
            }
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(pathCase, selBrw);
            }
            catch (InvalidOperationException)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show(messgIOE, captErr, btnBoxOK, icBoxErr, defBoxBtn1, optBoxSN);
            }
            catch (Exception)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show(messgEx, captErr, btnBoxOK, icBoxErr, defBoxBtn1, optBoxSN);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(pathLogFl);
            }
            catch (Win32Exception)
            {
                SystemSounds.Asterisk.Play();
                var result = MessageBox.Show(messgW32E, captQues, btnBoxYN, icBoxQues, defBoxBtn1, optBoxSN);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Process.Start(pathLogDir);
                }
            }
            catch (InvalidOperationException)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show(messgIOE, captErr, btnBoxOK, icBoxErr, defBoxBtn1, optBoxSN);
            }
            catch (Exception)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show(messgEx, captErr, btnBoxOK, icBoxErr, defBoxBtn1, optBoxSN);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}