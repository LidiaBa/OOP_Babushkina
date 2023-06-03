namespace Курсовая_ООП
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MytabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.StartGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.Choselevel = new System.Windows.Forms.Label();
            this.level3 = new System.Windows.Forms.Button();
            this.level2 = new System.Windows.Forms.Button();
            this.level1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rezult = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Varify = new System.Windows.Forms.Button();
            this.levelnomber = new System.Windows.Forms.TextBox();
            this.endlevel = new System.Windows.Forms.Button();
            this.nextlevel = new System.Windows.Forms.Button();
            this.MyNomber = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.EndGame = new System.Windows.Forms.Button();
            this.LastResult = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerResult = new System.Windows.Forms.TextBox();
            this.Backmenu = new System.Windows.Forms.Button();
            this.YourResult = new System.Windows.Forms.Label();
            this.writename = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.game = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MytabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MytabControl
            // 
            this.MytabControl.Controls.Add(this.tabPage1);
            this.MytabControl.Controls.Add(this.tabPage2);
            this.MytabControl.Controls.Add(this.tabPage3);
            this.MytabControl.Controls.Add(this.tabPage4);
            this.MytabControl.Location = new System.Drawing.Point(-3, 1);
            this.MytabControl.Name = "MytabControl";
            this.MytabControl.SelectedIndex = 0;
            this.MytabControl.Size = new System.Drawing.Size(1239, 567);
            this.MytabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.StartGame);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1231, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Старт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(295, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(634, 129);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пройдите игру на запоминание чисел и узнайте\r\nна сколько хорошо развита ваша памя" +
    "ть! \r\nУдачи в прохождении!";
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Turquoise;
            this.StartGame.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartGame.Location = new System.Drawing.Point(463, 384);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(250, 87);
            this.StartGame.TabIndex = 8;
            this.StartGame.Text = "Начать игру";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(344, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(508, 53);
            this.label3.TabIndex = 7;
            this.label3.Text = "Игра \"Запоминание чисел\"";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Choselevel);
            this.tabPage2.Controls.Add(this.level3);
            this.tabPage2.Controls.Add(this.level2);
            this.tabPage2.Controls.Add(this.level1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1231, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Уровни";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(356, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 53);
            this.label2.TabIndex = 6;
            // 
            // Choselevel
            // 
            this.Choselevel.AutoSize = true;
            this.Choselevel.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Choselevel.Location = new System.Drawing.Point(485, 64);
            this.Choselevel.Name = "Choselevel";
            this.Choselevel.Size = new System.Drawing.Size(249, 43);
            this.Choselevel.TabIndex = 5;
            this.Choselevel.Text = "Выберите уровень";
            // 
            // level3
            // 
            this.level3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.level3.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.level3.Location = new System.Drawing.Point(530, 360);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(147, 49);
            this.level3.TabIndex = 2;
            this.level3.Text = "Уровень 3";
            this.level3.UseVisualStyleBackColor = false;
            this.level3.Click += new System.EventHandler(this.level3_Click);
            // 
            // level2
            // 
            this.level2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.level2.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.level2.Location = new System.Drawing.Point(530, 275);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(147, 47);
            this.level2.TabIndex = 1;
            this.level2.Text = "Уровень 2";
            this.level2.UseVisualStyleBackColor = false;
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.Color.Turquoise;
            this.level1.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.level1.Location = new System.Drawing.Point(530, 189);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(147, 48);
            this.level1.TabIndex = 0;
            this.level1.Text = "Уровень 1";
            this.level1.UseVisualStyleBackColor = false;
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.Varify);
            this.tabPage3.Controls.Add(this.levelnomber);
            this.tabPage3.Controls.Add(this.endlevel);
            this.tabPage3.Controls.Add(this.nextlevel);
            this.tabPage3.Controls.Add(this.MyNomber);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1231, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Игра";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rezult);
            this.panel1.Controls.Add(this.Ok);
            this.panel1.Location = new System.Drawing.Point(331, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 297);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(550, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 155);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // rezult
            // 
            this.rezult.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rezult.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rezult.Location = new System.Drawing.Point(72, 51);
            this.rezult.Multiline = true;
            this.rezult.Name = "rezult";
            this.rezult.Size = new System.Drawing.Size(404, 138);
            this.rezult.TabIndex = 6;
            this.rezult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.Turquoise;
            this.Ok.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ok.Location = new System.Drawing.Point(191, 211);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(150, 61);
            this.Ok.TabIndex = 7;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click_1);
            // 
            // Varify
            // 
            this.Varify.BackColor = System.Drawing.Color.Turquoise;
            this.Varify.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Varify.Location = new System.Drawing.Point(504, 358);
            this.Varify.Name = "Varify";
            this.Varify.Size = new System.Drawing.Size(196, 103);
            this.Varify.TabIndex = 5;
            this.Varify.Text = "Проверить";
            this.Varify.UseVisualStyleBackColor = false;
            this.Varify.Visible = false;
            this.Varify.Click += new System.EventHandler(this.Varify_Click);
            // 
            // levelnomber
            // 
            this.levelnomber.BackColor = System.Drawing.Color.Thistle;
            this.levelnomber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.levelnomber.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.levelnomber.Location = new System.Drawing.Point(552, 106);
            this.levelnomber.Multiline = true;
            this.levelnomber.Name = "levelnomber";
            this.levelnomber.Size = new System.Drawing.Size(90, 45);
            this.levelnomber.TabIndex = 4;
            this.levelnomber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endlevel
            // 
            this.endlevel.BackColor = System.Drawing.Color.PeachPuff;
            this.endlevel.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.endlevel.Location = new System.Drawing.Point(187, 358);
            this.endlevel.Name = "endlevel";
            this.endlevel.Size = new System.Drawing.Size(205, 103);
            this.endlevel.TabIndex = 3;
            this.endlevel.Text = "Закончить игру";
            this.endlevel.UseVisualStyleBackColor = false;
            this.endlevel.Visible = false;
            this.endlevel.Click += new System.EventHandler(this.endlevel_Click);
            // 
            // nextlevel
            // 
            this.nextlevel.BackColor = System.Drawing.Color.PaleGreen;
            this.nextlevel.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nextlevel.Location = new System.Drawing.Point(813, 358);
            this.nextlevel.Name = "nextlevel";
            this.nextlevel.Size = new System.Drawing.Size(202, 103);
            this.nextlevel.TabIndex = 2;
            this.nextlevel.Text = "Следующий уровень";
            this.nextlevel.UseVisualStyleBackColor = false;
            this.nextlevel.Visible = false;
            this.nextlevel.Click += new System.EventHandler(this.nextlevel_Click);
            // 
            // MyNomber
            // 
            this.MyNomber.BackColor = System.Drawing.Color.Thistle;
            this.MyNomber.Location = new System.Drawing.Point(425, 196);
            this.MyNomber.Name = "MyNomber";
            this.MyNomber.Size = new System.Drawing.Size(347, 45);
            this.MyNomber.TabIndex = 1;
            this.MyNomber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MyNomber.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage4.Controls.Add(this.EndGame);
            this.tabPage4.Controls.Add(this.LastResult);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.PlayerResult);
            this.tabPage4.Controls.Add(this.Backmenu);
            this.tabPage4.Controls.Add(this.YourResult);
            this.tabPage4.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1231, 529);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Результаты";
            // 
            // EndGame
            // 
            this.EndGame.BackColor = System.Drawing.Color.PeachPuff;
            this.EndGame.Location = new System.Drawing.Point(965, 384);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(197, 103);
            this.EndGame.TabIndex = 6;
            this.EndGame.Text = "Закончить игру";
            this.EndGame.UseVisualStyleBackColor = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // LastResult
            // 
            this.LastResult.BackColor = System.Drawing.Color.PaleGreen;
            this.LastResult.Location = new System.Drawing.Point(499, 387);
            this.LastResult.Name = "LastResult";
            this.LastResult.Size = new System.Drawing.Size(197, 100);
            this.LastResult.TabIndex = 5;
            this.LastResult.Text = "Прошлые результаты";
            this.LastResult.UseVisualStyleBackColor = false;
            this.LastResult.Click += new System.EventHandler(this.LastResult_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(161, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 256);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Date,
            this.L1,
            this.L2,
            this.L3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(866, 256);
            this.dataGridView1.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 300;
            // 
            // L1
            // 
            this.L1.HeaderText = "Уровень1, %";
            this.L1.MinimumWidth = 8;
            this.L1.Name = "L1";
            this.L1.Width = 150;
            // 
            // L2
            // 
            this.L2.HeaderText = "Уровень2, %";
            this.L2.MinimumWidth = 8;
            this.L2.Name = "L2";
            this.L2.Width = 150;
            // 
            // L3
            // 
            this.L3.HeaderText = "Уровень3, %";
            this.L3.MinimumWidth = 8;
            this.L3.Name = "L3";
            this.L3.Width = 150;
            // 
            // PlayerResult
            // 
            this.PlayerResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PlayerResult.Font = new System.Drawing.Font("Segoe Print", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PlayerResult.Location = new System.Drawing.Point(247, 69);
            this.PlayerResult.Multiline = true;
            this.PlayerResult.Name = "PlayerResult";
            this.PlayerResult.Size = new System.Drawing.Size(691, 253);
            this.PlayerResult.TabIndex = 2;
            // 
            // Backmenu
            // 
            this.Backmenu.BackColor = System.Drawing.Color.Turquoise;
            this.Backmenu.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Backmenu.Location = new System.Drawing.Point(44, 384);
            this.Backmenu.Name = "Backmenu";
            this.Backmenu.Size = new System.Drawing.Size(197, 101);
            this.Backmenu.TabIndex = 1;
            this.Backmenu.Text = "Вернуться в меню";
            this.Backmenu.UseVisualStyleBackColor = false;
            this.Backmenu.Click += new System.EventHandler(this.Backmenu_Click);
            // 
            // YourResult
            // 
            this.YourResult.AutoSize = true;
            this.YourResult.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YourResult.Location = new System.Drawing.Point(426, 13);
            this.YourResult.Name = "YourResult";
            this.YourResult.Size = new System.Drawing.Size(362, 53);
            this.YourResult.TabIndex = 0;
            this.YourResult.Text = "Ваши результаты";
            // 
            // writename
            // 
            this.writename.Location = new System.Drawing.Point(0, 0);
            this.writename.Name = "writename";
            this.writename.Size = new System.Drawing.Size(100, 23);
            this.writename.TabIndex = 0;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(0, 0);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(0, 0);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 31);
            this.textBoxName.TabIndex = 0;
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.Font = new System.Drawing.Font("Segoe Print", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.game.Location = new System.Drawing.Point(416, 60);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(408, 50);
            this.game.TabIndex = 2;
            this.game.Text = "Игра \"Запоминание чисел\"";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1228, 45);
            this.panel3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MytabControl);
            this.Name = "Form1";
            this.Text = "Запоминалка";
            this.MytabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MytabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label writename;
        private Button next;
        private TextBox textBoxName;
        private Label Choselevel;
        private Button level3;
        private Button level2;
        private Button level1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button endlevel;
        private Button nextlevel;
        private TextBox MyNomber;
        private TextBox levelnomber;
        private Button Varify;
        private TextBox rezult;
        private Panel panel1;
        private Button Ok;
        private PictureBox pictureBox1;
        private TextBox PlayerResult;
        private Button Backmenu;
        private Label YourResult;
        private Label game;
        private Label label2;
        private Label label4;
        private Button StartGame;
        private Label label3;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button EndGame;
        private Button LastResult;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn L1;
        private DataGridViewTextBoxColumn L2;
        private DataGridViewTextBoxColumn L3;
        private Panel panel3;
    }
}