﻿#pragma checksum "..\..\MemberSearchBook.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5BD83D110126D83EACDD1BD953441243F7283F5A5543A5564AF26D8038DB9F21"
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
    /// MemberSearchBook
    /// </summary>
    public partial class MemberSearchBook : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\MemberSearchBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Library.MemberSearchBook MemberSearchBook1;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\MemberSearchBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MemberSearchBookDG;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MemberSearchBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTxtBx;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MemberSearchBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Library;component/membersearchbook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MemberSearchBook.xaml"
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
            this.MemberSearchBook1 = ((Library.MemberSearchBook)(target));
            
            #line 8 "..\..\MemberSearchBook.xaml"
            this.MemberSearchBook1.Loaded += new System.Windows.RoutedEventHandler(this.MemberSearchBook1_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MemberSearchBookDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.SearchTxtBx = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\MemberSearchBook.xaml"
            this.SearchTxtBx.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTxtBx_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\MemberSearchBook.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
