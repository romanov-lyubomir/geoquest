namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string randomCountry = "";
        string randomCode = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries.Add("Albania", "AL");
            countries.Add("Andorra", "AD");
            countries.Add("Austria", "AT");
            countries.Add("Azerbaijan", "AZ");
            countries.Add("Armenia", "AM");
            countries.Add("Belarus", "BY");
            countries.Add("Belgium", "BE");
            countries.Add("Bosnia and Herzegovina", "BA");
            countries.Add("Bulgaria", "BG");
            countries.Add("Croatia", "HR");
            countries.Add("Cyprus", "CY");
            countries.Add("Czech Republic", "CZ");
            countries.Add("Denmark", "DK");
            countries.Add("Estonia", "EE");
            countries.Add("Finland", "FI");
            countries.Add("France", "FR");
            countries.Add("Germany", "DE");
            countries.Add("Georgia", "GE");
            countries.Add("Greece", "GR");
            countries.Add("Hungary", "HU");
            countries.Add("Iceland", "IS");
            countries.Add("Ireland", "IE");
            countries.Add("Italy", "IT");
            countries.Add("Kosovo", "XK");
            countries.Add("Latvia", "LV");
            countries.Add("Liechtenstein", "LI");
            countries.Add("Lithuania", "LT");
            countries.Add("Luxembourg", "LU");
            countries.Add("Macedonia", "MK");
            countries.Add("Malta", "MT");
            countries.Add("Moldova", "MD");
            countries.Add("Monaco", "MC");
            countries.Add("Montenegro", "ME");
            countries.Add("The Netherlands", "NL");
            countries.Add("Norway", "NO");
            countries.Add("Poland", "PL");
            countries.Add("Portugal", "PT");
            countries.Add("Romania", "RO");
            countries.Add("Russia", "RU");
            countries.Add("San Marino", "SM");
            countries.Add("Serbia", "RS");
            countries.Add("Slovakia", "SK");
            countries.Add("Slovenia", "SI");
            countries.Add("Spain", "ES");
            countries.Add("Sweden", "SE");
            countries.Add("Switzerland", "CH");
            countries.Add("Türkiye", "TR");
            countries.Add("Ukraine", "UA");
            countries.Add("United Kingdom", "UK");
            countries.Add("Vatican City", "VA");

            // Shuffle the dictionary
            countries = countries.OrderBy(x => Guid.NewGuid()).ToDictionary(item => item.Key, item => item.Value);

            int randomIndex = new Random().Next(countries.Count);
            randomCountry = countries.ElementAt(randomIndex).Key;
            randomCode = countries.ElementAt(randomIndex).Value;
            label1.Text += $"{randomCountry} ({randomCode})";


            // For pictureBox1 to pictureBox50 set the image to the flag of the country
            for (int i = 1; i <= 50; i++)
            {
                PictureBox pb = (PictureBox)this.Controls.Find($"pictureBox{i}", true)[0];
                pb.Image = Image.FromFile($"Flags\\{countries.ElementAt(i - 1).Value}.png");
            }
        }
    }
}