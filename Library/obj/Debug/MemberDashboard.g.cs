﻿#pragma checksum "..\..\MemberDashboard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "451D3F3B01901F321C36E6D83A8219A763585525E1E3A43DA1C7C93D53D5F972"
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
    /// MemberDashboard
    /// </summary>
    public partial class MemberDashboard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\MemberDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Library.MemberDashboard MemberDashboard1;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\MemberDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BorrowedBookBtn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MemberDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AccountDashboardBtn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MemberDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MemberDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FullNameTxtB;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MemberDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchBookBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Library;component/memberdashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MemberDashboard.xaml"
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
            this.MemberDashboard1 = ((Library.MemberDashboard)(target));
            
            #line 8 "..\..\MemberDashboard.xaml"
            this.MemberDashboard1.Loaded += new System.Windows.RoutedEventHandler(this.MemberDashboard1_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BorrowedBookBtn = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\MemberDashboard.xaml"
            this.BorrowedBookBtn.Click += new System.Windows.RoutedEventHandler(this.BorrowedBookBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AccountDashboardBtn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\MemberDashboard.xaml"
            this.AccountDashboardBtn.Click += new System.Windows.RoutedEventHandler(this.AccountDashboardBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LogoutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\MemberDashboard.xaml"
            this.LogoutBtn.Click += new System.Windows.RoutedEventHandler(this.LogoutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FullNameTxtB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.SearchBookBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\MemberDashboard.xaml"
            this.SearchBookBtn.Click += new System.Windows.RoutedEventHandler(this.SearchBook1Btn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

