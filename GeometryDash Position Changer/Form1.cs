using GeometryDash_Position_Changer.Properties;
using Swed32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GeometryDash_Position_Changer
{
    public partial class Form1 : Form
    {
        int xOffset1 = 0x004F0330;
        int xOffset2 = 0x1A0;
        int xOffset3 = 0x878;
        int xOffset4 = 0x854;

        int yOffset1 = 0x004F0330;
        int yOffset2 = 0x198;
        int yOffset3 = 0x878;
        int yOffset4 = 0x858;

        Swed swed;
        IntPtr baseModule;
        IntPtr xPointer;
        IntPtr yPointer;

        bool isGameDetected = false;

        public Form1()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 200;
            timer.Tick += Timer_Tick;
            timer.Start();

            Timer pointersTimer = new Timer();
            pointersTimer.Interval = 10;
            pointersTimer.Tick += pointersTimer_Tick;
            pointersTimer.Start();
        }

        float GetX()
        {
            return swed.ReadFloat(xPointer, xOffset4);
        }

        void SetX(float value)
        {
            if (swed.WriteFloat(xPointer, xOffset4, value) == false)
            {
                MessageBox.Show("Failed to write X position. The game may have updated or your software is outdated.");
            }
        }

        float GetY()
        {
            return swed.ReadFloat(yPointer, yOffset4);
        }

        void SetY(float value)
        {
            if (swed.WriteFloat(yPointer, yOffset4, value) == false)
            {
                MessageBox.Show("Failed to write Y position. The game may have updated or your software is outdated.");
            }
        }

        bool ParseFloat(object targetObject, ref float number)
        {
            try
            {
                if (targetObject is string targetString)
                {
                    targetString = targetString.Replace('.', ',');

                    number = Convert.ToSingle(targetString);
                    return true;
                }
                number = number = Convert.ToSingle(targetObject);
                return true;
            }
            catch
            {
                MessageBox.Show("Please enter a number. \nBoth periods and commas are supported as decimal places.", "Bad value entered!");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isGameDetected)
            {
                float target = GetX();
                if (ParseFloat(textBox1.Text, ref target))
                {
                    SetX(target);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isGameDetected)
            {
                float target = GetY();
                if (ParseFloat(textBox2.Text, ref target))
                {
                    SetY(target);
                }
            }
        }

        private void saveResIcon(bool changed)
        {
            if (isGameDetected != changed)
            {
                isGameDetected = changed;
                if (isGameDetected)
                {
                    cuiLabel3.Content = "GD Detected";
                    Icon = Resources.green;
                    cuiLabel3.ForeColor = Color.FromArgb(0, 225, 70);
                    isGameDetected = true;
                }
                else
                {
                    isGameDetected = false;
                    cuiLabel3.Content = "GD Not Detected";
                    Icon = Resources.red;
                    cuiLabel3.ForeColor = Color.Crimson;
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Process.GetProcessesByName("GeometryDash").Length > 0)
                {
                    swed = new Swed("GeometryDash");
                    baseModule = swed.GetModuleBase(".exe");
                    saveResIcon(true);
                }
            }
            catch
            {
                saveResIcon(false);
                cuiLabel1.Content = "??";
                cuiLabel2.Content = "??";
                baseModule = IntPtr.Zero;
                xPointer = IntPtr.Zero;
                yPointer = IntPtr.Zero;
            }
        }

        private void pointersTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                IntPtr Xof1 = swed.ReadPointer(baseModule, xOffset1);
                IntPtr Xof2 = swed.ReadPointer(Xof1, xOffset2);
                xPointer = swed.ReadPointer(Xof2, xOffset3);

                IntPtr Yof1 = swed.ReadPointer(baseModule, yOffset1);
                IntPtr Yof2 = swed.ReadPointer(Yof1, yOffset2);
                yPointer = swed.ReadPointer(Yof2, yOffset3);

                if (xPointer == IntPtr.Zero)
                {
                    cuiLabel1.Content = "??";
                }
                else
                {
                    cuiLabel1.Content = GetX().ToString();
                }

                if (yPointer == IntPtr.Zero)
                {
                    cuiLabel2.Content = "??";
                }
                else
                {
                    cuiLabel2.Content = GetY().ToString();
                }
            }
            catch
            {
                saveResIcon(false);
                cuiLabel1.Content = "??";
                cuiLabel2.Content = "??";
                baseModule = IntPtr.Zero;
                xPointer = IntPtr.Zero;
                yPointer = IntPtr.Zero;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (isGameDetected)
                textBox1.Text = GetX().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isGameDetected)
                textBox2.Text = GetY().ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCWQlxMP_98siaAj3RNjQZvg");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/1Kxhu/GeometryDash-Position-Changer");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cuiLabel1.Content.Contains("?") == false && cuiLabel2.Content.Contains("?") == false)
            {
                string tempItem = cuiLabel1.Content + " " + cuiLabel2.Content;
                listBox1.Items.Add(tempItem);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ListBoxCheck() && isGameDetected)
            {
                string item = listBox1.SelectedItem.ToString();
                string[] positions = item.Split(' ');

                float posX = 0;
                float posY = 0;

                bool xDetected = false;
                bool yDetected = false;

                try
                {
                    posX = float.Parse(positions[0]);
                    xDetected = true;
                    posY = float.Parse(positions[1]);
                    yDetected = true;

                    SetX(posX);
                    SetY(posY);
                }
                catch
                {
                    string message = string.Empty;
                    if (xDetected)
                    {
                        message += $"\nThe x position was detected: x = {posX}";
                    }
                    else
                    {
                        message += $"\nThe x position detection failed.";
                    }

                    if (yDetected)
                    {
                        message += $"\nThe y position was detected: y = {posY}";
                    }
                    else
                    {
                        message += $"\nThe y position detection failed.";
                    }

                    message += "\n\nPlease remember the correct format is \"x y\", where a space is present inbetween the numbers.";

                    MessageBox.Show($"Name: \"{item}\". \n\nMore info: {message}", "Faulty item detected!");
                    return;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ListBoxCheck())
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private bool ListBoxCheck()
        {
            bool temp = listBox1.SelectedItems.Count > 0 && listBox1.SelectedItem != null;
            if (temp == false)
            {
                MessageBox.Show("No item selected or the selected item is null.");
            }
            return temp;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the list?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            saveResIcon(true);
            saveResIcon(false);
        }

        private void cuiSwitch1_Click(object sender, EventArgs e)
        {
            TopMost = !cuiSwitch1.Checked;
        }
    }
}
