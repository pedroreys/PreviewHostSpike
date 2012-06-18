using System.Windows;

namespace WPFPreviewHostSpike
{
    /// <summary>
    /// Interaction logic for AttachmentPreviewControl.xaml
    /// </summary>
    public partial class AttachmentPreviewControl
    {
        public AttachmentPreviewControl()
        {
            InitializeComponent();
        }

        public string FilePath
        {
            get { return (string) GetValue(FilePathProperty); }
            set{    SetValue(FilePathProperty, value);  }
        }

        public static readonly DependencyProperty FilePathProperty =
            DependencyProperty.Register("FilePath", typeof (string),
                                        typeof (AttachmentPreviewControl),
                                        new PropertyMetadata(null, FilePathPropertyChanged));

        private static void FilePathPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as AttachmentPreviewControl;
            if (control == null) return;
           
            control.PreviewHandler.Open(control.FilePath);
        }
    }
}
