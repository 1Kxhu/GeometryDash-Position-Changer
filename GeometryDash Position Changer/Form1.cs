using Swed32;
using System;
using System.Diagnostics;
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
            timer.Interval = 4;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        float GetX()
        {
            return swed.ReadFloat(xPointer, xOffset4);
        }

        void SetX(float value)
        {
            swed.WriteFloat(xPointer, xOffset4, value);
        }

        float GetY()
        {
            return swed.ReadFloat(yPointer, yOffset4);
        }

        void SetY(float value)
        {
            swed.WriteFloat(yPointer, yOffset4, value);
        }

        float ParseFloat(object targetObject)
        {
            try
            {
                if (targetObject is string targetString)
                {
                    targetString = targetString.Replace('.', ',');
                    return Convert.ToSingle(targetString);
                }
                return Convert.ToSingle(targetObject);
            }
            catch
            {
                MessageBox.Show("Wrong value entered!");
                return 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isGameDetected)
                SetX(ParseFloat(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isGameDetected)
                SetY(ParseFloat(textBox2.Text));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Process.GetProcessesByName("GeometryDash").Length > 0)
                {
                    swed = new Swed("GeometryDash");
                    baseModule = swed.GetModuleBase(".exe");
                    cuiLabel3.Content = "GD Detected";
                    cuiLabel3.ForeColor = System.Drawing.Color.Green;
                    isGameDetected = true;
                }

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
                isGameDetected = false;
                cuiLabel3.Content = "GD Not Detected";
                cuiLabel3.ForeColor = System.Drawing.Color.Crimson;
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
                string tempItem = cuiLabel1.Content + "|" + cuiLabel2.Content;
                listBox1.Items.Add(tempItem);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ListBoxCheck() && isGameDetected)
            {
                string item = listBox1.SelectedItem.ToString();
                string[] positions = item.Split('|');

                try
                {
                    float posX = float.Parse(positions[0]);
                    float posY = float.Parse(positions[1]);

                    SetX(posX);
                    SetY(posY);
                }
                catch
                {
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
    }
}
