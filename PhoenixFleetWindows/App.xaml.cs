using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using ABI.Windows.UI.ViewManagement;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using WinRT.Interop;
using Colors = ABI.Microsoft.UI.Colors;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PhoenixFleetWindows {
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application {
        private AppWindow m_AppWindow;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App() {
            this.InitializeComponent();
            m_AppWindow = GetAppWindowForCurrentWindow();
            m_AppWindow.Title = "Phoenix Legacy Fleet Suite";
            ExtendAcrylicIntoTitleBar();
        }
        private AppWindow GetAppWindowForCurrentWindow() {
            IntPtr hWnd = WindowNative.GetWindowHandle(this);
            WindowId wndId = Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(wndId);
        }
        private void ExtendAcrylicIntoTitleBar() {
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            var titleBar = m_AppWindow.TitleBar;
            //ApplicationViewTitleBar titleBar = 
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }
        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args) {
            m_window = new MainWindow();
            m_window.Activate();
            
        }

        private Window m_window;
    }
}
