using System.Threading;

namespace AvaloniaApplication1.ViewModels
{
    public class ShellViewModel : Conductor<Screen>
    {
        public ShellViewModel()
        {

        }

        protected override async Task OnInitializedAsync(CancellationToken cancellationToken)
        {
            await base.OnInitializedAsync(cancellationToken);

            DisplayName = "Welcome to Caliburn.Micro.Avalonia!";
        }

        protected override async Task OnActivateAsync(CancellationToken cancellationToken)
        {
            await base.OnActivateAsync(cancellationToken);
            var mainVM = IoC.GetInstance(typeof(MainViewModel), null) as MainViewModel;
            await ActivateItemAsync(mainVM);
        }

    }
}
