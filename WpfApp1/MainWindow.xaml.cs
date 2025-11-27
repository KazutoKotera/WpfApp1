using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // 画面の読み込み
            InitializeComponent();
        }

        // 画面設定ウィンドウを開く
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settings = new SettingsWindow(this); // MainWindow を渡す
            settings.Owner = this;      // ← ここで所有者を設定
            settings.ShowDialog();      // モーダルで開く
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GalleryButton_Click(object sender, RoutedEventArgs e)
        {
            // ホーム画面を隠す
            HomeGrid.Visibility = Visibility.Collapsed;

            // ContentArea をクリアしてギャラリー画面を追加
            ContentArea.Children.Clear();
            var gallery = new GalleryView();
            gallery.BackRequested += () =>
            {
                ContentArea.Children.Clear();
                HomeGrid.Visibility = Visibility.Visible; // ホーム画面を再表示
            };
            ContentArea.Children.Add(gallery);
        }
    }
}