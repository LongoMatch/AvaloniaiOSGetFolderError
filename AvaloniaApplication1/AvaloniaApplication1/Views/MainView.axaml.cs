using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;

namespace AvaloniaApplication1.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var storageProvider = TopLevel.GetTopLevel(this)?.StorageProvider;

        if (storageProvider == null)
        {
            return;
        }

        try
        {
            storageProvider.TryGetWellKnownFolderAsync(WellKnownFolder.Pictures);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }
}