﻿#pragma checksum "..\..\TVagasEmpresa.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E5EB3C85E42C69A2762DBE0AB261CC9308497A9DBFF37B7624BCC09E9AE157E7"
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
    /// TVagasEmpresa
    /// </summary>
    public partial class TVagasEmpresa : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 107 "..\..\TVagasEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCriar;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\TVagasEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPendentes;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\TVagasEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEmAberto;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\TVagasEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFinalizadas;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\TVagasEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridConteudo;
        
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
            System.Uri resourceLocater = new System.Uri("/JobStack;component/tvagasempresa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TVagasEmpresa.xaml"
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
            this.BtnCriar = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\TVagasEmpresa.xaml"
            this.BtnCriar.Click += new System.Windows.RoutedEventHandler(this.BtnCriar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnPendentes = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\TVagasEmpresa.xaml"
            this.BtnPendentes.Click += new System.Windows.RoutedEventHandler(this.BtnPendentes_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnEmAberto = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\TVagasEmpresa.xaml"
            this.BtnEmAberto.Click += new System.Windows.RoutedEventHandler(this.BtnEmAberto_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnFinalizadas = ((System.Windows.Controls.Button)(target));
            
            #line 145 "..\..\TVagasEmpresa.xaml"
            this.BtnFinalizadas.Click += new System.Windows.RoutedEventHandler(this.BtnFinalizadas_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GridConteudo = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

