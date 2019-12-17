using System;
using System.Drawing;
using System.Windows.Forms;

namespace CellGame
{
    public partial class MainForm : Form
    {
        private const int PictureBoxMarginPixelSize = 3;
        private const int CellMarginPixelSize = 1;
        private const int CellPixelSize = 10;
        private readonly World _world;

        public MainForm()
        {
            _world = new World(DrawCell);
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ArrangePictureBoxSize();
            ArrangeMainFormSize();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;

            _world.InitGame();
            RenderAllCells();

            RefreshTurnCount();
            StepButton.Enabled = true;
        }

        private void StepButton_Click(object sender, EventArgs e)
        {
            _world.ExecuteCellRulesOneTurn();
            RefreshTurnCount();
        }

        private void RenderAllCells()
        {
            using (var graphics = CellsPictureBox.CreateGraphics())
            {
                graphics.Clear(Color.Transparent);

                for (int i = 0; i < World.LinearSize; i++)
                    for (int j = 0; j < World.LinearSize; j++)
                        if (_world.IsCellAlive(i, j))
                            DrawCell(graphics, i, j, true);
            }
        }

        private void DrawCell(int i, int j, bool visible)
        {
            using (var graphics = CellsPictureBox.CreateGraphics())
                DrawCell(graphics, i, j, visible);
        }

        private static void DrawCell(Graphics graphics, int i, int j, bool visible)
        {
            var color = visible ? Color.Blue : Color.Black;
            var x = PictureBoxMarginPixelSize + i * CellPixelSize + CellMarginPixelSize;
            var y = PictureBoxMarginPixelSize + j * CellPixelSize + CellMarginPixelSize;
            var width = CellPixelSize - 1 - 2 * CellMarginPixelSize;

            using (var pen = new Pen(color, 2)) graphics.DrawRectangle(pen, x, y, width, width);
        }

        private void RefreshTurnCount() => Turnlabel.Text = _world.TurnCount.ToString();

        private void ArrangePictureBoxSize()
        {
            var pictureBoxWidth = World.LinearSize * CellPixelSize + 2 * PictureBoxMarginPixelSize;
            CellsPictureBox.Size = new Size(pictureBoxWidth, pictureBoxWidth);
        }

        private void ArrangeMainFormSize()
        {
            var width = CellsPictureBox.Width + 110;
            var height = CellsPictureBox.Height + 60;
            Size = new Size(width, height);
        }
    }
}
