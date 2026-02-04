namespace inf04KoloryJasinski
{
    public partial class MainPage : ContentPage
    {
        int[] rolls = new int[5];
        int wynikLos = 0;
        int wynikGry = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        private void RandomDice(object? sender, EventArgs e)
        {
            Random randomKostka = new Random();
            wynikLos = 0;
            for (int r = 0; r < 5; r++)
            {
                rolls[r] = randomKostka.Next(1, 7);
                wynikLos += rolls[r];
                wynikGry += rolls[r];
            }
            Image1.Source = $"k{rolls[0]}.jpg";
            Image2.Source = $"k{rolls[1]}.jpg";
            Image3.Source = $"k{rolls[2]}.jpg";
            Image4.Source = $"k{rolls[3]}.jpg";
            Image5.Source = $"k{rolls[4]}.jpg";

            WynikLosowania.Text = "";
            WynikLosowania.Text += "Wynik tego losowania:" + wynikLos;

            WynikGry.Text = "";
            WynikGry.Text = "Wynik gry:" + wynikGry;
        }

        private void ResetDice(object? sender, EventArgs e)
        {
            Image1.Source = $"question.jpg";
            Image2.Source = $"question.jpg";
            Image3.Source = $"question.jpg";
            Image4.Source = $"question.jpg";
            Image5.Source = $"question.jpg";

            wynikLos = 0;
            wynikGry = 0;

            WynikLosowania.Text = "Wynik tego losowania: 0";

            WynikGry.Text = "Wynik gry: 0";
        }
    }
}
