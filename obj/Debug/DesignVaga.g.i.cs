﻿#pragma checksum "..\..\DesignVaga.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "76272BE0277BB2DB89864D2F0BBA9ED29C22510070E1E06C970CAF3D927F4D89"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using JobStack;
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


namespace JobStack {
    
    
    /// <summary>
    /// DesignVaga
    /// </summary>
    public partial class DesignVaga : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 74 "..\..\DesignVaga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NomeEmpresa;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\DesignVaga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridIconeEmpresa;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\DesignVaga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TipoVaga;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\DesignVaga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DescricaoVaga;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\DesignVaga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnVerMais;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\DesignVaga.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnInscreverse;
        
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
            System.Uri resourceLocater = new System.Uri("/JobStack;component/designvaga.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DesignVaga.xaml"
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
            this.NomeEmpresa = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.GridIconeEmpresa = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.TipoVaga = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.DescricaoVaga = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.BtnVerMais = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.BtnInscreverse = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\DesignVaga.xaml"
            this.BtnInscreverse.Click += new System.Windows.RoutedEventHandler(this.BtnInscreverse_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

