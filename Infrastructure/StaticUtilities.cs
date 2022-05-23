using System;
using Microsoft.UI.Xaml.Controls;

namespace Infrastructure; 

public class StaticUtilities {
    public void SetCurrentNavigationViewItem(
        NavigationViewItem item, 
        NavigationView senderNavigationView, 
        Frame senderFrame) {

        if (item == null) {
            return;
        }

        if (item.Tag == null) {
            return;
        }

        senderFrame.Navigate(
            Type.GetType(item.Tag.ToString()),
            item.Content);
        senderNavigationView.Header = item.Content;
        senderNavigationView.SelectedItem = item;
    }
}