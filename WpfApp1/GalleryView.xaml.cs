using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{

    public partial class GalleryView : UserControl
    {
        // 戻るボタンが押されたら通知するためのイベント
        public event Action BackRequested;

        public GalleryView()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            BackRequested?.Invoke();
        }
    }
}