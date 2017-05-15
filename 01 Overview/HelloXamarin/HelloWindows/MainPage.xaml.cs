using Data;

namespace HelloWindows
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            RefreshButton.Click += async (s, e) =>
            {
                MyText.Text = "Please wait";
                var service = new YoutubeService();
                MyText.Text = await service.Refresh();
            };
        }
    }
}
