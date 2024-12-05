namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int numRows = 10;
        private int numCols = 10;
        private int btnWidth = 80;
        private int btnHeight = 40;
        private int spacing = 10;

        private void GenerateButtonArray()
        {
            Button[,] btnArray = new Button[numRows, numCols];

            for (int x = 0; x < numRows; x++)
            {
                for (int y = 0; y < numCols; y++)
                {
                    int row = x;
                    int col = y;

                    btnArray[x, y] = new Button();
                    btnArray[x, y].Width = btnWidth;
                    btnArray[x, y].Height = btnHeight;
                    btnArray[x, y].Text = (x * numCols + y + 1).ToString();
                    btnArray[x, y].Left = y * (btnWidth + spacing);
                    btnArray[x, y].Top = x * (btnHeight + spacing);
                    btnArray[row, col].Click += (sender, e) => ButtonClicked(sender, e, row, col);

                    this.Controls.Add(btnArray[x, y]);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            GenerateButtonArray();
        }

        private void ButtonClicked(object sender, EventArgs e, int rowIndex, int colIndex)
        {
            MessageBox.Show($"rovv {rowIndex + 1}, colum {colIndex + 1}");
            Button clickedBtn = sender as Button;
            clickedBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
