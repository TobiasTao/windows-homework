﻿#pragma checksum "..\..\..\..\UI\Menu\MenuPageChapter3.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4BA04A744B3EE78B9D4053B36F96DB1EB5D226ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using WPFTest.UI;
using WPFTest.UI.Menu;


namespace WPFTest.UI.Menu {
    
    
    /// <summary>
    /// MenuPageChapter3
    /// </summary>
    public partial class MenuPageChapter3 : WPFTest.UI.ChildPage, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\UI\Menu\MenuPageChapter3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\UI\Menu\MenuPageChapter3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sh1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\UI\Menu\MenuPageChapter3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sh2;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\UI\Menu\MenuPageChapter3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sh3;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFTest;component/ui/menu/menupagechapter3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Menu\MenuPageChapter3.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.sh1 = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\UI\Menu\MenuPageChapter3.xaml"
            this.sh1.Click += new System.Windows.RoutedEventHandler(this.sy1_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sh2 = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\UI\Menu\MenuPageChapter3.xaml"
            this.sh2.Click += new System.Windows.RoutedEventHandler(this.sy2_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sh3 = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\UI\Menu\MenuPageChapter3.xaml"
            this.sh3.Click += new System.Windows.RoutedEventHandler(this.sy3_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

