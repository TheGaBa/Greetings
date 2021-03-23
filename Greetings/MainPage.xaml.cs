﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Greetings
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void element_PointerEnteredHome(object sender, PointerRoutedEventArgs e)
        {
            PointerEnterAnimationHome.Begin();
        }

        private void element_PointerEnteredLocation(object sender, PointerRoutedEventArgs e)
        {
            PointerEnterAnimationLocation.Begin();
        }

        private void element_PointerEnteredFavorite(object sender, PointerRoutedEventArgs e)
        {
            PointerEnterAnimationFavorite.Begin();
        }

        private void element_PointerEnteredInfo(object sender, PointerRoutedEventArgs e)
        {
            PointerEnterAnimationInfo.Begin();
        }

        private void element_PointerEnteredExit(object sender, PointerRoutedEventArgs e)
        {
            PointerEnterAnimationExit.Begin();
        }
    }
}