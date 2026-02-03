namespace inf04KoloryJasinski
{
    public partial class MainPage : ContentPage
    {
        int[] rolls = new int[5];
        public MainPage()
        {
            InitializeComponent();
        }
        private void RandomDice(object? sender, EventArgs e)
        {
            Random randomKostka = new Random();
            for (int r = 0; r < 5; r++)
            {
                rolls[r] = randomKostka.Next(1, 7);
            }
            Image1.Source = $"k{rolls[0]}.jpg";
            Image2.Source = $"k{rolls[1]}.jpg";
            Image3.Source = $"k{rolls[2]}.jpg";
            Image4.Source = $"k{rolls[3]}.jpg";
            Image5.Source = $"k{rolls[4]}.jpg";
        }
    }
}
