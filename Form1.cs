using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_6;

namespace Практическая_работа__12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Подсказки для кнопок
            ToolTip tp = new ToolTip();
            tp.SetToolTip(button1, "Нажмите, чтобы посчитать");
            toolTip1.SetToolTip(button2, "Нажмите, чтобы поменять");
        }
        
        //Номер задания
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = ("12");
        }

        //Дата
        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            statusStrip1.Items[1].Text = d.ToString("dd.MM.yyyy");
        }

        //Время
        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            statusStrip1.Items[2].Text = d.ToString("HH:mm");
        }

        //Кнопка Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разаработчик Алешина Дарья ИСП-31" +
                "Вариант 6" +
                "Практическая работа №12" +
                "Реализовать расчет задачи:" +
                "1.Даны два неотрицательных числа a и b. " +
                "Найти их среднее геометрическое, то есть квадратный корень из их произведения. " +
                "2.Дано трехзначное число. " +
                "Вывести число, полученное при перестановке цифр сотен и десятков исходного числа(например, 123 перейдет в 213).");
        }

        //Контекстное меню1 
        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        //Кнопка Очистить(Контекстное меню1)
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();          
        }

        //Контекстное меню2
        private void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        //Кнопка Очистить(Контекстное меню2)
        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        //Кнопка Задать(Контекстное меню1)
        private void исходныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int n1))
            {
                if (n1 >= 0)
                {
                     double num1 = n1;
                    
                }
                else
                {
                    MessageBox.Show("Число должно быть положительным");
                }

            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
        }
        
        //Среднее геометрическое двух чисел(Задача 1)
        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int n1))
            {
                if (n1 >= 0)
                {
                    if (Int32.TryParse(textBox2.Text, out int n2))
                    {
                        if (n2 >= 0)
                        {
                            double num2 = n2;
                            double num1 = n1;
                            double a = Math.Round(Calculation.GeometricMean(num1,num2), 2);
                            textBox3.Text = a.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Число должно быть положительным");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Число задано неправильно");
                    }

                }
                else
                {
                    MessageBox.Show("Число должно быть положительным");
                }

            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
            
            
        }

        //Кнопка Задать(Контекстное меню2)
        private void задатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox2.Text, out int n2))
            {
                if (n2 >= 0)
                {
                    double num2 = n2;

                }
                else
                {
                    MessageBox.Show("Число должно быть положительным");
                }

            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
        }

        //Контекстное меню3
        private void textBox5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip3.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        //Кнопка Задать(контекстное меню3)
        private void задатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool f;
            f = Int32.TryParse(textBox5.Text, out int n3);
            
            if (f==true)
            {
                if (n3 > 99 && n3 < 1000)
                {
                    int x = n3;
                }
                else
                {
                    MessageBox.Show("Число должно быть трехзначным");
                }
            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
        }

        //Кнопка Расчитать(задача 2)
        private void button2_Click(object sender, EventArgs e)
        {
            bool f;
            f = Int32.TryParse(textBox5.Text, out int n3);

            if (f == true)
            {
                if (n3 > 99 && n3 < 1000)
                {
                    int x = n3;
                    int a = Calculation.Change(x);
                    textBox7.Text = a.ToString();
                }
                else
                {
                    MessageBox.Show("Число должно быть трехзначным");
                }
            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }           
        }

        //Кнопка Очистить(контекстное меню3)
        private void очиститьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        //Кнопка Очистить(контекстное меню4)
        private void очиститьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        //Контекстное меню4
        private void textBox3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip4.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        //Кнопка Очистить(контекстное меню5)
        private void очиститьToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
        }

        //Контекстное меню5
        private void textBox7_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip5.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }
    }
    
}
