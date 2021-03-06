﻿#pragma checksum "..\..\BookDashboard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A3BD8D7871836D04A4234925F110FA8D9376A389B5FBC5A822B5B3B0EA9A686"
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
    /// BookDashboard
    /// </summary>
    public partial class BookDashboard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\BookDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewBookBtn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\BookDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBookInformationBtn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\BookDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BorrowBookBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\BookDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\BookDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BorrowBackBook;
        
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
            System.Uri resourceLocater = new System.Uri("/Library;component/bookdashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BookDashboard.xaml"
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
            this.AddNewBookBtn = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\BookDashboard.xaml"
            this.AddNewBookBtn.Click += new System.Windows.RoutedEventHandler(this.AddNewBookBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EditBookInformationBtn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\BookDashboard.xaml"
            this.EditBookInformationBtn.Click += new System.Windows.RoutedEventHandler(this.EditBookInformationBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BorrowBookBtn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\BookDashboard.xaml"
            this.BorrowBookBtn.Click += new System.Windows.RoutedEventHandler(this.BorrowBookBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\BookDashboard.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BorrowBackBook = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\BookDashboard.xaml"
            this.BorrowBackBook.Click += new System.Windows.RoutedEventHandler(this.BorrowBackBookBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

