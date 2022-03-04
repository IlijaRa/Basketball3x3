﻿#pragma checksum "..\..\CreateTournament.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EB20CA8120867795CD35A394D408CFEB205DEAA98EE4DDDE06B09AA6903C940E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Basketball3x3;
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


namespace Basketball3x3 {
    
    
    /// <summary>
    /// CreateTournament
    /// </summary>
    public partial class CreateTournament : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Tournament;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_selectTeam;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_tournamentTeams;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_prizes;
        
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
            System.Uri resourceLocater = new System.Uri("/Basketball3x3;component/createtournament.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateTournament.xaml"
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
            
            #line 7 "..\..\CreateTournament.xaml"
            ((Basketball3x3.CreateTournament)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label_Tournament = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.cb_selectTeam = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            
            #line 21 "..\..\CreateTournament.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_CreateTeam);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 22 "..\..\CreateTournament.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_AddTeam);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 23 "..\..\CreateTournament.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_CreatePrize);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lb_tournamentTeams = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            
            #line 27 "..\..\CreateTournament.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_RemoveSelectedTeam);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lb_prizes = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            
            #line 30 "..\..\CreateTournament.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_RemoveSelectedPrize);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 32 "..\..\CreateTournament.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_GoBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

