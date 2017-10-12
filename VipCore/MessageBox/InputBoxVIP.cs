using System.Windows;
using VipCore.Enum;

namespace VipCore.MessageBox
{
    public class InputBoxVIP
    {
        public static string Show(Window owner = null, string messageBoxText = "", string caption = "",
            MessageBoxImage icon = MessageBoxImage.Information, string defaultResponse = "")
        {
            var messageBox = new Message();
            if (owner != null)
            {
                messageBox.Owner = owner;
                messageBox.Icon = owner.Icon;
            }

            messageBox.type = MessageBoxType.InputBox;
            messageBox.messageTextBox = messageBoxText;
            messageBox.caption = caption;
            messageBox.button = MessageBoxButton.OKCancel;
            messageBox.icon = icon;
            messageBox.defaultResponse = defaultResponse;

            var dialogResult = messageBox.ShowDialog();
            switch (dialogResult)
            {
                case null:
                    return "";
                case true:
                    return messageBox.messageboxResult == MessageBoxResult.OK ? messageBox.tbInput.Text : "";
                default:
                    return "";
            }
        }
    }
}