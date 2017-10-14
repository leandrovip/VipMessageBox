using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using VipMessageBox.Enum;

namespace VipMessageBox.MessageBox
{
    public partial class Message
    {
        private readonly Dictionary<string, List<string>> language = new Dictionary<string, List<string>>
        {
            {"pt-BR", new List<string> {"OK", "Cancelar", "Sim", "Não"}},
            {"en-US", new List<string> {"OK", "Cancel", "Yes", "No"}}
        };

        public MessageBoxButton button = MessageBoxButton.OK;
        public string caption = "";

        public string defaultResponse = "";
        public MessageBoxImage icon = MessageBoxImage.None;
        public MessageBoxResult messageboxResult;
        public string messageTextBox = "";
        public MessageBoxType type = 0;

        public static string OKText { get; set; }
        public static string CancelText { get; set; }
        public static string YesText { get; set; }
        public static string NoText { get; set; }

        public Message()
        {
            InitializeComponent();
        }

        private void Message_Loaded(object sender, RoutedEventArgs e)
        {
            btnOK.Visibility = Visibility.Collapsed;
            btnYes.Visibility = Visibility.Collapsed;
            btnNo.Visibility = Visibility.Collapsed;
            btnCancel.Visibility = Visibility.Collapsed;

            tbInput.Visibility = Visibility.Collapsed;

            GroupBox.Header = string.IsNullOrEmpty(caption) ? "" : caption.Trim();
            tbContent.Text = string.IsNullOrEmpty(messageTextBox) ? "" : messageTextBox.Trim();

            LanguageButtons();

            switch (button)
            {
                case MessageBoxButton.OK:
                    btnOK.Visibility = Visibility.Visible;
                    break;
                case MessageBoxButton.OKCancel:
                    btnOK.Visibility = Visibility.Visible;
                    btnCancel.Visibility = Visibility.Visible;
                    break;
                case MessageBoxButton.YesNo:
                    btnYes.Visibility = Visibility.Visible;
                    btnNo.Visibility = Visibility.Visible;
                    break;
                case MessageBoxButton.YesNoCancel:
                    btnYes.Visibility = Visibility.Visible;
                    btnNo.Visibility = Visibility.Visible;
                    btnCancel.Visibility = Visibility.Visible;
                    break;
            }

            switch (icon)
            {
                case MessageBoxImage.Information:
                    imgIcon.Source = new BitmapImage(new Uri("../img/information.png", UriKind.Relative));
                    break;
                case MessageBoxImage.Error:
                    imgIcon.Source = new BitmapImage(new Uri("../img/critical.png", UriKind.Relative));
                    break;
                case MessageBoxImage.Exclamation:
                    imgIcon.Source = new BitmapImage(new Uri("../img/exclamation.png", UriKind.Relative));
                    break;
                case MessageBoxImage.Question:
                    imgIcon.Source = new BitmapImage(new Uri("../img/question.png", UriKind.Relative));
                    break;
            }

            switch (type)
            {
                case MessageBoxType.MessageBox:
                    break;
                case MessageBoxType.InputBox:
                    tbInput.Visibility = Visibility.Visible;
                    tbInput.Text = string.IsNullOrEmpty(defaultResponse) ? "" : defaultResponse.Trim();
                    tbInput.SelectAll();
                    tbInput.Focus();
                    break;
            }
        }

        private void LanguageButtons()
        {
            if (language.ContainsKey(CultureInfo.CurrentCulture.Name) &&
                language[CultureInfo.CurrentCulture.Name].Count == 4)
            {
                txtBtnOk.Text = language[CultureInfo.CurrentCulture.Name][0];
                txtBtnCancel.Text = language[CultureInfo.CurrentCulture.Name][1];
                txtBtnYes.Text = language[CultureInfo.CurrentCulture.Name][2];
                txtBtnNo.Text = language[CultureInfo.CurrentCulture.Name][3];
            }

            if (!string.IsNullOrEmpty(OKText)) txtBtnOk.Text = OKText;
            if (!string.IsNullOrEmpty(CancelText)) txtBtnCancel.Text = CancelText;
            if (!string.IsNullOrEmpty(YesText)) txtBtnYes.Text = YesText;
            if (!string.IsNullOrEmpty(NoText)) txtBtnNo.Text = NoText;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            messageboxResult = MessageBoxResult.Cancel;
            DialogResult = true;
        }

        private void BtnNo_Click(object sender, RoutedEventArgs e)
        {
            messageboxResult = MessageBoxResult.No;
            DialogResult = true;
        }

        private void BtnYes_Click(object sender, RoutedEventArgs e)
        {
            messageboxResult = MessageBoxResult.Yes;
            DialogResult = true;
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            messageboxResult = MessageBoxResult.OK;
            DialogResult = true;
        }

        private void GroupBox_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}