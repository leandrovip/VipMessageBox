using System.Windows;
using VipCore.MessageBox;

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
            MessageBoxVIP.Show(this, "Teste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagemTeste de mensagem",
                "Teste de Titulo",MessageBoxButton.YesNo,MessageBoxImage.Information);
        }

        private void Button2_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxVIP.Show(this, "Teste de mensagem 2 para pergunta ?",
                "Teste de Titulo 2", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
        }

        private void Button3_OnClick(object sender, RoutedEventArgs e)
        {
            var texto =  InputBoxVIP.Show(this, "Informe seu nome de usuário", "VipERP - Nome de Usuário",
                MessageBoxImage.Information, "Leandro");

            if (!string.IsNullOrEmpty(texto))
                MessageBoxVIP.Show(this, texto, "Retorno de mensagem");
        }
    }
}