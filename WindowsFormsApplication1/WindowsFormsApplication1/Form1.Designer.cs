namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.coursebox = new System.Windows.Forms.GroupBox();
            this.cr3 = new System.Windows.Forms.RadioButton();
            this.cr2 = new System.Windows.Forms.RadioButton();
            this.cr5 = new System.Windows.Forms.RadioButton();
            this.cr4 = new System.Windows.Forms.RadioButton();
            this.cr1 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grouppanel = new System.Windows.Forms.Panel();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.sexpanel = new System.Windows.Forms.Panel();
            this.sexw = new System.Windows.Forms.RadioButton();
            this.sexm = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.house = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.writebutton = new System.Windows.Forms.Button();
            this.readbutton = new System.Windows.Forms.Button();
            this.coursebox.SuspendLayout();
            this.grouppanel.SuspendLayout();
            this.sexpanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(13, 30);
            this.name.MaxLength = 20;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(124, 20);
            this.name.TabIndex = 2;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(13, 69);
            this.surname.MaxLength = 20;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(124, 20);
            this.surname.TabIndex = 3;
            this.surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(13, 108);
            this.lastname.MaxLength = 20;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(124, 20);
            this.lastname.TabIndex = 5;
            this.lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastname_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ваш возраст";
            // 
            // age
            // 
            this.age.FormattingEnabled = true;
            this.age.Items.AddRange(new object[] {
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30});
            this.age.Location = new System.Drawing.Point(186, 29);
            this.age.MaxLength = 3;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(35, 21);
            this.age.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Информационные системы и технологии",
            "Программное обеспечение информационных технологий",
            "Дизайн электронных  и веб изданий",
            "Программное обеспечение и безопасность мобильных систем"});
            this.listBox1.Location = new System.Drawing.Point(186, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 30);
            this.listBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Специальность";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(429, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Когда царь родился";
            // 
            // coursebox
            // 
            this.coursebox.Controls.Add(this.cr3);
            this.coursebox.Controls.Add(this.cr2);
            this.coursebox.Controls.Add(this.cr5);
            this.coursebox.Controls.Add(this.cr4);
            this.coursebox.Controls.Add(this.cr1);
            this.coursebox.Location = new System.Drawing.Point(186, 108);
            this.coursebox.Name = "coursebox";
            this.coursebox.Size = new System.Drawing.Size(190, 36);
            this.coursebox.TabIndex = 12;
            this.coursebox.TabStop = false;
            this.coursebox.Text = "Курс";
            // 
            // cr3
            // 
            this.cr3.AutoSize = true;
            this.cr3.Location = new System.Drawing.Point(75, 13);
            this.cr3.Name = "cr3";
            this.cr3.Size = new System.Drawing.Size(31, 17);
            this.cr3.TabIndex = 4;
            this.cr3.TabStop = true;
            this.cr3.Text = "3";
            this.cr3.UseVisualStyleBackColor = true;
            // 
            // cr2
            // 
            this.cr2.AutoSize = true;
            this.cr2.Location = new System.Drawing.Point(38, 13);
            this.cr2.Name = "cr2";
            this.cr2.Size = new System.Drawing.Size(31, 17);
            this.cr2.TabIndex = 3;
            this.cr2.TabStop = true;
            this.cr2.Text = "2";
            this.cr2.UseVisualStyleBackColor = true;
            // 
            // cr5
            // 
            this.cr5.AutoSize = true;
            this.cr5.Location = new System.Drawing.Point(149, 13);
            this.cr5.Name = "cr5";
            this.cr5.Size = new System.Drawing.Size(31, 17);
            this.cr5.TabIndex = 2;
            this.cr5.TabStop = true;
            this.cr5.Text = "5";
            this.cr5.UseVisualStyleBackColor = true;
            // 
            // cr4
            // 
            this.cr4.AutoSize = true;
            this.cr4.Location = new System.Drawing.Point(112, 13);
            this.cr4.Name = "cr4";
            this.cr4.Size = new System.Drawing.Size(31, 17);
            this.cr4.TabIndex = 1;
            this.cr4.TabStop = true;
            this.cr4.Text = "4";
            this.cr4.UseVisualStyleBackColor = true;
            // 
            // cr1
            // 
            this.cr1.AutoSize = true;
            this.cr1.Location = new System.Drawing.Point(7, 13);
            this.cr1.Name = "cr1";
            this.cr1.Size = new System.Drawing.Size(31, 17);
            this.cr1.TabIndex = 0;
            this.cr1.TabStop = true;
            this.cr1.Text = "1";
            this.cr1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(510, 464);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // grouppanel
            // 
            this.grouppanel.Controls.Add(this.r3);
            this.grouppanel.Controls.Add(this.r2);
            this.grouppanel.Controls.Add(this.r1);
            this.grouppanel.Location = new System.Drawing.Point(13, 146);
            this.grouppanel.Name = "grouppanel";
            this.grouppanel.Size = new System.Drawing.Size(124, 27);
            this.grouppanel.TabIndex = 14;
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Location = new System.Drawing.Point(78, 5);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(31, 17);
            this.r3.TabIndex = 2;
            this.r3.TabStop = true;
            this.r3.Text = "3";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(41, 5);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(31, 17);
            this.r2.TabIndex = 1;
            this.r2.TabStop = true;
            this.r2.Text = "2";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(4, 4);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(31, 17);
            this.r1.TabIndex = 0;
            this.r1.TabStop = true;
            this.r1.Text = "1";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Группа";
            // 
            // sexpanel
            // 
            this.sexpanel.Controls.Add(this.sexw);
            this.sexpanel.Controls.Add(this.sexm);
            this.sexpanel.Location = new System.Drawing.Point(282, 29);
            this.sexpanel.Name = "sexpanel";
            this.sexpanel.Size = new System.Drawing.Size(94, 21);
            this.sexpanel.TabIndex = 16;
            // 
            // sexw
            // 
            this.sexw.AutoSize = true;
            this.sexw.Location = new System.Drawing.Point(55, 2);
            this.sexw.Name = "sexw";
            this.sexw.Size = new System.Drawing.Size(36, 17);
            this.sexw.TabIndex = 1;
            this.sexw.TabStop = true;
            this.sexw.Text = "Ж";
            this.sexw.UseVisualStyleBackColor = true;
            // 
            // sexm
            // 
            this.sexm.AutoSize = true;
            this.sexm.Location = new System.Drawing.Point(4, 1);
            this.sexm.Name = "sexm";
            this.sexm.Size = new System.Drawing.Size(34, 17);
            this.sexm.TabIndex = 0;
            this.sexm.TabStop = true;
            this.sexm.Text = "M";
            this.sexm.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Пол";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.house);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.street);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.index);
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(151, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адрес";
            // 
            // house
            // 
            this.house.Location = new System.Drawing.Point(142, 35);
            this.house.MaxLength = 20;
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(69, 20);
            this.house.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Дом";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(142, 74);
            this.street.MaxLength = 20;
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(124, 20);
            this.street.TabIndex = 30;
            this.street.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Улица";
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(6, 74);
            this.index.MaxLength = 20;
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(124, 20);
            this.index.TabIndex = 28;
            this.index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(6, 35);
            this.city.MaxLength = 20;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(124, 20);
            this.city.TabIndex = 27;
            this.city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Индекс";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Город";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(2, 312);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(502, 175);
            this.info.TabIndex = 19;
            // 
            // writebutton
            // 
            this.writebutton.Location = new System.Drawing.Point(149, 265);
            this.writebutton.Name = "writebutton";
            this.writebutton.Size = new System.Drawing.Size(278, 23);
            this.writebutton.TabIndex = 20;
            this.writebutton.Text = "Записать данные";
            this.writebutton.UseVisualStyleBackColor = true;
            this.writebutton.Click += new System.EventHandler(this.writebutton_Click);
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(510, 310);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(100, 148);
            this.readbutton.TabIndex = 21;
            this.readbutton.Text = "Вывести данные";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 488);
            this.Controls.Add(this.readbutton);
            this.Controls.Add(this.writebutton);
            this.Controls.Add(this.info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sexpanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grouppanel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.coursebox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Студент";
            this.coursebox.ResumeLayout(false);
            this.coursebox.PerformLayout();
            this.grouppanel.ResumeLayout(false);
            this.grouppanel.PerformLayout();
            this.sexpanel.ResumeLayout(false);
            this.sexpanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox age;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox coursebox;
        private System.Windows.Forms.RadioButton cr3;
        private System.Windows.Forms.RadioButton cr2;
        private System.Windows.Forms.RadioButton cr5;
        private System.Windows.Forms.RadioButton cr4;
        private System.Windows.Forms.RadioButton cr1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel grouppanel;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel sexpanel;
        private System.Windows.Forms.RadioButton sexw;
        private System.Windows.Forms.RadioButton sexm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox house;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Button writebutton;
        private System.Windows.Forms.Button readbutton;
    }
}

