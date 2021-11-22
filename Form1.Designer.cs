namespace ExpertSystem
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.label1 = new System.Windows.Forms.Label();
            this.Btime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ChBLower = new System.Windows.Forms.CheckBox();
            this.ChBHigher = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBAt = new System.Windows.Forms.ComboBox();
            this.CBDef = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Bbudg = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GetRes = new System.Windows.Forms.Button();
            this.TBRes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Btime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bbudg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сколько часов в неделю вы играете в FIFA?  (1-18)";
            // 
            // Btime
            // 
            this.Btime.Location = new System.Drawing.Point(94, 118);
            this.Btime.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Btime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Btime.Name = "Btime";
            this.Btime.Size = new System.Drawing.Size(58, 20);
            this.Btime.TabIndex = 1;
            this.Btime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оцените уровень вашего мастерства:";
            // 
            // ChBLower
            // 
            this.ChBLower.AutoSize = true;
            this.ChBLower.Location = new System.Drawing.Point(15, 35);
            this.ChBLower.Name = "ChBLower";
            this.ChBLower.Size = new System.Drawing.Size(104, 17);
            this.ChBLower.TabIndex = 3;
            this.ChBLower.Text = "Ниже среднего";
            this.ChBLower.UseVisualStyleBackColor = true;
            // 
            // ChBHigher
            // 
            this.ChBHigher.AutoSize = true;
            this.ChBHigher.Location = new System.Drawing.Point(132, 35);
            this.ChBHigher.Name = "ChBHigher";
            this.ChBHigher.Size = new System.Drawing.Size(105, 17);
            this.ChBHigher.TabIndex = 4;
            this.ChBHigher.Text = "Выше среднего";
            this.ChBHigher.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите предпочтительный стиль атаки:";
            // 
            // CBAt
            // 
            this.CBAt.FormattingEnabled = true;
            this.CBAt.Items.AddRange(new object[] {
            "Быстрые атаки",
            "Владение мячом",
            "Контрвыпады"});
            this.CBAt.Location = new System.Drawing.Point(315, 35);
            this.CBAt.Name = "CBAt";
            this.CBAt.Size = new System.Drawing.Size(209, 21);
            this.CBAt.TabIndex = 7;
            this.CBAt.Text = "Стиль атаки";
            // 
            // CBDef
            // 
            this.CBDef.FormattingEnabled = true;
            this.CBDef.Items.AddRange(new object[] {
            "Агрессивный прессинг",
            "Умеренный прессинг",
            "Оборона на своей половине"});
            this.CBDef.Location = new System.Drawing.Point(315, 107);
            this.CBDef.Name = "CBDef";
            this.CBDef.Size = new System.Drawing.Size(209, 21);
            this.CBDef.TabIndex = 9;
            this.CBDef.Text = "Стиль защиты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выберите предпочтительный стиль защиты:";
            // 
            // Bbudg
            // 
            this.Bbudg.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Bbudg.Location = new System.Drawing.Point(715, 73);
            this.Bbudg.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Bbudg.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Bbudg.Name = "Bbudg";
            this.Bbudg.Size = new System.Drawing.Size(79, 20);
            this.Bbudg.TabIndex = 11;
            this.Bbudg.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введите доступный бюджет на формирование ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "команды в тысячах (100-1000)";
            // 
            // GetRes
            // 
            this.GetRes.Location = new System.Drawing.Point(623, 147);
            this.GetRes.Name = "GetRes";
            this.GetRes.Size = new System.Drawing.Size(135, 36);
            this.GetRes.TabIndex = 15;
            this.GetRes.Text = "Получить результат!";
            this.GetRes.UseVisualStyleBackColor = true;
            this.GetRes.Click += new System.EventHandler(this.GetRes_Click);
            // 
            // TBRes
            // 
            this.TBRes.Location = new System.Drawing.Point(44, 200);
            this.TBRes.Multiline = true;
            this.TBRes.Name = "TBRes";
            this.TBRes.Size = new System.Drawing.Size(714, 216);
            this.TBRes.TabIndex = 16;
            this.TBRes.Text = "Здесь может быть ваш результат";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.TBRes);
            this.Controls.Add(this.GetRes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Bbudg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBDef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBAt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChBHigher);
            this.Controls.Add(this.ChBLower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btime);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Экспертная система FIFA";
            ((System.ComponentModel.ISupportInitialize)(this.Btime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bbudg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Btime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChBLower;
        private System.Windows.Forms.CheckBox ChBHigher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBAt;
        private System.Windows.Forms.ComboBox CBDef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Bbudg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GetRes;
        private System.Windows.Forms.TextBox TBRes;
    }
}

