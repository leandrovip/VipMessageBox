using System.Windows;
using VipMessageBox.MessageBox;

namespace VipCore.Demo
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var stringValue =
                @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna. Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.";

            MessageBoxVIP.Show(this,
                stringValue,
                "Título da mensagem", MessageBoxButton.YesNo);
        }

        private void Button2_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxVIP.Show(this, "Gostou da customização do MessageBox ?",
                "Título da mensagem 2", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
        }

        private void Button3_OnClick(object sender, RoutedEventArgs e)
        {
            var texto = InputBoxVIP.Show(this, "Informe seu nome de usuário", "Título da caixa de texto",
                MessageBoxImage.Information, "Nome padrão");

            MessageBoxVIP.Show(this, texto, "Texto informado");
        }

        private void Button4_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}