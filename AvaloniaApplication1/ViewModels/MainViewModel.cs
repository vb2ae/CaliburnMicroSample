using System.Threading;

namespace AvaloniaApplication1.ViewModels
{
    public class MainViewModel : Screen
    {
        public MainViewModel()
        {
            DisplayName = "Welcome to Main View Model in Avalonia!";
        }

        protected override async Task OnInitializedAsync(CancellationToken cancellationToken)
        {
            await base.OnInitializedAsync(cancellationToken);
        }

        public async Task OnOkButtonClick()
        {
            DisplayName = "Button Clicked... waiting";
            await Task.Delay(1500);

            DisplayName = "Wait over!";
        }
    }
}
