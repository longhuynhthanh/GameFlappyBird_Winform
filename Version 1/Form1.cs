using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int DoChenhLechGiuaHaiOng = 300;
        int X_Cap1, x_Cap2;

        int y_OngTren1, y_OngTren2;
        int y_OngDuoi1, y_OngDuoi2;

        int DiemSo = 0;
        int Dem = 0;

        private void NutPlay_Click(object sender, EventArgs e)
        {
            Dem++;
            if (Dem % 2 != 0)
            {
                timer1.Start();
                timer2.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // DoubleBuffer => hiệu chỉnh không bị giựt màn hình.
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            if (y_ConChim + ConChim.Height <= this.Height)
            {
                y_ConChim += 10;
                ConChim.Location = new Point(x_ConChim, y_ConChim);
                if (x_ConChim + ConChim.Width >= X_Cap1 && x_ConChim + ConChim.Width <= X_Cap1 + OngTren1.Width)
                {
                    if (y_ConChim <= 1000 + y_OngTren1 || y_ConChim + ConChim.Height >= y_OngDuoi1)
                    {
                        timer1.Stop();
                    }
                }

                if (x_ConChim + ConChim.Width >= x_Cap2 && x_ConChim + ConChim.Width <= x_Cap2 + OngTren2.Width)
                {
                    if (y_ConChim <= 1000 + y_OngTren2 || y_ConChim + ConChim.Height >= y_OngDuoi2)
                    {
                        timer1.Stop();
                    }
                }
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                y_ConChim -= 50; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // DoubleBuffer => hiệu chỉnh không bị giựt màn hình.
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            X_Cap1 -= 10;
            x_Cap2 -= 10;

            OngTren1.Location = new Point(X_Cap1, y_OngTren1);
            OngDuoi1.Location = new Point(X_Cap1, y_OngDuoi1);

            OngTren2.Location = new Point(x_Cap2, y_OngTren2);
            OngDuoi2.Location = new Point(x_Cap2, y_OngDuoi2);

            // Kiểm tra nếu cặp ống 1 mà đi qua form thì cho nó hiện lại đằng sau ống hai.
            if (X_Cap1 + OngTren1.Width <= 0)
            {
                DiemSo++;

                // Hiện lại đằng sau cặp ống hai:
                X_Cap1 = 700 + OngTren2.Width + 500;
                // ramdom độ cao của hai ống cặp 1 cho đặc sắc hơn
                Random rd = new Random();
                y_OngTren1 = rd.Next(-800, -400);
                y_OngDuoi1 = (1000 + y_OngTren1) + DoChenhLechGiuaHaiOng;

                OngTren1.Location = new Point(X_Cap1, y_OngTren1);
                OngDuoi1.Location = new Point(X_Cap1, y_OngDuoi1);
            }

            // Kiểm tra nếu cặp ống hai mà đi qua khỏi form thì cho nó hiện lại đằng sau ống 1:
            if (x_Cap2 + OngTren2.Width <= 0)
            {
                DiemSo++;
                x_Cap2 = 700 + OngTren1.Width + 500;
                // random độ cao của hai ống cặp 2 cho đặc sắc hơn
                Random rd = new Random();
                y_OngTren2 = rd.Next(-800, -400);
                y_OngDuoi2 = (1000 + y_OngTren2) + DoChenhLechGiuaHaiOng;

                OngTren2.Location = new Point(x_Cap2, y_OngTren2);
                OngDuoi2.Location = new Point(x_Cap2, y_OngDuoi2);
            }
            lblDiemSo.Text = "Score: " + DiemSo.ToString();

        }

        int x_ConChim, y_ConChim;

        private void Form1_Load(object sender, EventArgs e)
        {
            /* CODE FULL MÀN HÌNH */
            this.FormBorderStyle = FormBorderStyle.None;
            this.Left = 0;
            this.Top = 0;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            // Canh tọa độ khi vào game:

            X_Cap1 = this.Width + 300; // ẩn các ống vào 300 để khi hiện ra màn hình sẽ không thấy các ống
            y_OngTren1 = -700; // Cho độ cao của ống trên là 1000 thì khi đặt -700 thì ống trên sẽ chỉ hiển thị là 300 trên màn hình.
            OngTren1.Size = new Size(270, 1000);
            OngTren1.Location = new Point(X_Cap1, y_OngTren1);

            // Đã có độ cao ống trên 1, độ chênh lệch giữa hai ống thì ta sẽ suy ra được độ cao ống thứ hai.

            y_OngDuoi1 = (1000 + y_OngTren1) + DoChenhLechGiuaHaiOng;
            OngDuoi1.Size = new Size(270, 1000);
            OngDuoi1.Location = new Point(X_Cap1, y_OngDuoi1);

            x_Cap2 = X_Cap1 + OngTren1.Width + 500; /******/
            y_OngTren2 = -700;
            OngTren2.Size = new Size(270, 1000);
            OngTren2.Location = new Point(x_Cap2, y_OngTren2);

            y_OngDuoi2 = (1000 + y_OngTren2) + DoChenhLechGiuaHaiOng;
            OngDuoi2.Size = new Size(270, 1000);
            OngDuoi2.Location = new Point(x_Cap2, y_OngDuoi2);

            ConChim.Size = new Size(127, 100);
            x_ConChim = ConChim.Location.X;
            y_ConChim = ConChim.Location.Y;

            NutPlay.Size = new Size(50, 50);

            lblDiemSo.Location = new Point(this.Height - 100);
            timer1.Interval = 1;
            timer2.Interval = 50;
        }
    }
}
