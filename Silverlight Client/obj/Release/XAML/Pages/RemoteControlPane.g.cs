﻿#pragma checksum "C:\Users\carl\Visual Studio\Projects\RemotePotatoServer\SilverPotato\XAML\Pages\RemoteControlPane.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B89548EC603DABCB8BD85B2B34796CF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace SilverPotato {
    
    
    public partial class RemoteControlPane : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Ellipse Play;
        
        internal System.Windows.Shapes.Ellipse Power;
        
        internal System.Windows.Shapes.Ellipse Stop;
        
        internal System.Windows.Shapes.Ellipse Ffw;
        
        internal System.Windows.Shapes.Ellipse Rew;
        
        internal System.Windows.Shapes.Ellipse SkipFwd;
        
        internal System.Windows.Shapes.Ellipse SkipBack;
        
        internal System.Windows.Shapes.Ellipse Record;
        
        internal System.Windows.Shapes.Ellipse Pause;
        
        internal System.Windows.Shapes.Ellipse NavBack;
        
        internal System.Windows.Shapes.Ellipse Info;
        
        internal System.Windows.Shapes.Ellipse NavUp;
        
        internal System.Windows.Shapes.Ellipse NavDown;
        
        internal System.Windows.Shapes.Ellipse NavLeft;
        
        internal System.Windows.Shapes.Ellipse NavRight;
        
        internal System.Windows.Shapes.Ellipse OK;
        
        internal System.Windows.Shapes.Rectangle Menu;
        
        internal System.Windows.Shapes.Ellipse VolUp;
        
        internal System.Windows.Shapes.Ellipse VolDown;
        
        internal System.Windows.Shapes.Ellipse ChanUp;
        
        internal System.Windows.Shapes.Ellipse ChanDown;
        
        internal System.Windows.Shapes.Ellipse VolMute;
        
        internal System.Windows.Shapes.Rectangle GotoRecTV;
        
        internal System.Windows.Shapes.Rectangle GotoGuide;
        
        internal System.Windows.Shapes.Rectangle GotoLiveTV;
        
        internal System.Windows.Shapes.Rectangle DVDMenu;
        
        internal System.Windows.Shapes.Rectangle GotoMovies;
        
        internal System.Windows.Shapes.Rectangle GotoMusic;
        
        internal System.Windows.Shapes.Rectangle GotoPictures;
        
        internal System.Windows.Shapes.Rectangle GotoVideos;
        
        internal System.Windows.Shapes.Ellipse Num1;
        
        internal System.Windows.Shapes.Ellipse Num2;
        
        internal System.Windows.Shapes.Ellipse Num3;
        
        internal System.Windows.Shapes.Ellipse Num4;
        
        internal System.Windows.Shapes.Ellipse Num5;
        
        internal System.Windows.Shapes.Ellipse Num6;
        
        internal System.Windows.Shapes.Ellipse Num7;
        
        internal System.Windows.Shapes.Ellipse Num8;
        
        internal System.Windows.Shapes.Ellipse Num9;
        
        internal System.Windows.Shapes.Ellipse NumStar;
        
        internal System.Windows.Shapes.Ellipse Num0;
        
        internal System.Windows.Shapes.Ellipse NumHash;
        
        internal System.Windows.Shapes.Ellipse Clear;
        
        internal System.Windows.Shapes.Ellipse Enter;
        
        internal System.Windows.Controls.TextBlock lblResult;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverPotato;component/XAML/Pages/RemoteControlPane.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Play = ((System.Windows.Shapes.Ellipse)(this.FindName("Play")));
            this.Power = ((System.Windows.Shapes.Ellipse)(this.FindName("Power")));
            this.Stop = ((System.Windows.Shapes.Ellipse)(this.FindName("Stop")));
            this.Ffw = ((System.Windows.Shapes.Ellipse)(this.FindName("Ffw")));
            this.Rew = ((System.Windows.Shapes.Ellipse)(this.FindName("Rew")));
            this.SkipFwd = ((System.Windows.Shapes.Ellipse)(this.FindName("SkipFwd")));
            this.SkipBack = ((System.Windows.Shapes.Ellipse)(this.FindName("SkipBack")));
            this.Record = ((System.Windows.Shapes.Ellipse)(this.FindName("Record")));
            this.Pause = ((System.Windows.Shapes.Ellipse)(this.FindName("Pause")));
            this.NavBack = ((System.Windows.Shapes.Ellipse)(this.FindName("NavBack")));
            this.Info = ((System.Windows.Shapes.Ellipse)(this.FindName("Info")));
            this.NavUp = ((System.Windows.Shapes.Ellipse)(this.FindName("NavUp")));
            this.NavDown = ((System.Windows.Shapes.Ellipse)(this.FindName("NavDown")));
            this.NavLeft = ((System.Windows.Shapes.Ellipse)(this.FindName("NavLeft")));
            this.NavRight = ((System.Windows.Shapes.Ellipse)(this.FindName("NavRight")));
            this.OK = ((System.Windows.Shapes.Ellipse)(this.FindName("OK")));
            this.Menu = ((System.Windows.Shapes.Rectangle)(this.FindName("Menu")));
            this.VolUp = ((System.Windows.Shapes.Ellipse)(this.FindName("VolUp")));
            this.VolDown = ((System.Windows.Shapes.Ellipse)(this.FindName("VolDown")));
            this.ChanUp = ((System.Windows.Shapes.Ellipse)(this.FindName("ChanUp")));
            this.ChanDown = ((System.Windows.Shapes.Ellipse)(this.FindName("ChanDown")));
            this.VolMute = ((System.Windows.Shapes.Ellipse)(this.FindName("VolMute")));
            this.GotoRecTV = ((System.Windows.Shapes.Rectangle)(this.FindName("GotoRecTV")));
            this.GotoGuide = ((System.Windows.Shapes.Rectangle)(this.FindName("GotoGuide")));
            this.GotoLiveTV = ((System.Windows.Shapes.Rectangle)(this.FindName("GotoLiveTV")));
            this.DVDMenu = ((System.Windows.Shapes.Rectangle)(this.FindName("DVDMenu")));
            this.GotoMovies = ((System.Windows.Shapes.Rectangle)(this.FindName("GotoMovies")));
            this.GotoMusic = ((System.Windows.Shapes.Rectangle)(this.FindName("GotoMusic")));
            this.GotoPictures = ((System.Windows.Shapes.Rectangle)(this.FindName("GotoPictures")));
            this.GotoVideos = ((System.Windows.Shapes.Rectangle)(this.FindName("GotoVideos")));
            this.Num1 = ((System.Windows.Shapes.Ellipse)(this.FindName("Num1")));
            this.Num2 = ((System.Windows.Shapes.Ellipse)(this.FindName("Num2")));
            this.Num3 = ((System.Windows.Shapes.Ellipse)(this.FindName("Num3")));
            this.Num4 = ((System.Windows.Shapes.Ellipse)(this.FindName("Num4")));
            this.Num5 = ((System.Windows.Shapes.Ellipse)(this.FindName("Num5")));
            this.Num6 = ((System.Windows.Shapes.Ellipse)(this.FindName("Num6")));
            this.Num7 = ((System.Windows.Shapes.Ellipse)(this.FindName("Num7")));
            this.Num8 = ((System.Windows.Shapes.Ellipse)(this.FindName("Num8")));
            this.Num9 = ((System.Windows.Shapes.Ellipse)(this.FindName("Num9")));
            this.NumStar = ((System.Windows.Shapes.Ellipse)(this.FindName("NumStar")));
            this.Num0 = ((System.Windows.Shapes.Ellipse)(this.FindName("Num0")));
            this.NumHash = ((System.Windows.Shapes.Ellipse)(this.FindName("NumHash")));
            this.Clear = ((System.Windows.Shapes.Ellipse)(this.FindName("Clear")));
            this.Enter = ((System.Windows.Shapes.Ellipse)(this.FindName("Enter")));
            this.lblResult = ((System.Windows.Controls.TextBlock)(this.FindName("lblResult")));
        }
    }
}
