﻿#pragma checksum "..\..\ExtendBorrowedBookDate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E5F961A9B24E536C9D1ED63610BB0FA28EE14D0396625B96E67EC4AA9E2E92D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library;
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


namespace Library {
    
    
    /// <summary>
    /// ExtendBorrowedBookDate
    /// </summary>
    public partial class ExtendBorrowedBookDate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\ExtendBorrowedBookDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ReturnDateDP;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ExtendBorrowedBookDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DeadlineDP;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ExtendBorrowedBookDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExtendDateBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ExtendBorrowedBookDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ExtendBorrowedBookDate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookIdTxtBx;
        
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
            System.Uri resourceLocater = new System.Uri("/Library;component/extendborrowedbookdate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ExtendBorrowedBookDate.xaml"
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
            this.ReturnDateDP = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.DeadlineDP = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.ExtendDateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\ExtendBorrowedBookDate.xaml"
            this.ExtendDateBtn.Click += new System.Windows.RoutedEventHandler(this.ExtendDateBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\ExtendBorrowedBookDate.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BookIdTxtBx = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

