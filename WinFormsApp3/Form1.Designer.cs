namespace WinFormsApp3
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
            trackbar_movement = new TrackBar();
            screen = new PictureBox();
            trackbar_turn_y = new TrackBar();
            trackbar_turn_z = new TrackBar();
            trackbar_size = new TrackBar();
            trackbar_turn_x = new TrackBar();
            zoomLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackbar_movement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)screen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_z).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_x).BeginInit();
            SuspendLayout();
            // 
            // trackbar_movement
            // 
            trackbar_movement.LargeChange = 15;
            trackbar_movement.Location = new Point(153, 38);
            trackbar_movement.Margin = new Padding(3, 2, 3, 2);
            trackbar_movement.Maximum = 200;
            trackbar_movement.Minimum = -200;
            trackbar_movement.Name = "trackbar_movement";
            trackbar_movement.Size = new Size(542, 45);
            trackbar_movement.SmallChange = 10;
            trackbar_movement.TabIndex = 3;
            trackbar_movement.Scroll += trackbarScroll;
            // 
            // screen
            // 
            screen.BackColor = Color.White;
            screen.Location = new Point(153, 151);
            screen.Margin = new Padding(3, 2, 3, 2);
            screen.Name = "screen";
            screen.Size = new Size(542, 486);
            screen.TabIndex = 12;
            screen.TabStop = false;
            // 
            // trackbar_turn_y
            // 
            trackbar_turn_y.LargeChange = 15;
            trackbar_turn_y.Location = new Point(701, 151);
            trackbar_turn_y.Margin = new Padding(3, 2, 3, 2);
            trackbar_turn_y.Maximum = 200;
            trackbar_turn_y.Minimum = -200;
            trackbar_turn_y.Name = "trackbar_turn_y";
            trackbar_turn_y.Orientation = Orientation.Vertical;
            trackbar_turn_y.Size = new Size(45, 486);
            trackbar_turn_y.SmallChange = 10;
            trackbar_turn_y.TabIndex = 15;
            trackbar_turn_y.TickStyle = TickStyle.TopLeft;
            trackbar_turn_y.Scroll += trackbarScroll;
            // 
            // trackbar_turn_z
            // 
            trackbar_turn_z.LargeChange = 15;
            trackbar_turn_z.Location = new Point(153, 650);
            trackbar_turn_z.Margin = new Padding(3, 2, 3, 2);
            trackbar_turn_z.Maximum = 200;
            trackbar_turn_z.Minimum = -200;
            trackbar_turn_z.Name = "trackbar_turn_z";
            trackbar_turn_z.Size = new Size(542, 45);
            trackbar_turn_z.SmallChange = 10;
            trackbar_turn_z.TabIndex = 16;
            trackbar_turn_z.TickStyle = TickStyle.TopLeft;
            trackbar_turn_z.Scroll += trackbarScroll;
            // 
            // trackbar_size
            // 
            trackbar_size.Location = new Point(153, 102);
            trackbar_size.Margin = new Padding(3, 2, 3, 2);
            trackbar_size.Minimum = 1;
            trackbar_size.Name = "trackbar_size";
            trackbar_size.Size = new Size(542, 45);
            trackbar_size.TabIndex = 3;
            trackbar_size.Value = 1;
            trackbar_size.Scroll += trackbarScroll;
            // 
            // trackbar_turn_x
            // 
            trackbar_turn_x.LargeChange = 1;
            trackbar_turn_x.Location = new Point(110, 151);
            trackbar_turn_x.Margin = new Padding(3, 2, 3, 2);
            trackbar_turn_x.Maximum = 360;
            trackbar_turn_x.Minimum = -360;
            trackbar_turn_x.Name = "trackbar_turn_x";
            trackbar_turn_x.Orientation = Orientation.Vertical;
            trackbar_turn_x.RightToLeft = RightToLeft.No;
            trackbar_turn_x.Size = new Size(45, 486);
            trackbar_turn_x.TabIndex = 3;
            trackbar_turn_x.Scroll += trackbarScroll;
            // 
            // zoomLabel
            // 
            zoomLabel.AutoSize = true;
            zoomLabel.Location = new Point(394, 85);
            zoomLabel.Name = "zoomLabel";
            zoomLabel.Size = new Size(59, 15);
            zoomLabel.TabIndex = 17;
            zoomLabel.Text = "Масштаб";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(742, 384);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 18;
            label1.Text = "Поворот вокруг Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 384);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 19;
            label2.Text = "Поворот вокруг X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 697);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 20;
            label3.Text = "Поворот вокруг Z";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 9);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 21;
            label4.Text = "Перемещение";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 732);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(zoomLabel);
            Controls.Add(trackbar_size);
            Controls.Add(trackbar_turn_z);
            Controls.Add(trackbar_turn_y);
            Controls.Add(trackbar_turn_x);
            Controls.Add(screen);
            Controls.Add(trackbar_movement);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Лабораторная работа №5";
            ((System.ComponentModel.ISupportInitialize)trackbar_movement).EndInit();
            ((System.ComponentModel.ISupportInitialize)screen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_y).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_z).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_size).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackbar_turn_x).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TrackBar trackbar_movement;
        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.TrackBar trackbar_turn_y;
        private System.Windows.Forms.TrackBar trackbar_turn_z;
        private System.Windows.Forms.TrackBar trackbar_size;
        private System.Windows.Forms.TrackBar trackbar_turn_x;
        private Label zoomLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

