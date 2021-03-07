namespace Work3
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
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectedFolder = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.tbTransparensy = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.brightness = new System.Windows.Forms.Label();
            this.transparency = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransparensy)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLeft
            // 
            this.BtnLeft.Location = new System.Drawing.Point(233, 327);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(75, 23);
            this.BtnLeft.TabIndex = 0;
            this.BtnLeft.Text = "<<";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.ImageSelector_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Location = new System.Drawing.Point(474, 327);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(75, 23);
            this.BtnRight.TabIndex = 1;
            this.BtnRight.Text = ">>";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.ImageSelector_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(233, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SelectedFolder
            // 
            this.SelectedFolder.Location = new System.Drawing.Point(40, 327);
            this.SelectedFolder.Name = "SelectedFolder";
            this.SelectedFolder.Size = new System.Drawing.Size(75, 23);
            this.SelectedFolder.TabIndex = 3;
            this.SelectedFolder.Text = "Выбрать";
            this.SelectedFolder.UseVisualStyleBackColor = true;
            this.SelectedFolder.Click += new System.EventHandler(this.SelectedFolder_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 264);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // tbBrightness
            // 
            this.tbBrightness.Location = new System.Drawing.Point(606, 58);
            this.tbBrightness.Maximum = 100;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(142, 45);
            this.tbBrightness.TabIndex = 5;
            this.tbBrightness.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tbTransparensy
            // 
            this.tbTransparensy.Location = new System.Drawing.Point(606, 130);
            this.tbTransparensy.Maximum = 100;
            this.tbTransparensy.Name = "tbTransparensy";
            this.tbTransparensy.Size = new System.Drawing.Size(142, 45);
            this.tbTransparensy.TabIndex = 6;
            this.tbTransparensy.Scroll += new System.EventHandler(this.tbTransparensy_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Яркость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Прозрачность ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(680, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Добавить шумы";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // brightness
            // 
            this.brightness.AutoSize = true;
            this.brightness.Location = new System.Drawing.Point(755, 58);
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(13, 13);
            this.brightness.TabIndex = 12;
            this.brightness.Text = "0";
            // 
            // transparency
            // 
            this.transparency.AutoSize = true;
            this.transparency.Location = new System.Drawing.Point(754, 130);
            this.transparency.Name = "transparency";
            this.transparency.Size = new System.Drawing.Size(13, 13);
            this.transparency.TabIndex = 13;
            this.transparency.Text = "0";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(576, 207);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Tag = "";
            this.checkBox2.Text = "Черно-белое";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.transparency);
            this.Controls.Add(this.brightness);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTransparensy);
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SelectedFolder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransparensy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SelectedFolder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar tbBrightness;
        private System.Windows.Forms.TrackBar tbTransparensy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label brightness;
        private System.Windows.Forms.Label transparency;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

