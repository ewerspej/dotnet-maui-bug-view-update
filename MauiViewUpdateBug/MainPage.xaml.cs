namespace MauiViewUpdateBug;

public partial class MainPage : ContentPage
{
    public int Clicks { get; set; }

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        VisualStateManager.GoToState(MyButton, width > height ? "Landscape" : "Portrait");
    }

    private void MyButton_OnClicked(object sender, EventArgs e)
    {
        Clicks++;
        OnPropertyChanged(nameof(Clicks));
    }
}

