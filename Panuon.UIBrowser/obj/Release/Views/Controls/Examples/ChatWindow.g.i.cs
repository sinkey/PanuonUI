﻿#pragma checksum "..\..\..\..\..\Views\Controls\Examples\ChatWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "475D5D303EABE4D003A8B1C35214B6BAB8106218"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Panuon.UI;
using Panuon.UIBrowser.Views.Control.Examples;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Panuon.UIBrowser.Views.Control.Examples {
    
    
    /// <summary>
    /// ChatWindow
    /// </summary>
    public partial class ChatWindow : Panuon.UI.PUWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\Views\Controls\Examples\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer svMain;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Views\Controls\Examples\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stkMain;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Views\Controls\Examples\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Panuon.UI.PUTextBox tbInput;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Views\Controls\Examples\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Panuon.UI.PUButton btnSend;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Views\Controls\Examples\ChatWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Panuon.UI.PUButton btnClose;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Panuon.UIBrowser;component/views/controls/examples/chatwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Controls\Examples\ChatWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.svMain = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 2:
            this.stkMain = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.tbInput = ((Panuon.UI.PUTextBox)(target));
            return;
            case 4:
            this.btnSend = ((Panuon.UI.PUButton)(target));
            
            #line 48 "..\..\..\..\..\Views\Controls\Examples\ChatWindow.xaml"
            this.btnSend.Click += new System.Windows.RoutedEventHandler(this.btnSend_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnClose = ((Panuon.UI.PUButton)(target));
            
            #line 57 "..\..\..\..\..\Views\Controls\Examples\ChatWindow.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

