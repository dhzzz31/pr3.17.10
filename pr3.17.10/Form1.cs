namespace pr3._17._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Закрыть форму
            this.Close();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
           // Показываем диалог открытия.Если нажать "ОК" то выведет изображение
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Отчистить форму
            pictureBox1.Image = null;

        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Показываем диалог открытия выбора цвета. Если нажать "ОК" то сменится фон
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ilfkuthi //fsdijfolox
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

        }
    }
}