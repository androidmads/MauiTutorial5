namespace MauiTutorial5;

public partial class MainPage : ContentPage
{
    int i = 0;
    Easing[] Easings = new Easing[]
    {
        Easing.Linear,
        Easing.SinOut,
        Easing.SinIn,
        Easing.SinInOut,
        Easing.CubicIn,
        Easing.CubicOut,
        Easing.CubicInOut,
        Easing.BounceOut,
        Easing.BounceIn,
        Easing.SpringIn,
        Easing.SpringOut,
    };
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await image.ScaleTo(2, 2000, Easings[i]);
        image.Scale = 1;
        i++;
        if (i >= Easings.Length)
            i = 0;
    }
}

