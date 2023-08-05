namespace ButtonState;

public class MainPageViewModel
{
    private bool flag;

    public Command OnCommand { get; }
    public Command OffCommand { get; }

    public MainPageViewModel()
    {
        OnCommand = new Command(() => Update(true), () => !flag);
        OffCommand = new Command(() => Update(false), () => flag);
    }

    private void Update(bool value)
    {
        flag = value;
        OnCommand.ChangeCanExecute();
        OffCommand.ChangeCanExecute();
    }
}
