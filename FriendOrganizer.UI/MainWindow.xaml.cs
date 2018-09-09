﻿using FriendOrganizer.UI.ViewModel;
using System;
using System.Windows;

namespace FriendOrganizer.UI
{
	public partial class MainWindow : Window
	{
		private MainViewModel _viewModel;
		public MainWindow(MainViewModel viewModel)
		{
			InitializeComponent();
			_viewModel = viewModel;
			DataContext = _viewModel;
			Loaded += MainViewModel_Loaded;
		}

		private void MainViewModel_Loaded(object sender, RoutedEventArgs e)
		{
			_viewModel.Load();

		}
	}
}
