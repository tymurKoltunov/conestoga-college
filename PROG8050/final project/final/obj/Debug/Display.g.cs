﻿#pragma checksum "..\..\Display.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F61EE1FC9A9C96C3B27157323BA8C4E290C5BE7DD74806F314299BC31BC6E035"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using final;


namespace final {
    
    
    /// <summary>
    /// Display
    /// </summary>
    public partial class Display : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Display.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbFilter;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Display.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFilter;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Display.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAll;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Display.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridDisp;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Display.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDispClose;
        
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
            System.Uri resourceLocater = new System.Uri("/final;component/display.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Display.xaml"
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
            this.CmbFilter = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.BtnFilter = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Display.xaml"
            this.BtnFilter.Click += new System.Windows.RoutedEventHandler(this.BtnFilter_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnAll = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Display.xaml"
            this.BtnAll.Click += new System.Windows.RoutedEventHandler(this.BtnAll_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GridDisp = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.BtnDispClose = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\Display.xaml"
            this.BtnDispClose.Click += new System.Windows.RoutedEventHandler(this.BtnDispClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

