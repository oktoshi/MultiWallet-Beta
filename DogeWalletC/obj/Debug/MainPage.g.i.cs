﻿#pragma checksum "D:\Program Files\Onedrive\Documents\Visual Studio Solutions\DogeWalletC\DogeWalletC\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "85B2C9CA76D8602042484444C3CBD254"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace DogeWalletC {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock DogecoinBalance;
        
        internal System.Windows.Controls.TextBlock DogeUnconfirmedBalance;
        
        internal System.Windows.Controls.TextBlock BitcoinBalance;
        
        internal System.Windows.Controls.TextBlock BitUnconfirmedBalance;
        
        internal System.Windows.Controls.TextBlock LitecoinBalance;
        
        internal System.Windows.Controls.TextBlock LiteUnconfirmedBalance;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/DogeWalletC;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.DogecoinBalance = ((System.Windows.Controls.TextBlock)(this.FindName("DogecoinBalance")));
            this.DogeUnconfirmedBalance = ((System.Windows.Controls.TextBlock)(this.FindName("DogeUnconfirmedBalance")));
            this.BitcoinBalance = ((System.Windows.Controls.TextBlock)(this.FindName("BitcoinBalance")));
            this.BitUnconfirmedBalance = ((System.Windows.Controls.TextBlock)(this.FindName("BitUnconfirmedBalance")));
            this.LitecoinBalance = ((System.Windows.Controls.TextBlock)(this.FindName("LitecoinBalance")));
            this.LiteUnconfirmedBalance = ((System.Windows.Controls.TextBlock)(this.FindName("LiteUnconfirmedBalance")));
        }
    }
}

