namespace Polualphabetic
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPlainText.Text) ||
                string.IsNullOrEmpty(textBoxKey.Text))
                MessageBox.Show(
                    "Enter in Plain and Key.",
                    "WARNING",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            else
                PolyaplhabeticEncryptCiper();

        }
        public void PolyaplhabeticEncryptCiper()
        {
            char[] cipher = new char[100];

            string c = "";

            int i;
            int j = 0;

            string p = textBoxPlainText.Text.ToLower();
            char[] plain = p.ToCharArray();
            string k = textBoxKey.Text.ToLower();
            char[] key = k.ToCharArray();

            for (i = 0; i < plain.Length; i++)
            {
                if (j == key.Length)
                    j = 0;

                if ((plain[i] + (key[j] - 96)) > 122)
                {
                    cipher[i] = Convert.ToChar(plain[i] + ((key[j] - 96) - 26));
                    j++;
                }
                else
                {
                    cipher[i] = Convert.ToChar(plain[i] + (key[j] - 96));
                    j++;
                }
            }
            for (i = 0; i < plain.Length; i++)
            {
                c += cipher[i];
            }
            textBoxCiper.Text = c;
        }
        public void PolyaplhabeticDectyptCiper()
        {
            char[] plain = new char[100];

            string p = "";

            int i;
            int j = 0;

            string c = textBoxCiper.Text.ToLower();
            char[] ciper = c.ToCharArray();
            string k = textBoxKey.Text.ToLower();
            char[] key = k.ToCharArray();

            for (i = 0; i < ciper.Length; i++)
            {
                if (j == key.Length)
                    j = 0;

                if ((ciper[i] - (key[j] - 97)) < 122 &&
                    (ciper[i] - (key[j] - 97)) >= 98)
                {
                    plain[i] = Convert.ToChar(ciper[i] - (key[j] - 96));
                    j++;
                }
                else
                {
                    plain[i] = Convert.ToChar(ciper[i] - ((key[j] - 97) - 26));
                    j++;
                }
            }
            for (i = 0; i < ciper.Length; i++)
            {
                p += plain[i];
            }
            textBoxPlainText.Text = p;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCiper.Text) &&
                string.IsNullOrEmpty(textBoxKey.Text))
                MessageBox.Show(
                        "Enter in Ciper and Key.",
                        "WARNING",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            else
                PolyaplhabeticDectyptCiper();
        }
    }
}