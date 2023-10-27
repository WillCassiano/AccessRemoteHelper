using Patagames.Ocr;

namespace AccessRemoteHelper.Views
{
    public partial class Scanner : Form
    {
        private TextBox txtId;
        private readonly bool _openReader;
        private TextReaded _formReaded;

        public Scanner(TextBox txtId, bool openReader = false)
        {
            InitializeComponent();
            this.txtId = txtId;
            this._openReader = openReader;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var x = Cursor.Position.X - this.Width / 2;
            var y = Cursor.Position.Y - this.Height / 2;
            this.Location = new Point(x, y);
        }

        private void Scanner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Right && e.Control)
            {
                if (this.Width < 489)
                    this.Width += 10;
            }
            if (e.KeyCode == Keys.Left && e.Control) this.Width -= 10;
            if (e.KeyCode == Keys.Up && e.Control) this.Height += 10;
            if (e.KeyCode == Keys.Down && e.Control) this.Height -= 10;

        }

        private void Scanner_Click(object sender, EventArgs e)
        {
            Print();
            ReadImage();
            if (!_openReader)
            {
                this.Close();
            }
            else
            {
                _formReaded?.Show();
            }
        }

        private void Print()
        {
            Bitmap printScreen = new Bitmap(this.Width, this.Height);
            var graphics = Graphics.FromImage(printScreen as Image);

            graphics.CopyFromScreen(this.Location.X,
                                    this.Location.Y,
                                    0,
                                    0, printScreen.Size);

            picScan.Image = printScreen;
        }

        private void ReadImage()
        {
            using var api = OcrApi.Create();

            api.Init(Patagames.Ocr.Enums.Languages.English);

            if (!_openReader) txtId.Text = ApenasNumeros(api.GetTextFromImage((Bitmap)picScan.Image));
            else
            {
                _formReaded.richTextReader.Text = api.GetTextFromImage((Bitmap)picScan.Image);
                _formReaded.CopiarTexto();
                picScan.Image = null;
            }
        }

        private string ApenasNumeros(string texto)
        {
            var result = "";
            foreach (var caracter in texto)
            {
                if (int.TryParse(caracter.ToString(), out int c)) result += c;
            }
            return result;
        }

        private void Scanner_Load(object sender, EventArgs e)
        {
            if (_openReader)
            {
                _formReaded = new TextReaded();
                _formReaded.Location = new Point(this.Location.X, this.Location.Y + this.Height);
                _formReaded.Width = this.Width;

                this.SizeChanged += Scanner_SizeChanged;
                this.LocationChanged += Scanner_LocationChanged;
            }
        }

        private void Scanner_LocationChanged(object? sender, EventArgs e)
        {
            _formReaded.Location = new Point(this.Location.X, this.Location.Y + this.Height);
        }

        private void Scanner_SizeChanged(object? sender, EventArgs e)
        {
            _formReaded.Width = Width;
        }
    }
}
