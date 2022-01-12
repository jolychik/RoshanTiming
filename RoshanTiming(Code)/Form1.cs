using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RoshanTiming;

namespace WindowsFormsApp1
{
    public partial class ROSH : Form
    {
        public ROSH()
        {
            InitializeComponent();
            label13.Text = RoshanTiming.Properties.Settings.Default.path;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoshanTimer_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        public string MyText
        {
            get { return label13.Text; }
            set { label13.Text = value; }
        }

        public void Calc_Click(object sender, EventArgs e)
        {

                if (label13.Text == "1")
                {
                    this.label6.Location = new System.Drawing.Point(83, 244);
                    this.label11.Location = new System.Drawing.Point(262, 8);
                    if (Minute.Text == "")
                    {
                        label6.Visible = true;
                        label6.ForeColor = Color.Red;
                        label6.Text = ("You didn't enter a minute");
                    }
                    else
                    {
                        Minute.Enabled = false;
                        Second.Enabled = false;
                        Calc.Visible = false;
                        Again.Visible = true;
                        if (Second.Text == "")
                        {
                            Second.Text = "00";
                        }
                        int min = Convert.ToInt32(Minute.Text);
                        int sec = Convert.ToInt32(Second.Text);
                        int time1;
                        int time2;
                        int time3;

                        time1 = min + 5;
                        time2 = min + 8;
                        time3 = min + 11;

                        label1.Text = ("Время смерти рошана - ") + Convert.ToString(min) + (":") + Convert.ToString(sec);

                        label2.Text = ("Время окончания аегиса - ") + Convert.ToString(time1) + (":") + Convert.ToString(sec);

                        label3.Text = ("Время респавна рошана (min) - ") + Convert.ToString(time2) + (":") + Convert.ToString(sec);

                        label4.Text = ("Время респавна рошана (max) - ") + Convert.ToString(time3) + (":") + Convert.ToString(sec);

                    if (checkBox1.Checked == true)
                    {
                        label5.Text =  Convert.ToString(time1) + ("-") + Convert.ToString(sec) + ("  ") + Convert.ToString(time2) + ("-") + Convert.ToString(sec) + ("  ") + Convert.ToString(time3) + ("-") + Convert.ToString(sec);
                    }
                    else
                    {
                        label5.Text = ("Died") + ("(") + Convert.ToString(min) + (":") + Convert.ToString(sec) + (")-Aegis(") + Convert.ToString(time1) + (":") + Convert.ToString(sec) + (")-Res.Min(") + Convert.ToString(time2) + (":") + Convert.ToString(sec) + (")-Res.Max(") + Convert.ToString(time3) + (":") + Convert.ToString(sec) + (")");
                    }
                        panel1.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        //label5.Visible = true;
                        //Copy.Visible = true;

                        if ((Second.Text == "01") || (Second.Text == "02") || (Second.Text == "03") || (Second.Text == "04") || (Second.Text == "05") || (Second.Text == "06") || (Second.Text == "07") || (Second.Text == "08") || (Second.Text == "09") ||
                            (Second.Text == "1") || (Second.Text == "2") || (Second.Text == "3") || (Second.Text == "4") || (Second.Text == "5") || (Second.Text == "6") || (Second.Text == "7") || (Second.Text == "8") || (Second.Text == "9") ||
                            (Second.Text == "0") || (Second.Text == "00"))
                        {
                            label1.Text = ("Время смерти рошана - ") + Convert.ToString(min) + (":") + ("0") + Convert.ToString(sec);

                            label2.Text = ("Время окончания аегиса - ") + Convert.ToString(time1) + (":") + ("0") + Convert.ToString(sec);

                            label3.Text = ("Время респавна рошана (min) - ") + Convert.ToString(time2) + (":") + ("0") + Convert.ToString(sec);

                            label4.Text = ("Время респавна рошана (max) - ") + Convert.ToString(time3) + (":") + ("0") + Convert.ToString(sec);

                        if (checkBox1.Checked == true)
                        {
                            label5.Text = Convert.ToString(time1) + ("-") + ("0") + Convert.ToString(sec) + ("  ") + Convert.ToString(time2) + ("-") + ("0") + Convert.ToString(sec) + ("  ") + Convert.ToString(time3) + ("-") + ("0") + Convert.ToString(sec);
                        }
                        else
                        {
                            label5.Text = ("Died") + ("(") + Convert.ToString(min) + (":") + ("0") + Convert.ToString(sec) + (")-Aegis(") + Convert.ToString(time1) + (":") + ("0") + Convert.ToString(sec) + (")-Res.Min(") + Convert.ToString(time2) + (":") + ("0") + Convert.ToString(sec) + (")-Res.Max(") + Convert.ToString(time3) + (":") + ("0") + Convert.ToString(sec) + (")");
                        }
                        }

                        label5.Visible = true;
                        Clipboard.SetText(label5.Text);
                        label7.Visible = true;
                        panel2.Visible = true;
                        label11.Visible = true;
                        Again.Focus();
                    }
                }
                else
                {
                    this.label6.Location = new System.Drawing.Point(108, 244);
                    this.label11.Location = new System.Drawing.Point(310, 8);
                    if (Minute.Text == "")
                    {
                        label6.Visible = true;
                        label6.ForeColor = Color.Red;
                        label6.Text = ("Вы не ввели минуту");
                    }
                else
                    {
                        Minute.Enabled = false;
                        Second.Enabled = false;
                        Calc.Visible = false;
                        Again.Visible = true;
                        if (Second.Text == "")
                        {
                            Second.Text = "00";
                        }
                        int min = Convert.ToInt32(Minute.Text);
                        int sec = Convert.ToInt32(Second.Text);
                        int time1;
                        int time2;
                        int time3;

                        time1 = min + 5;
                        time2 = min + 8;
                        time3 = min + 11;

                        label1.Text = ("Time of Roshan's death - ") + Convert.ToString(min) + (":") + Convert.ToString(sec);

                        label2.Text = ("End time of Aegis - ") + Convert.ToString(time1) + (":") + Convert.ToString(sec);

                        label3.Text = ("Time of the respawn of Roshan (min) - ") + Convert.ToString(time2) + (":") + Convert.ToString(sec);

                        label4.Text = ("Time of the respawn of Roshan (max) - ") + Convert.ToString(time3) + (":") + Convert.ToString(sec);

                    if (checkBox1.Checked == true)
                    {
                        label5.Text = Convert.ToString(time1) + ("-") + Convert.ToString(sec) + ("  ") + Convert.ToString(time2) + ("-") + Convert.ToString(sec) + ("  ") + Convert.ToString(time3) + ("-") + Convert.ToString(sec);
                    }
                    else
                    {
                        label5.Text = ("Died") + ("(") + Convert.ToString(min) + (":") + Convert.ToString(sec) + (")-Aegis(") + Convert.ToString(time1) + (":") + Convert.ToString(sec) + (")-Res.Min(") + Convert.ToString(time2) + (":") + Convert.ToString(sec) + (")-Res.Max(") + Convert.ToString(time3) + (":") + Convert.ToString(sec) + (")");
                    }

                    panel1.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        //label5.Visible = true;
                        //Copy.Visible = true;

                        if ((Second.Text == "01") || (Second.Text == "02") || (Second.Text == "03") || (Second.Text == "04") || (Second.Text == "05") || (Second.Text == "06") || (Second.Text == "07") || (Second.Text == "08") || (Second.Text == "09") ||
                            (Second.Text == "1") || (Second.Text == "2") || (Second.Text == "3") || (Second.Text == "4") || (Second.Text == "5") || (Second.Text == "6") || (Second.Text == "7") || (Second.Text == "8") || (Second.Text == "9") ||
                            (Second.Text == "0") || (Second.Text == "00"))
                        {
                            label1.Text = ("Time of Roshan's death - ") + Convert.ToString(min) + (":") + ("0") + Convert.ToString(sec);

                            label2.Text = ("End time of Aegis - ") + Convert.ToString(time1) + (":") + ("0") + Convert.ToString(sec);

                            label3.Text = ("Time of the respawn of Roshan (min) - ") + Convert.ToString(time2) + (":") + ("0") + Convert.ToString(sec);

                            label4.Text = ("Time of the respawn of Roshan (max) - ") + Convert.ToString(time3) + (":") + ("0") + Convert.ToString(sec);

                        if (checkBox1.Checked == true)
                        {
                            label5.Text = Convert.ToString(time1) + ("-") + ("0") + Convert.ToString(sec) + ("  ") + Convert.ToString(time2) + ("-") + ("0") + Convert.ToString(sec) + ("  ") + Convert.ToString(time3) + ("-") + ("0") + Convert.ToString(sec);
                        }
                        else
                        {
                            label5.Text = ("Died") + ("(") + Convert.ToString(min) + (":") + ("0") + Convert.ToString(sec) + (")-Aegis(") + Convert.ToString(time1) + (":") + ("0") + Convert.ToString(sec) + (")-Res.Min(") + Convert.ToString(time2) + (":") + ("0") + Convert.ToString(sec) + (")-Res.Max(") + Convert.ToString(time3) + (":") + ("0") + Convert.ToString(sec) + (")");
                        }
                    }

                        label5.Visible = true;
                        Clipboard.SetText(label5.Text);
                        label7.Visible = true;
                        panel2.Visible = true;
                        label11.Visible = true;
                        Again.Focus();
                    }
                }
            }
        

        private void Minute_TextChanged(object sender, EventArgs e)
        {
            Minute.MaxLength = 3;
            Minute.TabIndex = 2;
            Minute.TabStop = true;
        }

        private void Minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
                       char l = e.KeyChar;
                       if ((l < 'А' || l > 'я' ) && e.KeyChar != (char)Keys.Back)
                           e.Handled = true;*/
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Second_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Second_TextChanged(object sender, EventArgs e)
        {
            Second.MaxLength = 2;


            for (int i = 0; i < Second.Text.Length; i++)
                if (!Char.IsDigit(Second.Text[i]))
                    Second.Clear();
        }

        private void RoshanTimer_Load(object sender, EventArgs e)
        {
            if (label13.Text == "1")
            {
                checkBox1.Text = "Simple mode";
                this.checkBox1.Location = new System.Drawing.Point(646, 2);
                ItemMenu1.Text = "Exit the Programm";
                оПрограммеToolStripMenuItem.Text = "About the Programm";
                Lminute.Text = "Enter a minute";
                Lsecond.Text = "Enter a second";
                label6.Text = "You didn't enter a minute";
                Calc.Text = "Calculate and copy";
                Again.Text = "Again";
                label7.Text = "Example";
                label11.Text = "Copy";
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                checkBox1.Text = "Простой режим";
                this.checkBox1.Location = new System.Drawing.Point(627, 3);
                ItemMenu1.Text = "Закрыть программу";
                оПрограммеToolStripMenuItem.Text = "О программе";
                Lminute.Text = "Введите минуту";
                Lsecond.Text = "Введите секунду";
                label6.Text = "Вы не ввели минуту";
                Calc.Text = "Посчитать и скопировать";
                Again.Text = "Заново";
                label7.Text = "Пример";
                label11.Text = "Скопировать";
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void Lsecond_Click(object sender, EventArgs e)
        {

        }

        //private void Back_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    RoshTime MainMenu = new RoshTime();
        //    MainMenu.Show();
        //}


        private void Minute_Enter_1(object sender, EventArgs e)
        {

            label6.Visible = false;
        }

        private void Second_Enter(object sender, EventArgs e)
        {

            label6.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        internal static class GlobabalModule
        {
            public static List<string> CodeList { get; set; }

            public static void InitList()
            {
                CodeList = new List<string>();
            }
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //   label5.Visible = true;
        //    Clipboard.SetText(label5.Text);
        //    label7.Visible = true;
        //    panel2.Visible = true;
        //}

        private void Second_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) ||
             ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9)))
            {
                int Value = Convert.ToInt32(Second.Text);
                if (((Second.Text.Length >= 2) && (Value < 0) || (Value > 59)) ||
                    ((Second.Text.Length < 2) && ((Value < 0) || (Value > 59))))
                    Second.Text = ("59");
            }

        }

        private void c_Click(object sender, EventArgs e)
        {
            Minute.Text = "";
            Second.Text = "";
            panel1.Visible = false;
            panel2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            Minute.Focus();
        }

        private void Again_Click(object sender, EventArgs e)
        {
            Minute.Text = "";
            Second.Text = "";
            Minute.TabIndex = 0;
            Second.TabIndex = 1;
            Again.TabIndex = 2;
            panel1.Visible = false;
            panel2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            Again.Visible = false;
            Calc.Visible = true;
            label11.Visible = false;
            Minute.Enabled = true;
            Second.Enabled = true;
            Minute.Focus();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label5.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Minute.Text = "";
            Second.Text = "";
            Minute.TabIndex = 0;
            Second.TabIndex = 1;
            Again.TabIndex = 2;
            panel1.Visible = false;
            panel2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            Again.Visible = false;
            Calc.Visible = true;
            label11.Visible = false;
            Minute.Focus();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        private void ItemMenu1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AboutBox AB = new AboutBox();
            label13.Text = "1";
            AB.Text = "About th program RoshanTiming";

            if (label13.Text == "1")
            {
                checkBox1.Text = "Simple mode";
                this.checkBox1.Location = new System.Drawing.Point(646, 2);
                this.label6.Location = new System.Drawing.Point(83, 244);
                this.label11.Location = new System.Drawing.Point(310, 8);
                ItemMenu1.Text = "Exit the Program";
                оПрограммеToolStripMenuItem.Text = "About the Program";
                Lminute.Text = "Enter a minute";
                Lsecond.Text = "Enter a second";
                label6.Text = "You didn't enter a minute";
                Calc.Text = "Calculate and copy";
                Again.Text = "Again";
                label7.Text = "Example";
                label11.Text = "Copy";
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

            }
            RoshanTiming.Properties.Settings.Default.path = label13.Text;

            RoshanTiming.Properties.Settings.Default.Save();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AboutBox AB = new AboutBox();
            label13.Text = "2";
            AB.Text = String.Format("О программе {0}", AB.AssemblyTitle);

            if (label13.Text == "2")
            {
                checkBox1.Text = "Простой режим";
                this.checkBox1.Location = new System.Drawing.Point(627, 3);
                this.label6.Location = new System.Drawing.Point(108, 244);
                this.label11.Location = new System.Drawing.Point(262, 8);
                ItemMenu1.Text = "Закрыть программу";
                оПрограммеToolStripMenuItem.Text = "О программе";
                Lminute.Text = "Введите минуту";
                Lsecond.Text = "Введите секунду";
                label6.Text = "Вы не ввели минуту";
                Calc.Text = "Посчитать и скопировать";
                Again.Text = "Заново";
                label7.Text = "Пример";
                label11.Text = "Скопировать";
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            RoshanTiming.Properties.Settings.Default.path = label13.Text;

            RoshanTiming.Properties.Settings.Default.Save();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t2 = new ToolTip();
            t2.SetToolTip(pictureBox1, "Русский язык");
        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox2, "English language");
        }

    }
}
