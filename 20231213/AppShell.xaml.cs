﻿using _20231213.Pages;

namespace _20231213
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GraphicsPage), typeof(GraphicsPage));
            Routing.RegisterRoute(nameof(ScannerPage), typeof(ScannerPage));
            Routing.RegisterRoute(nameof(TrazosPage), typeof(TrazosPage));
            Routing.RegisterRoute(nameof(MapaPage), typeof(MapaPage));
            Routing.RegisterRoute(nameof(MediaPage), typeof(MediaPage));
        }
    }
}
