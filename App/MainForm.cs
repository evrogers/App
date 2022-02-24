using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Color currentColor;
        private int panelWidth = 400;
        private int btnHeight = 100;
        public bool isAdmin;
        private string filePath;
        private string fullPath;



        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isAdmin = FormEnter.isAdmin;
            if (isAdmin)
            {
                buttonAdmin.Visible = true;
                panelOpen.Visible = true;
            }
            else buttonGuest.Visible = true;

            Size resolution = Screen.PrimaryScreen.Bounds.Size;

            if (resolution.Width < 1920 && resolution.Height < 1080)
            {
                resizeElementsForNotFHD(resolution);
            }

            subj1_Click(subj1, e);

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void resizeElementsForNotFHD(Size resolution)
        {
            panelMenu.Width = resolution.Width / 4;
            panelLogo.Height = resolution.Height / 8;
            panelTitleBar.Height = resolution.Height / 8;
            panelSubj.Width = resolution.Width / 5 + 30;
            panelWidth = panelSubj.Width;
            panelOpen.Height = 30;
            foreach (Button button in panelSubj1.Controls)
            {
                button.Height = resolution.Height / 11;
            }
            btnHeight = resolution.Height / 11;


            foreach (Button button in panelMenu.Controls.OfType<Button>())
            {
                button.Height = resolution.Height / 11;
            }

            List<Button> btns = new List<Button>();
            foreach (Panel panel in panelSubj.Controls.OfType<Panel>())
            {
                btns = panel.Controls.OfType<Button>().ToList();
            }
            foreach (Button button in btns)
            {
                button.Height = panelMenu.Height / 11;
            }

            panelMenu.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            panelSubj.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            openFileButton.Font = new Font("Century Gothic", 10F, FontStyle.Underline);
            dropDownMenuSubj2.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dropDownMenuSubj3Lect.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dropDownMenuSubj3Pract.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dropDownMenuSubj3Present.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dropDownMenuSubj4Lect.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dropDownMenuSubj4Pract.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dropDownMenuSubj4Present.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dropDownMenuSubj5Lect.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dropDownMenuSubj5Pract.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dropDownMenuSubj5Mtrls.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            AlgorithmVideos.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            CSharpVideos.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
        }

        private Color SelectThemeColor(int index)
        {
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {

                    DisableButton();
                    currentButton = (Button)btnSender;
                    Color color = SelectThemeColor(currentButton.TabIndex - 1);
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    currentColor = color;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(41, 44, 51);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            panelVideo.Hide();
        }

        private void runGameButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"Murlodin\Murlodin.exe");
        }

        private void subj1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            button1.Text = "Алгоритмизация";
            panelSubj.Show();
            //foreach (Panel panel in panelSubj.Controls) { panel.Hide(); }
            panelSubj1.Show();
            panelSubj2.Hide();
            panelSubj3.Hide();
            panelSubj4.Hide();
            panelSubj5.Hide();
            panelSubj6.Hide();
            panelSubj7.Hide();
            //panelSubj.Controls[0].Show();
            panelMoveToLeft(button2, button3, button4, button21);
        }

        private void subj2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            button1.Text = "Учебная практика по программированию";
            panelSubj.Show();
            panelSubj2.Show();
            panelSubj1.Hide();
            panelSubj3.Hide();
            panelSubj4.Hide();
            panelSubj5.Hide();
            panelSubj6.Hide();
            panelSubj7.Hide();
            //foreach (Panel panel in panelSubj.Controls) { panel.Hide(); }
            //panelSubj.Controls[1].Show();
            panelMoveToLeft(button6);
        }

        private void subj3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            button1.Text = "Конструирование программ и языки программирования";
            panelSubj.Show();
            //foreach (Panel panel in panelSubj.Controls) { panel.Hide(); }
            //panelSubj.Controls[2].Show();
            panelSubj3.Show();
            panelSubj1.Hide();
            panelSubj2.Hide();
            panelSubj4.Hide();
            panelSubj5.Hide();
            panelSubj6.Hide();
            panelSubj7.Hide();
            panelMoveToLeft(button8, button7, button5, button22);
        }

        private void subj4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            button1.Text = "Java: разработка алгоритмов";
            panelSubj.Show();
            //foreach (Panel panel in panelSubj.Controls) { panel.Hide(); }
            //panelSubj.Controls[3].Show();
            panelSubj4.Show();
            panelSubj1.Hide();
            panelSubj2.Hide();
            panelSubj3.Hide();
            panelSubj5.Hide();
            panelSubj6.Hide();
            panelSubj7.Hide();
            panelMoveToLeft(button11, button10, button9);
        }

        private void subj5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            button1.Text = "Java: объектно-ориентированное программирование";
            panelSubj.Show();
            //foreach (Panel panel in panelSubj.Controls) { panel.Hide(); }
            //panelSubj.Controls[4].Show();
            panelSubj5.Show();
            panelSubj2.Hide();
            panelSubj3.Hide();
            panelSubj4.Hide();
            panelSubj1.Hide();
            panelSubj6.Hide();
            panelSubj7.Hide();
            panelMoveToLeft(button14, button13, button12, button21);
        }

        private void subj6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            button1.Text = "Инструментальное ПО";
            panelSubj.Show();
            //foreach (Panel panel in panelSubj.Controls) { panel.Hide(); }
            //panelSubj.Controls[5].Show();
            panelSubj6.Show();
            panelSubj2.Hide();
            panelSubj3.Hide();
            panelSubj4.Hide();
            panelSubj5.Hide();
            panelSubj1.Hide();
            panelSubj7.Hide();
            panelMoveToLeft(button17, button16, button15);
        }

        private void subj7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            button1.Text = "Разработка приложений для мобильных устройств";
            panelSubj.Show();
            //foreach (Panel panel in panelSubj.Controls) { panel.Hide(); }
            //panelSubj.Controls[6].Show();
            panelSubj7.Show();
            panelSubj2.Hide();
            panelSubj3.Hide();
            panelSubj4.Hide();
            panelSubj5.Hide();
            panelSubj6.Hide();
            panelSubj1.Hide();
            panelMoveToLeft(button20, button19, button18);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            Process.Start(filePath);
        }

        private void panelMoveToTop(Button btn1, Button btn2 = null, Button btn3 = null, Button btn4 = null)
        {
            panelSubj.Height = btnHeight;
            panelSubj.Dock = DockStyle.Top;
            if (btn2 != null && btn3 != null && btn4 == null)
            {
                btn1.Dock = DockStyle.Left;
                btn1.Width = panelSubj.Width / 3;
                btn2.Dock = DockStyle.Left;
                btn2.Width = panelSubj.Width / 3;
                btn3.Dock = DockStyle.Fill;
                btn3.Width = panelSubj.Width / 3;
            }
            else if (btn2 != null && btn3 != null && btn4 != null)
            {
                btn1.Dock = DockStyle.Left;
                btn1.Width = panelSubj.Width / 4;
                btn2.Dock = DockStyle.Left;
                btn2.Width = panelSubj.Width / 4;
                btn3.Dock = DockStyle.Left;
                btn3.Width = panelSubj.Width / 4;
                btn4.Dock = DockStyle.Fill;
                btn4.Width = panelSubj.Width / 4;
            }
            else
            {
                btn1.Dock = DockStyle.Fill;
            }

            panelDoc.BringToFront();
            panelDoc.Show();
        }

        private void panelMoveToLeft(Button btn1, Button btn2 = null, Button btn3 = null, Button btn4 = null)
        {
            panelDoc.Hide();
            if (panelVideo.Visible) panelVideo.Hide();
            panelSubj.Dock = DockStyle.Left;
            panelSubj.Width = panelWidth;
            btn1.Dock = DockStyle.Top;
            btn1.Height = btnHeight;
            if (btn2 != null && btn3 != null && btn4 == null)
            {
                btn2.Dock = DockStyle.Top;
                btn2.Height = btnHeight;
                btn3.Dock = DockStyle.Top;
                btn3.Height = btnHeight;
            }
            else if (btn2 != null && btn3 != null && btn4 != null)
            {
                btn2.Dock = DockStyle.Top;
                btn2.Height = btnHeight;
                btn3.Dock = DockStyle.Top;
                btn3.Height = btnHeight;
                btn4.Dock = DockStyle.Top;
                btn4.Height = btnHeight;
            }
        }


        // Уч. практика -----------------------------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            dropDownMenuSubj2.IsMainMenu = true;
            dropDownMenuSubj2.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[1]);
            dropDownMenuSubj2.Show(button6, button6.Width, 0);
        }

        private void dropDownMenuSubj2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panelMoveToTop(button6);
            switch (e.ClickedItem.Name)
            {
                case "pr1":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 1.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr2":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 2.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr3":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 3.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr4":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 4.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr5":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 5.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr6":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 6.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr7":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 7.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr8":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 8.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr9":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 9.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr10":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 10.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr11":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 11.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr12":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 12.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr13":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 13.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr14":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 14.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr15":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 15.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr16":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 16.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr17":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 17.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr18":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 18.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr19":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 19.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr20":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 20.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr21":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 21.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr22":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 22.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr23":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 23.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr24":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 24.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr25":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 25.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr26":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 26.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr27":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 27.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr28":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 28.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr29":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 29.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr30":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 30.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr31":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 31.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr32":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 32.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr33":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 33.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr34":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 34.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr35":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 35.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "pr36":
                    {
                        filePath = @"Материалы\Уч практ по программированию\Практическое занятие 36.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
            }
        }

        // КПиЯП ------------------------------------------------------------------------------------
        //Лекции
        private void button8_Click(object sender, EventArgs e)
        {
            dropDownMenuSubj3Lect.IsMainMenu = true;
            dropDownMenuSubj3Lect.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[2]);
            dropDownMenuSubj3Lect.Show(button8, button8.Width, 0);
        }

        private void dropDownMenuSubj3Lect_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panelMoveToTop(button8, button7, button5, button22);
            switch (e.ClickedItem.Name)
            {
                case "Item1":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Введение.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item2":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 1.1 Принципы объектно-ориентированного программирования. Язык программирования С# и платформа.NET.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item3":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 1.2 Интегрированная среда разработки.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item4":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.1 Система типов.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item5":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.2 Структура программы. Переменные, операции и выражения.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item6":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.3. Сборки. Атрибуты. Директивы. Пространства имен.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item7":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.4 Операторы.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item8":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.5 Процедуры и функции – методы класса. Встроенные функции.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item9":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.6 Классы.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item10":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.7 Массивы. Класс Array.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item11":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.8 Символы и строки постоянной длины. Классы String и StringBuilder.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item12":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.9 Регулярные выражения.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item13":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.10 Структуры. Перечисления.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item14":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.11 Отношения между классами.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item15":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.12 Интерфейсы.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item16":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.13 Обработка исключительных ситуаций.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item17":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 2.14 Делегаты, лямбда-выражения и события.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item18":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 3.1 Файлы и сериализация объектов.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item19":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 3.2 Библиотеки динамической компоновки.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item20":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 3.3 Обобщения и коллекции.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "Item21":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 3.4 Принципы работы с XML-данными.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "Item22":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 3.5 Основы многопоточного программирования.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "Item23":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 3.6 Основы параллельного программирования.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "Item24":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 4.1 Приложения с графическим пользовательским интерфейсом. Форма и элементы управления. Меню и панели инструментов.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "Item25":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 4.2 Работа с графикой. Анимация.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "Item26":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 4.3 Работа с базами данных. Технология ADO.NET.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "Item27":
                    {
                        filePath = @"Материалы\КПиЯП\Лекции\Тема 4.4 Развертывание Windows-приложений.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }

            }
        }

        //Практикум
        private void button7_Click(object sender, EventArgs e)
        {
            dropDownMenuSubj3Pract.IsMainMenu = true;
            dropDownMenuSubj3Pract.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[2]);
            dropDownMenuSubj3Pract.Show(button7, button7.Width, 0);
        }

        private void dropDownMenuSubj3Pract_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panelMoveToTop(button8, button7, button5, button22);
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem1":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 1.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem2":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 2.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem3":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 3.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem4":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 4.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem5":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 5 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem6":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 5 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem7":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 6 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem8":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 6 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem9":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 7 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem10":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 7 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem11":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 8.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem12":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 9.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem13":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 10 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem14":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 10 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem15":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 11 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem16":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 11 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem17":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 12";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem18":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 13 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem19":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 13 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem20":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 14.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem21":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 15 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem22":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 15 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem23":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 16.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem24":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 17 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem25":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 17 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem26":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 18 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem27":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 18 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem28":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 19 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem29":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 19 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem30":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 20.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem31":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 21.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem32":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 22.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem33":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 23.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem34":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 24 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem35":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 24 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem36":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 25.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem37":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 26.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem38":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 27 (часть 1).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem39":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 27 (часть 2).docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem40":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 28.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem41":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 29.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
                case "toolStripMenuItem42":
                    {
                        filePath = @"Материалы\КПиЯП\Практикум\Лабораторная работа № 30.docx";
                        documentViewer1.LoadDocument(filePath);
                        break;
                    }
            }
        }

        //Презентации
        private void button5_Click(object sender, EventArgs e)
        {
            dropDownMenuSubj3Present.IsMainMenu = true;
            dropDownMenuSubj3Present.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[2]);
            dropDownMenuSubj3Present.Show(button5, button5.Width, 0);
        }

        private void dropDownMenuSubj3Present_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panelMoveToLeft(button8, button7, button5, button22);
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem43":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_введение.ppt"); break;
                    }
                case "toolStripMenuItem44":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_ООП.ppt"); break;
                    }
                case "toolStripMenuItem45":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# переменные, операции, выражения.ppt"); break;
                    }
                case "toolStripMenuItem46":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Исключительные ситуации.pptx"); break;
                    }
                case "toolStripMenuItem47":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_ C#_Рег_ выражения.pptx"); break;
                    }
                case "toolStripMenuItem48":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# XML.ppt"); break;
                    }
                case "toolStripMenuItem49":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# делегаты.ppt"); break;
                    }
                case "toolStripMenuItem50":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# динамич библиотеки.ppt"); break;
                    }
                case "toolStripMenuItem51":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# интерфейсы.ppt"); break;
                    }
                case "toolStripMenuItem52":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# классы конструкторы.ppt"); break;
                    }
                case "toolStripMenuItem53":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# классы.ppt"); break;
                    }
                case "toolStripMenuItem54":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# коллекции.ppt"); break;
                    }
                case "toolStripMenuItem55":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# массивы.ppt"); break;
                    }
                case "toolStripMenuItem56":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# наследование.ppt"); break;
                    }
                case "toolStripMenuItem57":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# процедуры функции.ppt"); break;
                    }
                case "toolStripMenuItem58":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# сборки.ppt"); break;
                    }
                case "toolStripMenuItem59":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# символы и строки.ppt"); break;
                    }
                case "toolStripMenuItem60":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# система типов.ppt"); break;
                    }
                case "toolStripMenuItem61":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# события.ppt"); break;
                    }
                case "toolStripMenuItem62":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# структуры.ppt"); break;
                    }
                case "toolStripMenuItem63":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# условные циклические.ppt"); break;
                    }
                case "toolStripMenuItem64":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_C# файлы.ppt"); break;
                    }
                case "toolStripMenuItem65":
                    {
                        Process.Start(@"Материалы\КПиЯП\Презентации\Презентация_Visual Studio.NET.ppt"); break;
                    }
            }
        }

        //Видео
        private void button22_Click(object sender, EventArgs e)
        {
            CSharpVideos.IsMainMenu = true;
            CSharpVideos.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[2]);
            CSharpVideos.Show(button22, button22.Width, 0);
        }

        private void CSharpVideos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panelMoveToTop(button8, button7, button5, button22);
            panelVideo.BringToFront();
            panelVideo.Show();
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem170":
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        filePath = @"Материалы\КПиЯП\Видео\Обработка массива_C#.mp4";
                        fullPath = Path.GetFullPath(filePath);
                        axWindowsMediaPlayer1.URL = fullPath;
                        break;
                    }
            }
        }


        // JAVA: разработка алгоритмов --------------------------------------------------------------
        //Лекции
        private void button11_Click(object sender, EventArgs e)
        {
            dropDownMenuSubj4Lect.IsMainMenu = true;
            dropDownMenuSubj4Lect.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[3]);
            dropDownMenuSubj4Lect.Show(button11, button11.Width, 0);
        }

        private void dropDownMenuSubj4Lect_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panelMoveToTop(button11, button10, button9);
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem66":
                    {
                        filePath = @"Материалы\JAVA\Лекции\1. Алфавит языка.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem67":
                    {
                        filePath = @"Материалы\JAVA\Лекции\2. Ключевые слова.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem68":
                    {
                        filePath = @"Материалы\JAVA\Лекции\3. Типы данных.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem69":
                    {
                        filePath = @"Материалы\JAVA\Лекции\4. Литералы (константы).docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem70":
                    {
                        filePath = @"Материалы\JAVA\Лекции\5. Комментарии.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem71":
                    {
                        filePath = @"Материалы\JAVA\Лекции\6. Переменные.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem72":
                    {
                        filePath = @"Материалы\JAVA\Лекции\7. Математические функции.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem73":
                    {
                        filePath = @"Материалы\JAVA\Лекции\8. Выражения.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem74":
                    {
                        filePath = @"Материалы\JAVA\Лекции\8.1. Выражения целого типа.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem75":
                    {
                        filePath = @"Материалы\JAVA\Лекции\8.2. Выражения действительного типа.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem76":
                    {
                        filePath = @"Материалы\JAVA\Лекции\8.3. Выражения логического типа.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem77":
                    {
                        filePath = @"Материалы\JAVA\Лекции\9. Операторы присваивания.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem78":
                    {
                        filePath = @"Материалы\JAVA\Лекции\10. Ввод и вывод данных.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem79":
                    {
                        filePath = @"Материалы\JAVA\Лекции\10.1. Ввод и вывод с помощью диалоговых окон.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem80":
                    {
                        filePath = @"Материалы\JAVA\Лекции\10.2. Консольный вывод.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem81":
                    {
                        filePath = @"Материалы\JAVA\Лекции\10.3. Консольный ввод с помощью класса Scanner.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem82":
                    {
                        filePath = @"Материалы\JAVA\Лекции\11. Структура программы.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem83":
                    {
                        filePath = @"Материалы\JAVA\Лекции\12. Алгоритм и его свойства.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem84":
                    {
                        filePath = @"Материалы\JAVA\Лекции\12.1. Схемы алгоритмов.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem85":
                    {
                        filePath = @"Материалы\JAVA\Лекции\13. Базовые структуры.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem86":
                    {
                        filePath = @"Материалы\JAVA\Лекции\13.1. Цепочка.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem87":
                    {
                        filePath = @"Материалы\JAVA\Лекции\13.2. Ветвления.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem88":
                    {
                        filePath = @"Материалы\JAVA\Лекции\13.3. Переключатель.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem89":
                    {
                        filePath = @"Материалы\JAVA\Лекции\13.4. Циклы.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem90":
                    {
                        filePath = @"Материалы\JAVA\Лекции\13.5. Бесконечные циклы.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem91":
                    {
                        filePath = @"Материалы\JAVA\Лекции\13.6. Циклы с постусловием.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem92":
                    {
                        filePath = @"Материалы\JAVA\Лекции\13.7. Циклы с параметром.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem93":
                    {
                        filePath = @"Материалы\JAVA\Лекции\13.8. Операторы прерывания break, continue, return, System.exit.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem94":
                    {
                        filePath = @"Материалы\JAVA\Лекции\14. Структуры данных.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem95":
                    {
                        filePath = @"Материалы\JAVA\Лекции\14.1. Массивы.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem96":
                    {
                        filePath = @"Материалы\JAVA\Лекции\14.2. Методы для работы с массивами.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem97":
                    {
                        filePath = @"Материалы\JAVA\Лекции\14.3. Строки.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem98":
                    {
                        filePath = @"Материалы\JAVA\Лекции\14.4. Класс String.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem99":
                    {
                        filePath = @"Материалы\JAVA\Лекции\14.5. Методы для работы со строками класса String.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem100":
                    {
                        filePath = @"Материалы\JAVA\Лекции\14.6. Класс StringBuffer.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem101":
                    {
                        filePath = @"Материалы\JAVA\Лекции\14.7. Методы для работы со строками класса StringBuffer.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem102":
                    {
                        filePath = @"Материалы\JAVA\Лекции\14.8. Файлы.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem103":
                    {
                        filePath = @"Материалы\JAVA\Лекции\15. Обработка исключительных ситуаций.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
            }
        }

        //Практикум
        private void button10_Click(object sender, EventArgs e)
        {
            dropDownMenuSubj4Pract.IsMainMenu = true;
            dropDownMenuSubj4Pract.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[3]);
            dropDownMenuSubj4Pract.Show(button10, button10.Width, 0);
        }

        private void dropDownMenuSubj4Pract_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panelMoveToTop(button11, button10, button9);
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem104":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 1. Элементарные типы данных Java.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem105":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 2. Управляющие операторы Java.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem106":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 3. Введение в классы, объекты, методы.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem107":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 4. Класс String.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem108":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 5. Массивы.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem109":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 6. Класс ArrayList.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem110":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 7. Принципы объектно-ориентированного программирования.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem111":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 8. Применение ключевого слова static.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem112":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 9. Наследование.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem113":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 10. Абстрактные классы и методы, интерфейсы.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem114":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 11. Вложенные и внутренние классы.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem115":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 12. Введение в обработку исключений.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem116":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 13. Ввод-вывод данных.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem117":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 14. Классы-коллекции.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem118":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 15. Многопоточное программирование.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem119":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 16. Создание программ с графическим интерфейсом средствами Swing.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
            }
        }

        //Презентации
        private void button9_Click(object sender, EventArgs e)
        {
            dropDownMenuSubj4Present.IsMainMenu = true;
            dropDownMenuSubj4Present.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[3]);
            dropDownMenuSubj4Present.Show(button9, button9.Width, 0);
        }

        private void dropDownMenuSubj4Present_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panelMoveToLeft(button11, button10, button9);
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem120":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Введение. Типы данных.pptx"); break;
                    }
                case "toolStripMenuItem121":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Управляющие конструкции.pptx"); break;
                    }
                case "toolStripMenuItem122":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Классы и объекты.pptx"); break;
                    }
                case "toolStripMenuItem123":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Абстрактные классы и интерфейсы.pptx"); break;
                    }
                case "toolStripMenuItem124":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Наследование.pptx"); break;
                    }
                case "toolStripMenuItem125":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Пакеты и интерфейсы.pptx"); break;
                    }
                case "toolStripMenuItem126":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Строки и даты.pptx"); break;
                    }
                case "toolStripMenuItem127":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Ввод-вывод.pptx"); break;
                    }
                case "toolStripMenuItem128":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Исключения.pptx"); break;
                    }
                case "toolStripMenuItem129":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Паттерны проектирования.pptx"); break;
                    }
                case "toolStripMenuItem130":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Коллекции.ppt"); break;
                    }
                case "toolStripMenuItem131":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Базы данных.ppt"); break;
                    }
                case "toolStripMenuItem132":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Сетевые соединения.ppt"); break;
                    }
                case "toolStripMenuItem133":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Сетевые коллекции.pptx"); break;
                    }
                case "toolStripMenuItem134":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Сетевая многопоточность.pptx"); break;
                    }
                case "toolStripMenuItem135":
                    {
                        Process.Start(@"Материалы\JAVA\Презентации\Сетевое введение в Swing.pptx"); break;
                    }
            }
        }


        // JAVA: ООП --------------------------------------------------------------------------------
        //Лекции
        private void button14_Click(object sender, EventArgs e)
        {
            dropDownMenuSubj5Lect.IsMainMenu = true;
            dropDownMenuSubj5Lect.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[4]);
            dropDownMenuSubj5Lect.Show(button14, button14.Width, 0);
        }

        private void dropDownMenuSubj5Lect_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (panelVideo.Visible) panelVideo.Hide();
            panelMoveToTop(button14, button13, button12);
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem146":
                    {
                        filePath = @"Материалы\JAVA_ООП\Лекции\Раздел 1. Классы и объекты.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem147":
                    {
                        filePath = @"Материалы\JAVA_ООП\Лекции\Раздел 2. Наследование.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem148":
                    {
                        filePath = @"Материалы\JAVA_ООП\Лекции\Раздел 3. Коллекции и обобщения.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem149":
                    {
                        filePath = @"Материалы\JAVA_ООП\Лекции\Раздел 4. Создание GUI Swing.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem150":
                    {
                        filePath = @"Материалы\JAVA_ООП\Лекции\Раздел 5. Сетевые соединения.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
            }
        }

        //Прктикум
        private void button13_Click(object sender, EventArgs e)
        {
            dropDownMenuSubj5Pract.IsMainMenu = true;
            dropDownMenuSubj5Pract.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[4]);
            dropDownMenuSubj5Pract.Show(button13, button13.Width, 0);
        }

        private void dropDownMenuSubj5Pract_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panelMoveToTop(button14, button13, button12);
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem151":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 1. Элементарные типы данных Java.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem152":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 2. Управляющие операторы Java.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem153":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 3. Введение в классы, объекты, методы.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem154":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 4. Класс String.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem155":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 5. Массивы.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem156":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 6. Класс ArrayList.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem157":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 7. Принципы объектно-ориентированного программирования.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem158":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 8. Применение ключевого слова static.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem159":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 9. Наследование.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem160":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 10. Абстрактные классы и методы, интерфейсы.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem161":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 11. Вложенные и внутренние классы.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem162":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 12. Введение в обработку исключений.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem163":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 13. Ввод-вывод данных.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem164":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 14. Классы-коллекции.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem165":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 15. Многопоточное программирование.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem166":
                    {
                        filePath = @"Материалы\JAVA\Практика\Тема 16. Создание программ с графическим интерфейсом средствами Swing.pdf";
                        documentViewer1.LoadDocument(filePath); break;
                    }
            }
        }

        //Материалы
        private void button12_Click(object sender, EventArgs e)
        {
            dropDownMenuSubj5Mtrls.IsMainMenu = true;
            dropDownMenuSubj5Mtrls.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[4]);
            dropDownMenuSubj5Mtrls.Show(button12, button12.Width, 0);
        }

        private void dropDownMenuSubj5Mtrls_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                //презентации
                case "toolStripMenuItem136":
                    {
                        panelMoveToLeft(button14, button13, button12);
                        Process.Start(@"Материалы\JAVA_ООП\Презентации\Классы и объекты.pptx"); break;
                    }
                case "toolStripMenuItem137":
                    {
                        panelMoveToLeft(button14, button13, button12);
                        Process.Start(@"Материалы\JAVA_ООП\Презентации\Коллекции и обобщения.pptx"); break;
                    }
                case "toolStripMenuItem138":
                    {
                        panelMoveToLeft(button14, button13, button12);
                        Process.Start(@"Материалы\JAVA_ООП\Презентации\Наследование.pptx"); break;
                    }
                case "toolStripMenuItem139":
                    {
                        panelMoveToLeft(button14, button13, button12);
                        Process.Start(@"Материалы\JAVA_ООП\Презентации\Сетевые соединения.pptx"); break;
                    }
                case "toolStripMenuItem140":
                    {
                        panelMoveToLeft(button14, button13, button12);
                        Process.Start(@"Материалы\JAVA_ООП\Презентации\Создание GUI и Swing.pptx"); break;
                    }

                //литература
                case "toolStripMenuItem141":
                    {
                        filePath = @"Материалы\JAVA_ООП\Литература\JAVA Методы программирования - Блинов 2013.pdf";
                        panelMoveToTop(button14, button13, button12);
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem142":
                    {
                        filePath = @"Материалы\JAVA_ООП\Литература\Java8 Полное руководство - Shildt G. 2015.pdf";
                        panelMoveToTop(button14, button13, button12);
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem143":
                    {
                        filePath = @"Материалы\JAVA_ООП\Литература\Быстрое учебное руководство по Java IDE NetBeans.pdf";
                        panelMoveToTop(button14, button13, button12);
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem144":
                    {
                        filePath = @"Материалы\JAVA_ООП\Литература\Изучаем Java - K. Syerra, B. Beyts.pdf";
                        panelMoveToTop(button14, button13, button12);
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem145":
                    {
                        filePath = @"Материалы\JAVA_ООП\Литература\Установка Java NetBeans IDE.pdf";
                        panelMoveToTop(button14, button13, button12);
                        documentViewer1.LoadDocument(filePath); break;
                    }
            }
        }

        //Видео
        private void button21_Click(object sender, EventArgs e)
        {
            AlgorithmVideos.IsMainMenu = true;
            AlgorithmVideos.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[0]);
            AlgorithmVideos.Show(button21, button21.Width, 0);
        }

        private void AlgorithmVideos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panelMoveToTop(button2, button3, button4, button21);
            panelVideo.BringToFront();
            panelVideo.Show();
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem167":
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        filePath = @"Материалы\Алгоритмизация\Видео\Процедуры и функции на Паскале.mp4";
                        fullPath = Path.GetFullPath(filePath);
                        axWindowsMediaPlayer1.URL = fullPath;
                        break;
                    }
                case "toolStripMenuItem168":
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        filePath = @"Материалы\Алгоритмизация\Видео\Поиск min (max) элемента.mp4";
                        fullPath = System.IO.Path.GetFullPath(filePath);
                        axWindowsMediaPlayer1.URL = fullPath;
                        break;
                    }
                case "toolStripMenuItem169":
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        filePath = @"Материалы\Алгоритмизация\Видео\Нормализация базы данных.mp4";
                        fullPath = System.IO.Path.GetFullPath(filePath);
                        axWindowsMediaPlayer1.URL = fullPath;
                        break;
                    }
            }
        }

        private void openFileButton_MouseMove(object sender, MouseEventArgs e)
        {
            openFileButton.ForeColor = ThemeColor.ChangeColorBrightness(currentColor, 0.3);
        }

        private void openFileButton_MouseLeave(object sender, EventArgs e)
        {
            openFileButton.ForeColor = Color.Gainsboro;
        }

        private void panelVideo_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelVideo.Visible)
            {
                axWindowsMediaPlayer1.close();
                panelVideo.Hide();
            }
            else panelDoc.Hide();
        }

        private void panelDoc_VisibleChanged(object sender, EventArgs e)
        {
            if (!panelDoc.Visible) panelVideo.Show();
            else panelVideo.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dropDownMenuSubj1Lect.IsMainMenu = true;
            dropDownMenuSubj1Lect.PrimaryColor = ColorTranslator.FromHtml(ThemeColor.ColorList[0]);
            dropDownMenuSubj1Lect.Show(button2, button2.Width, 0);
        }

        private void dropDownMenuSubj1Lect_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panelMoveToTop(button2, button3, button4, button21);
            switch (e.ClickedItem.Name)
            {
                case "toolStripMenuItem171":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Алгоритмы внутренней сортировки.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem172":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Бинарные деревья.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem173":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Быстрая сортировка.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem174":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Графы.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem175":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Деревья.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem176":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Динамические массивы.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem177":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Закрытое хеширование.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem178":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Линейные списки.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem179":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Линейный двунаправленный список.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem180":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Максимальный поток в сети.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem181":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Множества.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem182":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Очереди.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem183":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Поиск в графе.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem184":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Поиск остовного дерева графа.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem185":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Сбалансированные деревья.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem186":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Стеки.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem187":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Файлы.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
                case "toolStripMenuItem188":
                    {
                        filePath = @"Материалы\Алгоритмизация\Лекции\Хешироваие.docx";
                        documentViewer1.LoadDocument(filePath); break;
                    }
            }
        }
    }
}
