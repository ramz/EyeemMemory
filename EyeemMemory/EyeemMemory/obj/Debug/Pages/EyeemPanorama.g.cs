﻿#pragma checksum "C:\Users\tobi\Documents\Visual Studio 2010\Projects\EyeemMemory\EyeemMemory\EyeemMemory\Pages\EyeemPanorama.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DF90EF502586B5DF9DC89B147547BEA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.261
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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


namespace EyeemMemory {
    
    
    public partial class EyeemPanorama : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Panorama PanoramaView;
        
        internal System.Windows.Controls.Image default_image_1;
        
        internal System.Windows.Controls.Image default_image_2;
        
        internal System.Windows.Controls.Image default_image_3;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.TextBox Search_Text;
        
        internal System.Windows.Controls.Button Search_Button;
        
        internal System.Windows.Controls.ListBox Album_List;
        
        internal Microsoft.Phone.Controls.PanoramaItem HighscoreTab;
        
        internal System.Windows.Controls.ListBox Highscore_List;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/EyeemMemory;component/Pages/EyeemPanorama.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PanoramaView = ((Microsoft.Phone.Controls.Panorama)(this.FindName("PanoramaView")));
            this.default_image_1 = ((System.Windows.Controls.Image)(this.FindName("default_image_1")));
            this.default_image_2 = ((System.Windows.Controls.Image)(this.FindName("default_image_2")));
            this.default_image_3 = ((System.Windows.Controls.Image)(this.FindName("default_image_3")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.Search_Text = ((System.Windows.Controls.TextBox)(this.FindName("Search_Text")));
            this.Search_Button = ((System.Windows.Controls.Button)(this.FindName("Search_Button")));
            this.Album_List = ((System.Windows.Controls.ListBox)(this.FindName("Album_List")));
            this.HighscoreTab = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("HighscoreTab")));
            this.Highscore_List = ((System.Windows.Controls.ListBox)(this.FindName("Highscore_List")));
        }
    }
}
