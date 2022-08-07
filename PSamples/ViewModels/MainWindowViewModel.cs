using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PSamples.Views;

namespace PSamples.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private IRegionManager _regionManager;
        private string _title = "PrismSample";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            SystemDateUpdateButton = new DelegateCommand(
                SystemDateUpdateButtonExecute);
            ShowViewAButton = new DelegateCommand(
                ShowViewAButtonExecute);
        }

        private string _systemDateLabel = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        public string SystemDateLabel
        {
            get { return _systemDateLabel; }
            set { SetProperty(ref _systemDateLabel, value); }
        }

        public DelegateCommand SystemDateUpdateButton { get; }

        public DelegateCommand ShowViewAButton{ get; }
        private void SystemDateUpdateButtonExecute()
        {
            SystemDateLabel =
                System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void ShowViewAButtonExecute()
        {
            _regionManager.RequestNavigate(
                "ContentRegion", nameof(ViewA));
        }
    }
}
