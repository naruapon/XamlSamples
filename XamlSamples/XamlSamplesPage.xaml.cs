using Xamarin.Forms;

namespace XamlSamples
{
    public partial class XamlSamplesPage : ContentPage
    {
        public XamlSamplesPage()
        {
            InitializeComponent();
            Button button = new Button
            {
                Text = "Navigate!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new HelloXamlPage());
            };

            Content = button;
        }
    }
}
