﻿#pragma checksum "..\..\..\Wind\RegistrWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04ABC6094B31EBA9A1CC2596D93E7C6E80C21FC3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfApp1.Wind;


namespace WpfApp1.Wind {
    
    
    /// <summary>
    /// RegistrWindow
    /// </summary>
    public partial class RegistrWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Wind\RegistrWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Name;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\Wind\RegistrWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame AdFrameNavigation;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\Wind\RegistrWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost hechoPriem;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\Wind\RegistrWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_namePr;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\Wind\RegistrWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_durability;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\Wind\RegistrWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_pricePr;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\Wind\RegistrWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_description;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/wind/registrwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Wind\RegistrWindow.xaml"
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
            
            #line 29 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DragAdminWin_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Name = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            
            #line 35 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HelpBut_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 36 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AboutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 40 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinimizedWin_CLick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 44 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeAcc_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 48 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AdminClose_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 89 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HomePage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 98 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Timetable_CLick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 119 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Client_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 129 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Service_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 139 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Service_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.AdFrameNavigation = ((System.Windows.Controls.Frame)(target));
            return;
            case 14:
            this.hechoPriem = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 15:
            this.txt_namePr = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.txt_durability = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.txt_pricePr = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            this.txt_description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            
            #line 171 "..\..\..\Wind\RegistrWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RegestrPriem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
