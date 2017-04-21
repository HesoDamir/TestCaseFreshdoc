using System.Windows.Forms;
namespace TestCaseFreshdoc
{
    partial class frmTestFD
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestFD));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbTestCompl = new System.Windows.Forms.ProgressBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.lblSelBrw = new System.Windows.Forms.Label();
            this.lblSelCS = new System.Windows.Forms.Label();
            this.cbSelBwr = new System.Windows.Forms.ComboBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.cbSelCase = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDescrBrw = new System.Windows.Forms.RichTextBox();
            this.tbDescrTestCase = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbTestCompl);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnLog);
            this.groupBox1.Controls.Add(this.lblSelBrw);
            this.groupBox1.Controls.Add(this.lblSelCS);
            this.groupBox1.Controls.Add(this.cbSelBwr);
            this.groupBox1.Controls.Add(this.btnStartTest);
            this.groupBox1.Controls.Add(this.cbSelCase);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры тестирования";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pbTestCompl
            // 
            this.pbTestCompl.Location = new System.Drawing.Point(18, 176);
            this.pbTestCompl.Name = "pbTestCompl";
            this.pbTestCompl.Size = new System.Drawing.Size(370, 23);
            this.pbTestCompl.TabIndex = 1;
            this.pbTestCompl.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(313, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(225, 132);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(82, 23);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Логи";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // lblSelBrw
            // 
            this.lblSelBrw.AutoSize = true;
            this.lblSelBrw.Location = new System.Drawing.Point(6, 83);
            this.lblSelBrw.Name = "lblSelBrw";
            this.lblSelBrw.Size = new System.Drawing.Size(104, 13);
            this.lblSelBrw.TabIndex = 5;
            this.lblSelBrw.Text = "Выберите браузер:";
            // 
            // lblSelCS
            // 
            this.lblSelCS.AutoSize = true;
            this.lblSelCS.Location = new System.Drawing.Point(6, 27);
            this.lblSelCS.Name = "lblSelCS";
            this.lblSelCS.Size = new System.Drawing.Size(112, 13);
            this.lblSelCS.TabIndex = 4;
            this.lblSelCS.Text = "Выберите тест кейс:";
            // 
            // cbSelBwr
            // 
            this.cbSelBwr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelBwr.FormattingEnabled = true;
            this.cbSelBwr.Items.AddRange(new object[] {
            "Chrome",
            "Firefox",
            "Internet Explorer"});
            this.cbSelBwr.Location = new System.Drawing.Point(144, 80);
            this.cbSelBwr.Name = "cbSelBwr";
            this.cbSelBwr.Size = new System.Drawing.Size(244, 21);
            this.cbSelBwr.TabIndex = 3;
            this.cbSelBwr.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(144, 132);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(75, 23);
            this.btnStartTest.TabIndex = 2;
            this.btnStartTest.Text = "Запустить";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // cbSelCase
            // 
            this.cbSelCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelCase.FormattingEnabled = true;
            this.cbSelCase.Items.AddRange(new object[] {
            "Авторизация",
            "Регистрация",
            "Оплата банковской картой",
            "Проверка наличия элементов в публичном документе"});
            this.cbSelCase.Location = new System.Drawing.Point(144, 24);
            this.cbSelCase.Name = "cbSelCase";
            this.cbSelCase.Size = new System.Drawing.Size(244, 21);
            this.cbSelCase.TabIndex = 1;
            this.cbSelCase.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDescrBrw);
            this.groupBox2.Controls.Add(this.tbDescrTestCase);
            this.groupBox2.Location = new System.Drawing.Point(420, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Описание";
            // 
            // tbDescrBrw
            // 
            this.tbDescrBrw.BackColor = System.Drawing.SystemColors.Control;
            this.tbDescrBrw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescrBrw.Location = new System.Drawing.Point(6, 175);
            this.tbDescrBrw.Name = "tbDescrBrw";
            this.tbDescrBrw.ReadOnly = true;
            this.tbDescrBrw.Size = new System.Drawing.Size(259, 40);
            this.tbDescrBrw.TabIndex = 1;
            this.tbDescrBrw.Text = "";
            // 
            // tbDescrTestCase
            // 
            this.tbDescrTestCase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDescrTestCase.Location = new System.Drawing.Point(6, 19);
            this.tbDescrTestCase.Name = "tbDescrTestCase";
            this.tbDescrTestCase.ReadOnly = true;
            this.tbDescrTestCase.Size = new System.Drawing.Size(259, 154);
            this.tbDescrTestCase.TabIndex = 0;
            this.tbDescrTestCase.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "(Chrome по умолчанию)";
            // 
            // frmTestFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 246);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTestFD";
            this.Text = "Автоматизированные тесты сервиса Freshdoc ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.ComboBox cbSelCase;
        private System.Windows.Forms.ComboBox cbSelBwr;
        private System.Windows.Forms.Label lblSelBrw;
        private System.Windows.Forms.Label lblSelCS;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnExit;
        private ProgressBar pbTestCompl;
        private GroupBox groupBox2;
        private RichTextBox tbDescrBrw;
        private RichTextBox tbDescrTestCase;
        private Label label1;
    }
}

