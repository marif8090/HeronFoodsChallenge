﻿#pragma checksum "..\..\..\ChildWindows\ProductWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12E45B5824AF8A85657EFBE6533F36C42BCBA486"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HeronFoodsChallenge.ChildWindows;
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


namespace HeronFoodsChallenge.ChildWindows {
    
    
    /// <summary>
    /// ProductWindow
    /// </summary>
    public partial class ProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\ChildWindows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProductCode;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ChildWindows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProductDescription;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ChildWindows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RetailPriceIncVAT;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ChildWindows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVATRate;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ChildWindows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBarcode;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\ChildWindows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateProduct;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ChildWindows\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/HeronFoodsChallenge;component/childwindows/productwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ChildWindows\ProductWindow.xaml"
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
            this.txtProductCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtProductDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RetailPriceIncVAT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtVATRate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtBarcode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnUpdateProduct = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\ChildWindows\ProductWindow.xaml"
            this.btnUpdateProduct.Click += new System.Windows.RoutedEventHandler(this.BtnUpdateProduct_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\ChildWindows\ProductWindow.xaml"
            this.btnAddProduct.Click += new System.Windows.RoutedEventHandler(this.BtnAddProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

