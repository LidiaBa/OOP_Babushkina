using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Npgsql;


namespace Курсовая_ООП
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private int multiplier;
        private int NumberCount = 3;
        private string level_text = "";
        private int trueanswer = 0;
        private int[] count = new int[3];
        private int[] rcount = new int[3];
        private int[] pcount = new int[3];
        private int l = 0;
        private bool t = true;
        private bool corect = true;
        private void StartGame_Click(object sender, EventArgs e)
        {
            MytabControl.SelectTab("tabPage2");
        }
        private void level1_Click(object sender, EventArgs e)
        {

            MytabControl.SelectTab("tabPage3");
            ResetGame();
            l=0;
            multiplier = 1;
            Nomber(multiplier);
        }
        private void level2_Click(object sender, EventArgs e)
        {
            MytabControl.SelectTab("tabPage3");
            ResetGame();
            l = 1;
            multiplier = 10;
            Nomber(multiplier);
        }
        private void level3_Click(object sender, EventArgs e)
        {
            MytabControl.SelectTab("tabPage3");
            ResetGame();
            l = 2;
           
            multiplier = 100;
            Nomber(multiplier);
        }
        private void Nomber(int multiplier)
        {
            levelnomber.Visible = true;
            Task.Delay(1000).GetAwaiter().GetResult();
            Random rd = new Random();
            int[] mass = new int[NumberCount];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rd.Next(multiplier, (10 * multiplier) - 1);
                level_text += mass[i] + " ";
                levelnomber.Text = mass[i].ToString();
                Task.Delay(1000).GetAwaiter().GetResult();
                levelnomber.Text = "";
                Task.Delay(500).GetAwaiter().GetResult();
            }

            Varify.Visible = true;
            MyNomber.Visible = true;
            levelnomber.Visible = false;
        }
        private void Varify_Click(object sender, EventArgs e)
        {
            MyNom();
        }
        private void MyNom()
        {
            List<int> Mymass = new List<int>();
            List<int> Rmass = new List<int>();
            try
            {
                Rmass = level_text.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToList();
                Mymass = MyNomber.Text.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToList();
                corect = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка! Вы ввели не корректные данные!");
                corect = false;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Ошибка! Вы ввели не корректные данные!");
                corect = false;
            }

            if (Rmass.Count == Mymass.Count)
            {
                for (int i = 0; i < Rmass.Count; i++)
                {
                    if (Mymass[i] == Rmass[i])
                    {
                        trueanswer++;
                    }
                }
            }
            else if (corect == true)
            {
                if (Mymass.Count > NumberCount)
                {
                    MessageBox.Show("Ошибка! Вы ввели больше данных!");
                }
                else
                {
                    MessageBox.Show("Ошибка! Вы ввели меньше чисел, чем было выведено или вовсе не ввели данные!");
                }
            }
            rcount[l] += trueanswer;
            MyNomber.Visible = false;
            Varify.Visible = false;
            if (trueanswer == NumberCount)
            {
                rezult.Text = "Молодец!Всё верно!";
                panel1.Visible = true;
                count[l]++;
            }
            else
            {
                rezult.Text = "Правильных ответов " + trueanswer + " из " + NumberCount + "\n Попробуйте заново!";
                panel1.Visible = true;
                count[l]++;
            }
        }
        private void Ok_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if (trueanswer == NumberCount)
            {
                ResetGame();
                if (l != 2)
                {
                    endlevel.Visible = true;
                    nextlevel.Visible = true;
                }
                else
                {
                    EndResult();
                    End();
                    MytabControl.SelectTab("tabPage4");
                }
            }
            else
            {
                MyNomber.Visible = false;
                Varify.Visible = false;
                ResetGame();
                Nomber(multiplier);
            }

        }
        private void nextlevel_Click(object sender, EventArgs e)
        {

            multiplier *= 10;
            Varify.Visible = false;
            endlevel.Visible = false;
            nextlevel.Visible = false;
            Nomber(multiplier);
            l++;

        }
        private void endlevel_Click(object sender, EventArgs e)
        {

            MytabControl.SelectTab("tabPage4");
            EndResult();
            End();
        }
        private void EndResult()
        {
            for (int i = 0; i <= 2; i++)
            {
                if (count[i] != 0)
                {
                    pcount[i] = rcount[i] * 100 / (count[i] * NumberCount);
                    PlayerResult.Text += $"Уровень {i + 1}: \n Попыток-{count[i]}, Правильных ответов - {pcount[i]}% ";
                }
                else
                {
                    pcount[i] = 0;
                }
            }
        }
        private void End()
        {

            using (GameContext db = new GameContext())
            {

                Game game1 = new()
                {
                    Level1try = count[0],
                    True1 = pcount[0],
                    Level2try = count[1],
                    True2 = pcount[1],
                    Level3try = count[2],
                    True3 = pcount[2]
                };
                db.Games.Add(game1);
                db.SaveChanges();
            }
            

        }
        private void LastResult_Click(object sender, EventArgs e)
        {
            if (t)
            {
                panel2.Visible = true;
                ShowResult();
                YourResult.Text = "Все результаты";
                LastResult.Text = "Результаты игры";
                t = !t;


            }
            else
            {
                panel2.Visible = false;
                YourResult.Text = "Ваши результаты";
                LastResult.Text = "Прошлые результаты";
                t = !t;

            }
        }
        private void ShowResult()
        {
            using (GameContext db = new GameContext())
            {
                
                dataGridView1.RowCount = db.Games.Count();
                var res = db.Games.ToList();
                int i = 0;
                foreach (var item in res)
                {
                    dataGridView1[0, i].Value = i+1;
                    dataGridView1[1, i].Value = item.Datatime;
                    dataGridView1[2, i].Value = item.True1;
                    dataGridView1[3, i].Value = item.True2;
                    dataGridView1[4, i].Value = item.True3;
                    i++;
                }
                
            }
        }
        private void Backmenu_Click(object sender, EventArgs e)
        {
            MytabControl.SelectTab("tabPage2");
            rezult.Text = "";
            PlayerResult.Text = "";
            YourResult.Text = "Ваши результаты";
            LastResult.Text = "Прошлые результаты";
            t = true;
            panel2.Visible = false;
            for (int i = 0; i < NumberCount; i++)
            {
                count[i] = 0;
                rcount[i] = 0;
                pcount[i] = 0;
            }


        }
        private void EndGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ResetGame()
        {
            level_text = "";
            MyNomber.Text = "";
            MyNomber.Visible = false;
            Varify.Visible = false;
            endlevel.Visible = false;
            nextlevel.Visible = false;
            trueanswer = 0;
        }

    }
}