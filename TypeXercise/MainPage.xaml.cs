using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Controls;
using muxc=Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TypeXercise
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavigationViewItem_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            
            if (sender != null)
            {

                muxc.NavigationViewItem navigationViewItem = sender as muxc.NavigationViewItem;
                var StackPanel = navigationViewItem.Content as StackPanel;
                var AnimatedVisualPlayer = StackPanel.Children[0] as muxc.AnimatedVisualPlayer;
                AnimatedVisualPlayer.AutoPlay = true;
            }
        }

        private void NavigationViewItem_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (sender != null)
            {
                muxc.NavigationViewItem navigationViewItem = sender as muxc.NavigationViewItem;
                var StackPanel = navigationViewItem.Content as StackPanel;
                var AnimatedVisualPlayer = StackPanel.Children[0] as muxc.AnimatedVisualPlayer;
                AnimatedVisualPlayer.AutoPlay = false;
            }
        }
    }
}
