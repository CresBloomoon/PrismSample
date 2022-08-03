using Prism.Commands;
using Prism.Mvvm;

namespace PSamples.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "PrismSample";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            SystemDateUpdateButton = new DelegateCommand(
                SystemDateUpdateButtonExecute);
        }

        private string _systemDateLabel = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        public string SystemDateLabel
        {
            get { return _systemDateLabel; }
            set { SetProperty(ref _systemDateLabel, value); }
        }

        public DelegateCommand SystemDateUpdateButton { get; }
        private void SystemDateUpdateButtonExecute()
        {
            SystemDateLabel =
                System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
