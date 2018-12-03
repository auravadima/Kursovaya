namespace Kursach
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.searchBtn = new System.Windows.Forms.Button();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.keyWordCheck = new System.Windows.Forms.CheckBox();
            this.targetTypeLabel = new System.Windows.Forms.Label();
            this.targetTypeText = new System.Windows.Forms.TextBox();
            this.keyWordText = new System.Windows.Forms.RichTextBox();
            this.targetText = new System.Windows.Forms.TextBox();
            this.weaponText = new System.Windows.Forms.TextBox();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isSuccess = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.successCheck = new System.Windows.Forms.CheckBox();
            this.woundCheck = new System.Windows.Forms.CheckBox();
            this.killCheck = new System.Windows.Forms.CheckBox();
            this.successLabel = new System.Windows.Forms.Label();
            this.woundNumeric = new System.Windows.Forms.NumericUpDown();
            this.woundLabel = new System.Windows.Forms.Label();
            this.killNumeric = new System.Windows.Forms.NumericUpDown();
            this.killLabel = new System.Windows.Forms.Label();
            this.placeGroup = new System.Windows.Forms.GroupBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.countryText = new System.Windows.Forms.TextBox();
            this.regionText = new System.Windows.Forms.TextBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.timeGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dayCheck = new System.Windows.Forms.CheckBox();
            this.monthCheck = new System.Windows.Forms.CheckBox();
            this.yearCheck = new System.Windows.Forms.CheckBox();
            this.dayNumeric = new System.Windows.Forms.NumericUpDown();
            this.monthNumeric = new System.Windows.Forms.NumericUpDown();
            this.yearNumeric = new System.Windows.Forms.NumericUpDown();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.resultTab = new System.Windows.Forms.TabPage();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.mapTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.infoGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.woundNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killNumeric)).BeginInit();
            this.placeGroup.SuspendLayout();
            this.timeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).BeginInit();
            this.resultTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.searchTab);
            this.tabControl.Controls.Add(this.resultTab);
            this.tabControl.Controls.Add(this.mapTab);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(779, 468);
            this.tabControl.TabIndex = 0;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchBtn);
            this.searchTab.Controls.Add(this.infoGroup);
            this.searchTab.Controls.Add(this.groupBox1);
            this.searchTab.Controls.Add(this.placeGroup);
            this.searchTab.Controls.Add(this.timeGroup);
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(771, 442);
            this.searchTab.TabIndex = 0;
            this.searchTab.Text = "Поиск";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(443, 272);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(318, 161);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Поиск";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // infoGroup
            // 
            this.infoGroup.Controls.Add(this.keyWordCheck);
            this.infoGroup.Controls.Add(this.targetTypeLabel);
            this.infoGroup.Controls.Add(this.targetTypeText);
            this.infoGroup.Controls.Add(this.keyWordText);
            this.infoGroup.Controls.Add(this.targetText);
            this.infoGroup.Controls.Add(this.weaponText);
            this.infoGroup.Controls.Add(this.weaponLabel);
            this.infoGroup.Controls.Add(this.noteLabel);
            this.infoGroup.Controls.Add(this.targetLabel);
            this.infoGroup.Location = new System.Drawing.Point(443, 6);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(318, 260);
            this.infoGroup.TabIndex = 15;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "Дополнительная информация";
            // 
            // keyWordCheck
            // 
            this.keyWordCheck.AutoSize = true;
            this.keyWordCheck.Location = new System.Drawing.Point(244, 102);
            this.keyWordCheck.Name = "keyWordCheck";
            this.keyWordCheck.Size = new System.Drawing.Size(15, 14);
            this.keyWordCheck.TabIndex = 20;
            this.keyWordCheck.UseVisualStyleBackColor = true;
            // 
            // targetTypeLabel
            // 
            this.targetTypeLabel.AutoSize = true;
            this.targetTypeLabel.Location = new System.Drawing.Point(6, 47);
            this.targetTypeLabel.Name = "targetTypeLabel";
            this.targetTypeLabel.Size = new System.Drawing.Size(53, 13);
            this.targetTypeLabel.TabIndex = 19;
            this.targetTypeLabel.Text = "Тип цели";
            // 
            // targetTypeText
            // 
            this.targetTypeText.Location = new System.Drawing.Point(90, 44);
            this.targetTypeText.Name = "targetTypeText";
            this.targetTypeText.Size = new System.Drawing.Size(222, 20);
            this.targetTypeText.TabIndex = 18;
            // 
            // keyWordText
            // 
            this.keyWordText.Location = new System.Drawing.Point(6, 122);
            this.keyWordText.Name = "keyWordText";
            this.keyWordText.Size = new System.Drawing.Size(306, 132);
            this.keyWordText.TabIndex = 17;
            this.keyWordText.Text = "";
            // 
            // targetText
            // 
            this.targetText.Location = new System.Drawing.Point(90, 71);
            this.targetText.Name = "targetText";
            this.targetText.Size = new System.Drawing.Size(222, 20);
            this.targetText.TabIndex = 16;
            // 
            // weaponText
            // 
            this.weaponText.Location = new System.Drawing.Point(90, 19);
            this.weaponText.Name = "weaponText";
            this.weaponText.Size = new System.Drawing.Size(222, 20);
            this.weaponText.TabIndex = 15;
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Location = new System.Drawing.Point(6, 22);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(66, 13);
            this.weaponLabel.TabIndex = 9;
            this.weaponLabel.Text = "Тип оружия";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(87, 102);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(151, 13);
            this.noteLabel.TabIndex = 14;
            this.noteLabel.Text = "Поиск по ключевым словам";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(6, 75);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(33, 13);
            this.targetLabel.TabIndex = 10;
            this.targetLabel.Text = "Цель";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isSuccess);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.successCheck);
            this.groupBox1.Controls.Add(this.woundCheck);
            this.groupBox1.Controls.Add(this.killCheck);
            this.groupBox1.Controls.Add(this.successLabel);
            this.groupBox1.Controls.Add(this.woundNumeric);
            this.groupBox1.Controls.Add(this.woundLabel);
            this.groupBox1.Controls.Add(this.killNumeric);
            this.groupBox1.Controls.Add(this.killLabel);
            this.groupBox1.Location = new System.Drawing.Point(7, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 161);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Последствия";
            // 
            // isSuccess
            // 
            this.isSuccess.AutoSize = true;
            this.isSuccess.Location = new System.Drawing.Point(91, 104);
            this.isSuccess.Name = "isSuccess";
            this.isSuccess.Size = new System.Drawing.Size(15, 14);
            this.isSuccess.TabIndex = 19;
            this.isSuccess.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Учитывать при поиске";
            // 
            // successCheck
            // 
            this.successCheck.AutoSize = true;
            this.successCheck.Location = new System.Drawing.Point(357, 103);
            this.successCheck.Name = "successCheck";
            this.successCheck.Size = new System.Drawing.Size(15, 14);
            this.successCheck.TabIndex = 17;
            this.successCheck.UseVisualStyleBackColor = true;
            // 
            // woundCheck
            // 
            this.woundCheck.AutoSize = true;
            this.woundCheck.Location = new System.Drawing.Point(357, 76);
            this.woundCheck.Name = "woundCheck";
            this.woundCheck.Size = new System.Drawing.Size(15, 14);
            this.woundCheck.TabIndex = 16;
            this.woundCheck.UseVisualStyleBackColor = true;
            // 
            // killCheck
            // 
            this.killCheck.AutoSize = true;
            this.killCheck.Location = new System.Drawing.Point(357, 49);
            this.killCheck.Name = "killCheck";
            this.killCheck.Size = new System.Drawing.Size(15, 14);
            this.killCheck.TabIndex = 15;
            this.killCheck.UseVisualStyleBackColor = true;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Location = new System.Drawing.Point(11, 104);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(70, 13);
            this.successLabel.TabIndex = 8;
            this.successLabel.Text = "Успешность";
            // 
            // woundNumeric
            // 
            this.woundNumeric.Location = new System.Drawing.Point(91, 74);
            this.woundNumeric.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.woundNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.woundNumeric.Name = "woundNumeric";
            this.woundNumeric.Size = new System.Drawing.Size(220, 20);
            this.woundNumeric.TabIndex = 13;
            this.woundNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // woundLabel
            // 
            this.woundLabel.AutoSize = true;
            this.woundLabel.Location = new System.Drawing.Point(11, 76);
            this.woundLabel.Name = "woundLabel";
            this.woundLabel.Size = new System.Drawing.Size(44, 13);
            this.woundLabel.TabIndex = 7;
            this.woundLabel.Text = "Ранено";
            // 
            // killNumeric
            // 
            this.killNumeric.Location = new System.Drawing.Point(91, 48);
            this.killNumeric.Maximum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.killNumeric.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.killNumeric.Name = "killNumeric";
            this.killNumeric.Size = new System.Drawing.Size(220, 20);
            this.killNumeric.TabIndex = 10;
            this.killNumeric.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // killLabel
            // 
            this.killLabel.AutoSize = true;
            this.killLabel.Location = new System.Drawing.Point(11, 50);
            this.killLabel.Name = "killLabel";
            this.killLabel.Size = new System.Drawing.Size(38, 13);
            this.killLabel.TabIndex = 6;
            this.killLabel.Text = "Убито";
            // 
            // placeGroup
            // 
            this.placeGroup.Controls.Add(this.cityText);
            this.placeGroup.Controls.Add(this.countryText);
            this.placeGroup.Controls.Add(this.regionText);
            this.placeGroup.Controls.Add(this.regionLabel);
            this.placeGroup.Controls.Add(this.countryLabel);
            this.placeGroup.Controls.Add(this.cityLabel);
            this.placeGroup.Location = new System.Drawing.Point(7, 145);
            this.placeGroup.Name = "placeGroup";
            this.placeGroup.Size = new System.Drawing.Size(430, 121);
            this.placeGroup.TabIndex = 12;
            this.placeGroup.TabStop = false;
            this.placeGroup.Text = "Местоположение";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(91, 74);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(333, 20);
            this.cityText.TabIndex = 8;
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(91, 47);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(333, 20);
            this.countryText.TabIndex = 7;
            // 
            // regionText
            // 
            this.regionText.Location = new System.Drawing.Point(91, 21);
            this.regionText.Name = "regionText";
            this.regionText.Size = new System.Drawing.Size(333, 20);
            this.regionText.TabIndex = 6;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(6, 24);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(43, 13);
            this.regionLabel.TabIndex = 4;
            this.regionLabel.Text = "Регион";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(6, 50);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "Страна";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(8, 77);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 13);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "Город";
            // 
            // timeGroup
            // 
            this.timeGroup.Controls.Add(this.label1);
            this.timeGroup.Controls.Add(this.dayCheck);
            this.timeGroup.Controls.Add(this.monthCheck);
            this.timeGroup.Controls.Add(this.yearCheck);
            this.timeGroup.Controls.Add(this.dayNumeric);
            this.timeGroup.Controls.Add(this.monthNumeric);
            this.timeGroup.Controls.Add(this.yearNumeric);
            this.timeGroup.Controls.Add(this.yearLabel);
            this.timeGroup.Controls.Add(this.monthLabel);
            this.timeGroup.Controls.Add(this.dayLabel);
            this.timeGroup.Location = new System.Drawing.Point(7, 6);
            this.timeGroup.Name = "timeGroup";
            this.timeGroup.Size = new System.Drawing.Size(430, 133);
            this.timeGroup.TabIndex = 11;
            this.timeGroup.TabStop = false;
            this.timeGroup.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Учитывать при поиске";
            // 
            // dayCheck
            // 
            this.dayCheck.AutoSize = true;
            this.dayCheck.Location = new System.Drawing.Point(357, 101);
            this.dayCheck.Name = "dayCheck";
            this.dayCheck.Size = new System.Drawing.Size(15, 14);
            this.dayCheck.TabIndex = 7;
            this.dayCheck.UseVisualStyleBackColor = true;
            // 
            // monthCheck
            // 
            this.monthCheck.AutoSize = true;
            this.monthCheck.Location = new System.Drawing.Point(357, 74);
            this.monthCheck.Name = "monthCheck";
            this.monthCheck.Size = new System.Drawing.Size(15, 14);
            this.monthCheck.TabIndex = 6;
            this.monthCheck.UseVisualStyleBackColor = true;
            // 
            // yearCheck
            // 
            this.yearCheck.AutoSize = true;
            this.yearCheck.Location = new System.Drawing.Point(357, 47);
            this.yearCheck.Name = "yearCheck";
            this.yearCheck.Size = new System.Drawing.Size(15, 14);
            this.yearCheck.TabIndex = 5;
            this.yearCheck.UseVisualStyleBackColor = true;
            // 
            // dayNumeric
            // 
            this.dayNumeric.Location = new System.Drawing.Point(91, 99);
            this.dayNumeric.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayNumeric.Name = "dayNumeric";
            this.dayNumeric.Size = new System.Drawing.Size(220, 20);
            this.dayNumeric.TabIndex = 4;
            this.dayNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // monthNumeric
            // 
            this.monthNumeric.Location = new System.Drawing.Point(91, 72);
            this.monthNumeric.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthNumeric.Name = "monthNumeric";
            this.monthNumeric.Size = new System.Drawing.Size(220, 20);
            this.monthNumeric.TabIndex = 3;
            this.monthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yearNumeric
            // 
            this.yearNumeric.Location = new System.Drawing.Point(91, 45);
            this.yearNumeric.Maximum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.yearNumeric.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.yearNumeric.Name = "yearNumeric";
            this.yearNumeric.Size = new System.Drawing.Size(220, 20);
            this.yearNumeric.TabIndex = 1;
            this.yearNumeric.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(5, 47);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(25, 13);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Год";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(5, 74);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 1;
            this.monthLabel.Text = "Месяц";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(5, 101);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(34, 13);
            this.dayLabel.TabIndex = 2;
            this.dayLabel.Text = "День";
            // 
            // resultTab
            // 
            this.resultTab.Controls.Add(this.mainGrid);
            this.resultTab.Location = new System.Drawing.Point(4, 22);
            this.resultTab.Name = "resultTab";
            this.resultTab.Padding = new System.Windows.Forms.Padding(3);
            this.resultTab.Size = new System.Drawing.Size(771, 442);
            this.resultTab.TabIndex = 1;
            this.resultTab.Text = "Результаты";
            this.resultTab.UseVisualStyleBackColor = true;
            // 
            // mainGrid
            // 
            this.mainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(7, 7);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.Size = new System.Drawing.Size(758, 429);
            this.mainGrid.TabIndex = 0;
            // 
            // mapTab
            // 
            this.mapTab.Location = new System.Drawing.Point(4, 22);
            this.mapTab.Name = "mapTab";
            this.mapTab.Size = new System.Drawing.Size(771, 442);
            this.mapTab.TabIndex = 2;
            this.mapTab.Text = "Карта";
            this.mapTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 493);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(820, 532);
            this.Name = "MainForm";
            this.Text = "Курсовая";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.woundNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killNumeric)).EndInit();
            this.placeGroup.ResumeLayout(false);
            this.placeGroup.PerformLayout();
            this.timeGroup.ResumeLayout(false);
            this.timeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).EndInit();
            this.resultTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TabPage resultTab;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox infoGroup;
        private System.Windows.Forms.RichTextBox keyWordText;
        private System.Windows.Forms.TextBox targetText;
        private System.Windows.Forms.TextBox weaponText;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox isSuccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox successCheck;
        private System.Windows.Forms.CheckBox woundCheck;
        private System.Windows.Forms.CheckBox killCheck;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.NumericUpDown woundNumeric;
        private System.Windows.Forms.Label woundLabel;
        private System.Windows.Forms.NumericUpDown killNumeric;
        private System.Windows.Forms.Label killLabel;
        private System.Windows.Forms.GroupBox placeGroup;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.TextBox regionText;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.GroupBox timeGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox dayCheck;
        private System.Windows.Forms.CheckBox monthCheck;
        private System.Windows.Forms.CheckBox yearCheck;
        private System.Windows.Forms.NumericUpDown dayNumeric;
        private System.Windows.Forms.NumericUpDown monthNumeric;
        private System.Windows.Forms.NumericUpDown yearNumeric;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.TabPage mapTab;
        private System.Windows.Forms.Label targetTypeLabel;
        private System.Windows.Forms.TextBox targetTypeText;
        private System.Windows.Forms.CheckBox keyWordCheck;
    }
}

