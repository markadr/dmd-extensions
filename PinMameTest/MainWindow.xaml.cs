﻿using System;
using System.Threading;
using System.Windows;
using System.Windows.Media;

namespace PinMameTest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private VPinMameController Controller;

		public MainWindow()
		{

			InitializeComponent();

			Console.WriteLine("[{0}] Starting...", Thread.CurrentThread.ManagedThreadId);

			Controller = new VPinMameController();
			//Controller.Run("mm_109b").Subscribe(status => {
			Controller.Run("tz_92").Subscribe(status => {

				Console.WriteLine("[{0}] Game status: {1}", Thread.CurrentThread.ManagedThreadId, status);
			});
		}
	}
}