using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace стих
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            saveFileDialog1.Title = "Сохранить фаил ";
            saveFileDialog1.FileName = "Test.txt";
            saveFileDialog1.Filter = "TXT FILES|*.txt|ALL FILLES |*.*";
          
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                    MessageBox.Show("фаил сохранён ");
                }
                catch (ArgumentException argEx)
                {
                    MessageBox.Show("Ошибка при открытии файла ", "ошибка ");
                }
               
            }
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Сохранить фаил ";
            openFileDialog1.FileName = "Test.txt";
            openFileDialog1.Filter = "TXT FILES|*.txt|ALL FILLES |*.*";
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string text = File.ReadAllText(path);
                for (int i = 0; i < text.Length; i++)
                {
                   
                    if (Char.IsPunctuation(text[i]))
                    {
                        
                        text = text.Remove(i, 2);
                        
                    }
                }
                File.WriteAllText(path, text);



                try
                {
                    FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader reder = new StreamReader(file);
                    try
                    {
                        while (!reder.EndOfStream)
                        {
                            textBox1.Text += reder.ReadLine();
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("ошибка при отткрытии вайла ", "ошибка ");
                    }

                }
                catch (ArgumentException argEx)
                {
                    MessageBox.Show("Ошибка при открытии файла ", "ошибка ");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Сохранить фаил ";
            openFileDialog1.FileName = "Test.txt";
            openFileDialog1.Filter = "TXT FILES|*.txt|ALL FILLES |*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string text = File.ReadAllText(path);
                for (int i = 0; i < text.Length; i++)
                {

                    if (Char.IsPunctuation(text[i]))
                    {

                        text = text.Remove(i);

                    }
                }
                File.WriteAllText(path, text);
                if (text.Contains(" "))
                {
                    text = text.Trim();
                    
                }



                try
                {
                    FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader reder = new StreamReader(file);
                    try
                    {
                        while (!reder.EndOfStream)
                        {
                            textBox1.Text += reder.ReadLine();
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("ошибка при отткрытии вайла ", "ошибка ");
                    }

                }
                catch (ArgumentException argEx)
                {
                    MessageBox.Show("Ошибка при открытии файла ", "ошибка ");
                }

            }
        }
    }
}
          