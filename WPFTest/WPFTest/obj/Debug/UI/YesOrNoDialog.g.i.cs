﻿#pragma checksum "..\..\..\UI\YesOrNoDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4FC810691C5E80ECC248C07068A3737E01CB614A"
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


namespace WPFTest.UI {
    
    
    /// <summary>
    /// YesOrNoDialog
    /// </summary>
    public partial class YesOrNoDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\UI\YesOrNoDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock infoTextBlock;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\UI\YesOrNoDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border okBorder;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UI\YesOrNoDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border noBorder;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFTest;component/ui/yesornodialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\YesOrNoDialog.xaml"
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
            this.infoTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.okBorder = ((System.Windows.Controls.Border)(target));
            
            #line 21 "..\..\..\UI\YesOrNoDialog.xaml"
            this.okBorder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.okBorder_MouseDown);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\UI\YesOrNoDialog.xaml"
            this.okBorder.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.okBorder_TouchDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.noBorder = ((System.Windows.Controls.Border)(target));
            
            #line 29 "..\..\..\UI\YesOrNoDialog.xaml"
            this.noBorder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.noBorder_MouseDown);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\UI\YesOrNoDialog.xaml"
            this.noBorder.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.noBorder_TouchDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

