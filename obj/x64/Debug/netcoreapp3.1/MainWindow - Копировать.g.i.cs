#pragma checksum "..\..\..\..\MainWindow - Копировать.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BC6418D87F29D554C837154F4BD3BD9199E93CDD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CefSharp.Wpf;
using PDA2._0_;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PDA2._0_ {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\MainWindow - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WindowName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\MainWindow - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CefSharp.Wpf.ChromiumWebBrowser Maps;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\MainWindow - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TimeLabel;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\MainWindow - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TasksButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\MainWindow - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MapsButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\MainWindow - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas OffScreen;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\MainWindow - Копировать.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox tasksList;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PDA2.0.;V1.0.0.0;component/mainwindow%20-%20%d0%9a%d0%be%d0%bf%d0%b8%d1%80%d0%be" +
                    "%d0%b2%d0%b0%d1%82%d1%8c.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MainWindow - Копировать.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.WindowName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            
            #line 40 "..\..\..\..\MainWindow - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OffButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Maps = ((CefSharp.Wpf.ChromiumWebBrowser)(target));
            return;
            case 4:
            this.TimeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.TasksButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\MainWindow - Копировать.xaml"
            this.TasksButton.Click += new System.Windows.RoutedEventHandler(this.TasksButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MapsButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\MainWindow - Копировать.xaml"
            this.MapsButton.Click += new System.Windows.RoutedEventHandler(this.MapsButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 54 "..\..\..\..\MainWindow - Копировать.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.OffScreen = ((System.Windows.Controls.Canvas)(target));
            return;
            case 9:
            this.tasksList = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

