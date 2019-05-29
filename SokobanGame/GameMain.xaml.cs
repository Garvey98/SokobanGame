﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SokobanGame
{
  /// <summary>
  /// Interaction logic for GameMain.xaml
  /// </summary>
  public partial class GameMain : Page
  {
    public GameMain()
    {
      InitializeComponent();
    }

    private void GoBack(object sender, RoutedEventArgs e)
    {
      var result = MessageBox.Show("Do you really want to leave this level?", "Abort level", MessageBoxButton.YesNo, MessageBoxImage.Question);
      if (result == MessageBoxResult.Yes)
      {
        NavigationService.Navigate(new Uri("LevelSelect.xaml", UriKind.Relative));
      }
      else
      {
        // Do nothing.
      }
    }

    private void BackHome(object sender, RoutedEventArgs e)
    {
      NavigationService.Navigate(new Uri("WelcomePage.xaml", UriKind.Relative));
    }
  }
}
