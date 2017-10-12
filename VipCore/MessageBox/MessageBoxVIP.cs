using System.Windows;
using VipCore.Enum;

namespace VipCore.MessageBox
{
    public class MessageBoxVIP
    {
        public static MessageBoxResult Show(Window owner, string messageBoxText = "", string caption = "",
            MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.Information)
        {
            var messageBox = new Message();
            if (owner != null)
            {
                messageBox.Owner = owner;
                messageBox.Icon = owner.Icon;
            }

            messageBox.type = MessageBoxType.MessageBox;
            messageBox.messageTextBox = messageBoxText;
            messageBox.caption = caption;
            messageBox.button = button;
            messageBox.icon = icon;

            var dialogResult = messageBox.ShowDialog();
            switch (dialogResult)
            {
                case null:
                    return MessageBoxResult.None;
                case true:
                    return messageBox.messageboxResult;
                default:
                    return MessageBoxResult.None;
            }
        }
    }
}