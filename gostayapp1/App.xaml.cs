﻿using Microsoft.Maui.Controls;

namespace gostayapp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell ();
	}
}

