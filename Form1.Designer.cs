namespace WindowsExam
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbServices = new System.Windows.Forms.ComboBox();
            this.rb1Gluhoe = new System.Windows.Forms.RadioButton();
            this.rb2Povorotnoe = new System.Windows.Forms.RadioButton();
            this.rb3Otkidnoe = new System.Windows.Forms.RadioButton();
            this.rb4Framuzhnoe = new System.Windows.Forms.RadioButton();
            this.rb5Razdvizhnoe = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btRasschet = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btOformitKvitanciyu = new System.Windows.Forms.Button();
            this.pbAddPhoto = new System.Windows.Forms.PictureBox();
            this.btAddPicture = new System.Windows.Forms.Button();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Услуга";
            // 
            // cbServices
            // 
            this.cbServices.FormattingEnabled = true;
            this.cbServices.Items.AddRange(new object[] {
            "Окна",
            "Балконы",
            "Двери"});
            this.cbServices.Location = new System.Drawing.Point(12, 28);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(198, 24);
            this.cbServices.TabIndex = 1;
            // 
            // rb1Gluhoe
            // 
            this.rb1Gluhoe.AutoSize = true;
            this.rb1Gluhoe.Checked = true;
            this.rb1Gluhoe.Location = new System.Drawing.Point(12, 59);
            this.rb1Gluhoe.Name = "rb1Gluhoe";
            this.rb1Gluhoe.Size = new System.Drawing.Size(73, 20);
            this.rb1Gluhoe.TabIndex = 2;
            this.rb1Gluhoe.TabStop = true;
            this.rb1Gluhoe.Text = "Глухое";
            this.rb1Gluhoe.UseVisualStyleBackColor = true;
            // 
            // rb2Povorotnoe
            // 
            this.rb2Povorotnoe.AutoSize = true;
            this.rb2Povorotnoe.Location = new System.Drawing.Point(12, 85);
            this.rb2Povorotnoe.Name = "rb2Povorotnoe";
            this.rb2Povorotnoe.Size = new System.Drawing.Size(109, 20);
            this.rb2Povorotnoe.TabIndex = 3;
            this.rb2Povorotnoe.Text = "Поворотное";
            this.rb2Povorotnoe.UseVisualStyleBackColor = true;
            // 
            // rb3Otkidnoe
            // 
            this.rb3Otkidnoe.AutoSize = true;
            this.rb3Otkidnoe.Location = new System.Drawing.Point(12, 111);
            this.rb3Otkidnoe.Name = "rb3Otkidnoe";
            this.rb3Otkidnoe.Size = new System.Drawing.Size(92, 20);
            this.rb3Otkidnoe.TabIndex = 4;
            this.rb3Otkidnoe.Text = "Откидное";
            this.rb3Otkidnoe.UseVisualStyleBackColor = true;
            // 
            // rb4Framuzhnoe
            // 
            this.rb4Framuzhnoe.AutoSize = true;
            this.rb4Framuzhnoe.Location = new System.Drawing.Point(12, 137);
            this.rb4Framuzhnoe.Name = "rb4Framuzhnoe";
            this.rb4Framuzhnoe.Size = new System.Drawing.Size(105, 20);
            this.rb4Framuzhnoe.TabIndex = 5;
            this.rb4Framuzhnoe.Text = "Фрамужное";
            this.rb4Framuzhnoe.UseVisualStyleBackColor = true;
            // 
            // rb5Razdvizhnoe
            // 
            this.rb5Razdvizhnoe.AutoSize = true;
            this.rb5Razdvizhnoe.Location = new System.Drawing.Point(12, 163);
            this.rb5Razdvizhnoe.Name = "rb5Razdvizhnoe";
            this.rb5Razdvizhnoe.Size = new System.Drawing.Size(110, 20);
            this.rb5Razdvizhnoe.TabIndex = 6;
            this.rb5Razdvizhnoe.Text = "Раздвижное";
            this.rb5Razdvizhnoe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ширина (см)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Высота (см)";
            // 
            // btRasschet
            // 
            this.btRasschet.Location = new System.Drawing.Point(12, 249);
            this.btRasschet.Name = "btRasschet";
            this.btRasschet.Size = new System.Drawing.Size(82, 23);
            this.btRasschet.TabIndex = 11;
            this.btRasschet.Text = "Рассчёт";
            this.btRasschet.UseVisualStyleBackColor = true;
            this.btRasschet.Click += new System.EventHandler(this.btRasschet_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(12, 279);
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(198, 133);
            this.tbTotal.TabIndex = 12;
            this.tbTotal.Text = "Вывод рассчётов";
            // 
            // btOformitKvitanciyu
            // 
            this.btOformitKvitanciyu.Location = new System.Drawing.Point(118, 418);
            this.btOformitKvitanciyu.Name = "btOformitKvitanciyu";
            this.btOformitKvitanciyu.Size = new System.Drawing.Size(198, 23);
            this.btOformitKvitanciyu.TabIndex = 13;
            this.btOformitKvitanciyu.Text = "Оформить квитанцию";
            this.btOformitKvitanciyu.UseVisualStyleBackColor = true;
            this.btOformitKvitanciyu.Click += new System.EventHandler(this.FeedReceipt);
            // 
            // pbAddPhoto
            // 
            this.pbAddPhoto.Location = new System.Drawing.Point(227, 12);
            this.pbAddPhoto.Name = "pbAddPhoto";
            this.pbAddPhoto.Size = new System.Drawing.Size(198, 224);
            this.pbAddPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddPhoto.TabIndex = 14;
            this.pbAddPhoto.TabStop = false;
            // 
            // btAddPicture
            // 
            this.btAddPicture.Location = new System.Drawing.Point(227, 242);
            this.btAddPicture.Name = "btAddPicture";
            this.btAddPicture.Size = new System.Drawing.Size(198, 23);
            this.btAddPicture.TabIndex = 15;
            this.btAddPicture.Text = "Добавить фото";
            this.btAddPicture.UseVisualStyleBackColor = true;
            this.btAddPicture.Click += new System.EventHandler(this.btAddPicture_Click);
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(100, 190);
            this.numWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 22);
            this.numWidth.TabIndex = 16;
            this.numWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(100, 218);
            this.numHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(120, 22);
            this.numHeight.TabIndex = 17;
            this.numHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 449);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.btAddPicture);
            this.Controls.Add(this.pbAddPhoto);
            this.Controls.Add(this.btOformitKvitanciyu);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btRasschet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb5Razdvizhnoe);
            this.Controls.Add(this.rb4Framuzhnoe);
            this.Controls.Add(this.rb3Otkidnoe);
            this.Controls.Add(this.rb2Povorotnoe);
            this.Controls.Add(this.rb1Gluhoe);
            this.Controls.Add(this.cbServices);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbServices;
        private System.Windows.Forms.RadioButton rb1Gluhoe;
        private System.Windows.Forms.RadioButton rb2Povorotnoe;
        private System.Windows.Forms.RadioButton rb3Otkidnoe;
        private System.Windows.Forms.RadioButton rb4Framuzhnoe;
        private System.Windows.Forms.RadioButton rb5Razdvizhnoe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRasschet;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btOformitKvitanciyu;
        private System.Windows.Forms.PictureBox pbAddPhoto;
        private System.Windows.Forms.Button btAddPicture;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
    }
}

