namespace OOP_project
{
    public class HPBar : ProgressBar
    {
        public HPBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true); // Cho phép tự vẽ
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Nền trắng
            e.Graphics.Clear(Color.White);

            // % máu còn lại
            double percent = (double)Value / Maximum;
            int width = (int)(this.Width * percent);

            // Thanh đỏ
            using (SolidBrush brush = new SolidBrush(Color.Red))
            {
                e.Graphics.FillRectangle(brush, 0, 0, width, this.Height);
            }

            // Viền đen
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
        }
    }
}