﻿#pragma checksum "..\..\..\FlightManager.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79C12915E9370DE5CB0D3375AFEA5B62FE914127"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AssigmentPRN;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace AssigmentPRN {
    
    
    /// <summary>
    /// FlightManager
    /// </summary>
    public partial class FlightManager : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbAirlineSelect;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbDepartingAirportSelect;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbArrivingAirportSelect;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtID;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbAirline;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbDepartingAirport;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbArrivingAirport;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDepartingGate;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtArrivingGate;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDepartureDate;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker tpDepartureTime;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpArrivalDate;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker tpArrivalTime;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\FlightManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FlightDataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AssigmentPRN;component/flightmanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FlightManager.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 23 "..\..\..\FlightManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_AddClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 24 "..\..\..\FlightManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_DeleteClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 25 "..\..\..\FlightManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_UpdateClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 26 "..\..\..\FlightManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_ExcelClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 27 "..\..\..\FlightManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Bin);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\FlightManager.xaml"
            this.SearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbAirlineSelect = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\FlightManager.xaml"
            this.cmbAirlineSelect.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbAirlineSelect_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cmbDepartingAirportSelect = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\..\FlightManager.xaml"
            this.cmbDepartingAirportSelect.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbDepartingAirportSelect_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cmbArrivingAirportSelect = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\..\FlightManager.xaml"
            this.cmbArrivingAirportSelect.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbArrivingAirportSelect_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 48 "..\..\..\FlightManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_ResetFilterClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.cmbAirline = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.cmbDepartingAirport = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            this.cmbArrivingAirport = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 15:
            this.txtDepartingGate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.txtArrivingGate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.dpDepartureDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 97 "..\..\..\FlightManager.xaml"
            this.dpDepartureDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpDepartureDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.tpDepartureTime = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 19:
            this.dpArrivalDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 111 "..\..\..\FlightManager.xaml"
            this.dpArrivalDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpArrivalDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 20:
            this.tpArrivalTime = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 21:
            
            #line 123 "..\..\..\FlightManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.FlightDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 140 "..\..\..\FlightManager.xaml"
            this.FlightDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FlightDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 143 "..\..\..\FlightManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PreviousPage_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 144 "..\..\..\FlightManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NextPage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

