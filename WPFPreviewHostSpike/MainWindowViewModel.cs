using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Input;

namespace WPFPreviewHostSpike
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ICommand FileOpenCommand { get { return new RelayCommand(OpenFileDialog); } }

        public ICommand ShowPopupCommand { get { return new RelayCommand(ShowPopup); } }

        private void ShowPopup()
        {
            IsPopupOpen = true;
        }

        private bool _isPopupOpen;
        public bool IsPopupOpen
        {
            get { return _isPopupOpen; }
            set
            {
                _isPopupOpen = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IsPopupOpen"));
            }
        }


        private void OpenFileDialog()
        {
            var dialog = new OpenFileDialog();

            var result = dialog.ShowDialog();


            if (result == DialogResult.OK)
                FilePath = dialog.FileName;
        }


        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                PropertyChanged(this, new PropertyChangedEventArgs("FilePath"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate {  };
    }
}