﻿#pragma checksum "..\..\LibrarianDashboard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AA86A4588C2730D041251C870AD47DA8A2A30F89CC8B0070F12C5D7EF3DB2F28"
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
    /// LibrarianDashboard
    /// </summary>
    public partial class LibrarianDashboard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\LibrarianDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Library.LibrarianDashboard LibrarainDashboard1;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\LibrarianDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MemberDashboardBtn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\LibrarianDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BookDashboardBtn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\LibrarianDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AccountDashboardBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\LibrarianDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\LibrarianDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FullNameTxB;
        
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
            System.Uri resourceLocater = new System.Uri("/Library;component/librariandashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LibrarianDashboard.xaml"
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
            this.LibrarainDashboard1 = ((Library.LibrarianDashboard)(target));
            
            #line 8 "..\..\LibrarianDashboard.xaml"
            this.LibrarainDashboard1.Loaded += new System.Windows.RoutedEventHandler(this.LibrarainDashboard1_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MemberDashboardBtn = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\LibrarianDashboard.xaml"
            this.MemberDashboardBtn.Click += new System.Windows.RoutedEventHandler(this.MemberDashboardBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BookDashboardBtn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\LibrarianDashboard.xaml"
            this.BookDashboardBtn.Click += new System.Windows.RoutedEventHandler(this.BookDashboardBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AccountDashboardBtn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\LibrarianDashboard.xaml"
            this.AccountDashboardBtn.Click += new System.Windows.RoutedEventHandler(this.AccountDashboardBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LogoutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\LibrarianDashboard.xaml"
            this.LogoutBtn.Click += new System.Windows.RoutedEventHandler(this.LogoutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FullNameTxB = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

