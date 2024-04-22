using Eye_Protection;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Task_9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItemHide;
        private ToolStripMenuItem toolStripMenuItemShow;
        private Timer filterTimer = new Timer();
        private TimeSpan startTime = new TimeSpan(8, 0, 0);  // Start (8:00 AM)
        private TimeSpan endTime = new TimeSpan(17, 0, 0);   // End (5:00 PM)

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            contextMenuStrip2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 277);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            label2.SizeChanged += CloseToolStripMenuItem_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip2;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Eye Protection";
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick_1;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, closeToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(115, 52);
            contextMenuStrip2.Text = "Open";
            contextMenuStrip2.Opening += contextMenuStrip2_Opening;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 24);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(114, 24);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(23, 13);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 64, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(23, 48);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(23, 118);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Time";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 64, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(23, 153);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(175, 14);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumBlue;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 195);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 64, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(167, 166);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 14;
            label3.Text = "Version 1.2";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 64, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(23, 83);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 12;
            button5.Text = "Developer";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(289, 219);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Eye Protection";
            Load += Form1_Load_1;
            Resize += Form1_Resize;
            contextMenuStrip2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Form1 form1 = null;

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void MinimizeForm(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeNotifyIcon();
        }

        private void InitializeNotifyIcon()
        {
            throw new NotImplementedException();
        }

        private void HideForm(object sender, EventArgs e)
        {
            if (form1 != null && !form1.IsDisposed)
            {
                form1.Hide();
            }
        }

        private void ShowForm(object sender, EventArgs e)
        {
            if (form1 != null && !form1.IsDisposed)
            {
                form1.Show();
                form1.WindowState = FormWindowState.Normal;
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (form1 == null || form1.IsDisposed)
                {
                    form1 = new Form1();
                    form1.FormClosed += (s, args) => form1 = null;
                    form1.Show();
                }
                else
                {
                    form1.WindowState = FormWindowState.Normal;
                    form1.Activate();
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void FilterTimer_Tick(object sender, EventArgs e)
        {
            // Проверка текущего времени
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            // Применение фильтрации экрана, если текущее время находится в интервале
            if (currentTime >= startTime && currentTime <= endTime)
            {
                ApplyScreenFilter();  // Здесь вызывайте ваш метод для фильтрации экрана
            }
            else
            {
            }
        }

        private void ApplyScreenFilter()
        {
            try
            {
                // Пример: установка гаммы для изменения яркости
                SetGammaRamp(1.0f, 1.0f, 0.8f); // Здесь можно настроить параметры гаммы

                // Дополнительная логика для фильтрации экрана, если необходимо
            }
            catch (Exception)
            {
                //MessageBox.Show();
            }
        }

        // Метод для установки гаммы с использованием API
        [DllImport("gdi32.dll")]
        private unsafe static extern bool SetDeviceGammaRamp(IntPtr hdc, void* ramp);

        // Оголошення P/Invoke для SetDeviceGammaRamp
        [DllImport("gdi32.dll")]
        private static extern bool SetDeviceGammaRamp(IntPtr hdc, ref RampParams ramp);

        // Структура для передачі параметрів гамми
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct RampParams
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Red;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Green;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Blue;
        }

        // Метод для встановлення гами
        private void SetGammaRamp(float red, float green, float blue)
        {
            RampParams ramp = new RampParams
            {
                Red = CalculateGammaRamp(red),
                Green = CalculateGammaRamp(green),
                Blue = CalculateGammaRamp(blue)
            };

            IntPtr hdc = IntPtr.Zero;

            try
            {
                hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc();
                SetDeviceGammaRamp(hdc, ref ramp);
            }
            finally
            {
                if (hdc != IntPtr.Zero)
                    Graphics.FromHwnd(IntPtr.Zero).ReleaseHdc(hdc);
            }
        }

        // Метод для розрахунку значень гамми
        private ushort[] CalculateGammaRamp(float gamma)
        {
            const int size = 256;
            ushort[] ramp = new ushort[size];

            for (int i = 0; i < size; i++)
            {
                ramp[i] = (ushort)Math.Min(65535, Math.Pow(i / 255.0, 1.0 / gamma) * 65535);
            }

            return ramp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterTimer.Start();  // Запуск таймера для проверки времени
            ApplyScreenFilter();  // Здесь вызывайте ваш метод для фильтрации экрана
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filterTimer.Stop();  // Зупинка таймера
            RestoreDefaultGamma();  // Виклик методу для скасування фільтрації екрана
        }

        private void RestoreDefaultGamma()
        {
            try
            {
                // Відновлення параметрів гамми до значень за замовчуванням
                SetGammaRamp(1.0f, 1.0f, 1.0f);  // Параметри (1.0f, 1.0f, 1.0f) відповідають нормальним значенням гамми
            }
            catch (Exception)
            {
                // Нічого не робимо при винятку
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            // Створюємо градієнтний кисть
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                groupBox1.ClientRectangle,
                Color.Purple, // Верхній колір (білий)
                Color.Blue, // Нижній колір (зелений)
                LinearGradientMode.Vertical); // Вказуємо вертикальний градієнт

            // Використовуючи кисть, заповнюємо прямокутник градієнтом
            e.Graphics.FillRectangle(gradientBrush, groupBox1.ClientRectangle);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private Label label2;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private GroupBox groupBox1;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label3;
    }
}