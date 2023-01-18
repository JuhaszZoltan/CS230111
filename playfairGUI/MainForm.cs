using System.Security.Cryptography.X509Certificates;

namespace playfairGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            richTextBox.TextChanged += OnRichTextBoxTextChanged;
        }

        private void OnRichTextBoxTextChanged(object? sender, EventArgs e)
        {
            //if (richTextBox.Text.Split(' ').Any(x => x.Length != 2))
            //    label.ForeColor = Color.Red;
            //else if (richTextBox.Text.Any(x => (x < 65 || x > 90) && x != 32))
            //    label.ForeColor = Color.Blue;
            //else if (richTextBox.Text.Split(' ').Any(x => x[0] == x[1]))
            //    label.ForeColor = Color.Magenta;
            //else label.ForeColor = Color.Green;

            label.ForeColor = richTextBox switch
            {
                { Text: var t } when t.Split(' ').Any(x => x.Length != 2) => Color.Red,
                { Text: var t } when t.Any(x => (x < 65 || x > 90) && x != 32) => Color.Blue,
                { Text: var t } when t.Split(' ').Any(x => x[0] == x[1]) => Color.Magenta,
                _ => Color.Green,
            };
        }
    }
}