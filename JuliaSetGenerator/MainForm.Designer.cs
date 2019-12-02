namespace JuliaSetGenerator
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPictureHeight = new System.Windows.Forms.TextBox();
            this.tbPictureWidth = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbImCValue = new System.Windows.Forms.TextBox();
            this.tbReCValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRandomGenerate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbFColor = new System.Windows.Forms.PictureBox();
            this.pbBColor = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnForegroundColor = new System.Windows.Forms.Button();
            this.btnBackroundColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbDeltaYValue = new System.Windows.Forms.TextBox();
            this.tbDeltaXValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbZoomValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBColor)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 625);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(653, 624);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(2);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(127, 28);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Нарисовать";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(868, 624);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить картинку";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 639);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ширина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Высота:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPictureHeight);
            this.groupBox1.Controls.Add(this.tbPictureWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(654, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер генерируемого изображения";
            // 
            // tbPictureHeight
            // 
            this.tbPictureHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPictureHeight.Location = new System.Drawing.Point(83, 42);
            this.tbPictureHeight.Name = "tbPictureHeight";
            this.tbPictureHeight.Size = new System.Drawing.Size(100, 20);
            this.tbPictureHeight.TabIndex = 7;
            // 
            // tbPictureWidth
            // 
            this.tbPictureWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPictureWidth.Location = new System.Drawing.Point(83, 22);
            this.tbPictureWidth.Name = "tbPictureWidth";
            this.tbPictureWidth.Size = new System.Drawing.Size(100, 20);
            this.tbPictureWidth.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbImCValue);
            this.groupBox2.Controls.Add(this.tbReCValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(654, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Компоненты комплексной переменной*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(155, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "*оптимальные значения - от -1 до 1";
            // 
            // tbImCValue
            // 
            this.tbImCValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbImCValue.Location = new System.Drawing.Point(83, 42);
            this.tbImCValue.Name = "tbImCValue";
            this.tbImCValue.Size = new System.Drawing.Size(100, 20);
            this.tbImCValue.TabIndex = 9;
            // 
            // tbReCValue
            // 
            this.tbReCValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReCValue.Location = new System.Drawing.Point(83, 22);
            this.tbReCValue.Name = "tbReCValue";
            this.tbReCValue.Size = new System.Drawing.Size(100, 20);
            this.tbReCValue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ReC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ImC:";
            // 
            // btnRandomGenerate
            // 
            this.btnRandomGenerate.Location = new System.Drawing.Point(654, 228);
            this.btnRandomGenerate.Name = "btnRandomGenerate";
            this.btnRandomGenerate.Size = new System.Drawing.Size(123, 28);
            this.btnRandomGenerate.TabIndex = 8;
            this.btnRandomGenerate.Text = "Случайное значение ";
            this.btnRandomGenerate.UseVisualStyleBackColor = true;
            this.btnRandomGenerate.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(654, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Применить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbFColor);
            this.groupBox3.Controls.Add(this.pbBColor);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.btnForegroundColor);
            this.groupBox3.Controls.Add(this.btnBackroundColor);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(654, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 169);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фигура и цвет";
            // 
            // pbFColor
            // 
            this.pbFColor.Location = new System.Drawing.Point(189, 89);
            this.pbFColor.Name = "pbFColor";
            this.pbFColor.Size = new System.Drawing.Size(25, 25);
            this.pbFColor.TabIndex = 10;
            this.pbFColor.TabStop = false;
            // 
            // pbBColor
            // 
            this.pbBColor.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBColor.Location = new System.Drawing.Point(189, 61);
            this.pbBColor.Name = "pbBColor";
            this.pbBColor.Size = new System.Drawing.Size(25, 25);
            this.pbBColor.TabIndex = 9;
            this.pbBColor.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 120);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(130, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Градиентный";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Двуцветный";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnForegroundColor
            // 
            this.btnForegroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForegroundColor.Location = new System.Drawing.Point(99, 90);
            this.btnForegroundColor.Name = "btnForegroundColor";
            this.btnForegroundColor.Size = new System.Drawing.Size(84, 25);
            this.btnForegroundColor.TabIndex = 3;
            this.btnForegroundColor.Text = "выбрать";
            this.btnForegroundColor.UseVisualStyleBackColor = true;
            this.btnForegroundColor.Click += new System.EventHandler(this.BtnForegroundColor_Click);
            // 
            // btnBackroundColor
            // 
            this.btnBackroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackroundColor.Location = new System.Drawing.Point(99, 61);
            this.btnBackroundColor.Name = "btnBackroundColor";
            this.btnBackroundColor.Size = new System.Drawing.Size(84, 25);
            this.btnBackroundColor.TabIndex = 2;
            this.btnBackroundColor.Text = "выбрать";
            this.btnBackroundColor.UseVisualStyleBackColor = true;
            this.btnBackroundColor.Click += new System.EventHandler(this.BtnBackroundColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Фигура:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Фон:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(654, 598);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(302, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Сгенерировать множество Мандельброта";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Mandelbrot_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbDeltaYValue);
            this.groupBox4.Controls.Add(this.tbDeltaXValue);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tbZoomValue);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(654, 438);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 94);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Приближение и смещение";
            // 
            // tbDeltaYValue
            // 
            this.tbDeltaYValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDeltaYValue.Location = new System.Drawing.Point(71, 62);
            this.tbDeltaYValue.Name = "tbDeltaYValue";
            this.tbDeltaYValue.Size = new System.Drawing.Size(100, 20);
            this.tbDeltaYValue.TabIndex = 5;
            this.tbDeltaYValue.Text = "0";
            // 
            // tbDeltaXValue
            // 
            this.tbDeltaXValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDeltaXValue.Location = new System.Drawing.Point(71, 42);
            this.tbDeltaXValue.Name = "tbDeltaXValue";
            this.tbDeltaXValue.Size = new System.Drawing.Size(100, 20);
            this.tbDeltaXValue.TabIndex = 4;
            this.tbDeltaXValue.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "deltaY:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "deltaX:";
            // 
            // tbZoomValue
            // 
            this.tbZoomValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbZoomValue.Location = new System.Drawing.Point(71, 22);
            this.tbZoomValue.Name = "tbZoomValue";
            this.tbZoomValue.Size = new System.Drawing.Size(100, 20);
            this.tbZoomValue.TabIndex = 1;
            this.tbZoomValue.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "zoom:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1006, 660);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnRandomGenerate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор множеств Жюлиа";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBColor)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPictureHeight;
        private System.Windows.Forms.TextBox tbPictureWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbImCValue;
        private System.Windows.Forms.TextBox tbReCValue;
        private System.Windows.Forms.Button btnRandomGenerate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnForegroundColor;
        private System.Windows.Forms.Button btnBackroundColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbDeltaYValue;
        private System.Windows.Forms.TextBox tbDeltaXValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbZoomValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbFColor;
        private System.Windows.Forms.PictureBox pbBColor;
    }
}

