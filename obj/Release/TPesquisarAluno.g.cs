﻿#pragma checksum "..\..\TPesquisarAluno.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B3A530575185008200723D074573F23FE2C79BCA62ACB6DAD27AE253667BF254"
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
    /// TPesquisarAluno
    /// </summary>
    public partial class TPesquisarAluno : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 188 "..\..\TPesquisarAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridBarraPesquisa;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\TPesquisarAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CaixaPesquisa;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\TPesquisarAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPesquisar;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\TPesquisarAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridExibirVagas;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\TPesquisarAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle FundoGridVagas;
        
        #line default
        #line hidden
        
        
        #line 235 "..\..\TPesquisarAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer SVVagas;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\TPesquisarAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SPVagas;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\TPesquisarAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnVoltar;
        
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
            System.Uri resourceLocater = new System.Uri("/JobStack;component/tpesquisaraluno.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TPesquisarAluno.xaml"
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
            this.GridBarraPesquisa = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.CaixaPesquisa = ((System.Windows.Controls.TextBox)(target));
            
            #line 208 "..\..\TPesquisarAluno.xaml"
            this.CaixaPesquisa.GotFocus += new System.Windows.RoutedEventHandler(this.CaixaPesquisa_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnPesquisar = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.GridExibirVagas = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.FundoGridVagas = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 6:
            this.SVVagas = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 7:
            this.SPVagas = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.BtnVoltar = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

