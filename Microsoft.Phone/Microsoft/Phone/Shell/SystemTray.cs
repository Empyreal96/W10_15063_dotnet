// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.SystemTray
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Media;

namespace Microsoft.Phone.Shell
{
  public class SystemTray : DependencyObject
  {
    public static readonly DependencyProperty IsVisibleProperty = DependencyProperty.RegisterAttached(nameof (IsVisible), typeof (bool), typeof (SystemTray), new PropertyMetadata((object) false, new PropertyChangedCallback(SystemTray.OnIsVisiblePropertyChanged)));
    public static readonly DependencyProperty OpacityProperty = DependencyProperty.RegisterAttached(nameof (Opacity), typeof (double), typeof (SystemTray), new PropertyMetadata((object) 1.0, new PropertyChangedCallback(SystemTray.OnOpacityPropertyChanged)));
    public static readonly DependencyProperty ForegroundColorProperty = DependencyProperty.RegisterAttached(nameof (ForegroundColor), typeof (Color), typeof (SystemTray), new PropertyMetadata((object) Colors.White, new PropertyChangedCallback(SystemTray.OnForegroundColorPropertyChanged)));
    public static readonly DependencyProperty BackgroundColorProperty = DependencyProperty.RegisterAttached(nameof (BackgroundColor), typeof (Color), typeof (SystemTray), new PropertyMetadata(new PropertyChangedCallback(SystemTray.OnBackgroundColorPropertyChanged)));
    public static readonly DependencyProperty ProgressIndicatorProperty = DependencyProperty.RegisterAttached(nameof (ProgressIndicator), typeof (ProgressIndicator), typeof (SystemTray), new PropertyMetadata((object) null, new PropertyChangedCallback(SystemTray.OnProgressIndicatorPropertyChanged)));

    public static void SetIsVisible(DependencyObject element, bool isVisible) => element.SetValue(SystemTray.IsVisibleProperty, isVisible);

    public static bool GetIsVisible(DependencyObject element) => (bool) element.GetValue(SystemTray.IsVisibleProperty);

    private static void OnIsVisiblePropertyChanged(
      DependencyObject dependencyObject,
      DependencyPropertyChangedEventArgs e)
    {
      if (!(dependencyObject is PhoneApplicationPage phoneApplicationPage))
        return;
      phoneApplicationPage.SystemTrayIsVisible = (bool) e.NewValue;
    }

    public static bool IsVisible
    {
      get => SystemTray.GetIsVisible((DependencyObject) (PhoneApplicationPage.GetActivePage() ?? throw new InvalidOperationException("To get SystemTray visibility the RootVisual must be a PhoneApplicationFrame and its Content must be a PhoneApplicationPage")));
      set => SystemTray.SetIsVisible((DependencyObject) (PhoneApplicationPage.GetActivePage() ?? throw new InvalidOperationException("To set SystemTray visibility the RootVisual must be a PhoneApplicationFrame and its Content must be a PhoneApplicationPage")), value);
    }

    public static void SetOpacity(DependencyObject element, double opacity) => element.SetValue(SystemTray.OpacityProperty, opacity);

    public static double GetOpacity(DependencyObject element) => (double) element.GetValue(SystemTray.OpacityProperty);

    private static double ClampedOpacity(double opacity) => Math.Min(Math.Max(opacity, 0.0), 1.0);

    private static void OnOpacityPropertyChanged(
      DependencyObject dependencyObject,
      DependencyPropertyChangedEventArgs e)
    {
      double newValue = (double) e.NewValue;
      if (newValue < 0.0 || newValue > 1.0)
      {
        SystemTray.SetOpacity(dependencyObject, SystemTray.ClampedOpacity(newValue));
      }
      else
      {
        if (!(dependencyObject is PhoneApplicationPage phoneApplicationPage2))
          return;
        phoneApplicationPage2.SystemTrayOpacity = (float) (double) e.NewValue;
      }
    }

    public static double Opacity
    {
      get => SystemTray.GetOpacity((DependencyObject) (PhoneApplicationPage.GetActivePage() ?? throw new InvalidOperationException("To get SystemTray opacity the RootVisual must be a PhoneApplicationFrame and its Content must be a PhoneApplicationPage")));
      set => SystemTray.SetOpacity((DependencyObject) (PhoneApplicationPage.GetActivePage() ?? throw new InvalidOperationException("To set SystemTray opacity the RootVisual must be a PhoneApplicationFrame and its Content must be a PhoneApplicationPage")), value);
    }

    public static void SetForegroundColor(DependencyObject element, Color color) => element.SetValue(SystemTray.ForegroundColorProperty, color);

    public static Color GetForegroundColor(DependencyObject element) => (Color) element.GetValue(SystemTray.ForegroundColorProperty);

    private static void OnForegroundColorPropertyChanged(
      DependencyObject dependencyObject,
      DependencyPropertyChangedEventArgs e)
    {
      if (!(dependencyObject is PhoneApplicationPage phoneApplicationPage))
        return;
      phoneApplicationPage.SystemTrayForegroundColor = (Color) e.NewValue;
    }

    public static Color ForegroundColor
    {
      get => SystemTray.GetForegroundColor((DependencyObject) (PhoneApplicationPage.GetActivePage() ?? throw new InvalidOperationException("To get SystemTray ForegroundColor the RootVisual must be a PhoneApplicationFrame and its Content must be a PhoneApplicationPage")));
      set => SystemTray.SetForegroundColor((DependencyObject) (PhoneApplicationPage.GetActivePage() ?? throw new InvalidOperationException("To set SystemTray ForegroundColor the RootVisual must be a PhoneApplicationFrame and its Content must be a PhoneApplicationPage")), value);
    }

    public static void SetBackgroundColor(DependencyObject element, Color color) => element.SetValue(SystemTray.BackgroundColorProperty, color);

    public static Color GetBackgroundColor(DependencyObject element) => (Color) element.GetValue(SystemTray.BackgroundColorProperty);

    private static void OnBackgroundColorPropertyChanged(
      DependencyObject dependencyObject,
      DependencyPropertyChangedEventArgs e)
    {
      if (!(dependencyObject is PhoneApplicationPage phoneApplicationPage))
        return;
      phoneApplicationPage.SystemTrayBackgroundColor = (Color) e.NewValue;
    }

    public static Color BackgroundColor
    {
      get => SystemTray.GetBackgroundColor((DependencyObject) (PhoneApplicationPage.GetActivePage() ?? throw new InvalidOperationException("To get SystemTray BackgroundColor the RootVisual must be a PhoneApplicationFrame and its Content must be a PhoneApplicationPage")));
      set => SystemTray.SetBackgroundColor((DependencyObject) (PhoneApplicationPage.GetActivePage() ?? throw new InvalidOperationException("To set SystemTray BackgroundColor the RootVisual must be a PhoneApplicationFrame and its Content must be a PhoneApplicationPage")), value);
    }

    public static void SetProgressIndicator(
      DependencyObject element,
      ProgressIndicator progressIndicator)
    {
      element.SetValue(SystemTray.ProgressIndicatorProperty, (DependencyObject) progressIndicator);
    }

    public static ProgressIndicator GetProgressIndicator(DependencyObject element) => (ProgressIndicator) element.GetValue(SystemTray.ProgressIndicatorProperty);

    private static void OnProgressIndicatorPropertyChanged(
      DependencyObject dependencyObject,
      DependencyPropertyChangedEventArgs e)
    {
      if (!(dependencyObject is PhoneApplicationPage phoneApplicationPage))
        return;
      phoneApplicationPage.ProgressIndicator = (ProgressIndicator) e.NewValue;
    }

    public static ProgressIndicator ProgressIndicator
    {
      get => SystemTray.GetProgressIndicator((DependencyObject) (PhoneApplicationPage.GetActivePage() ?? throw new InvalidOperationException("To get SystemTray ProgressIndicator the RootVisual must be a PhoneApplicationFrame and its Content must be a PhoneApplicationPage")));
      set => SystemTray.SetProgressIndicator((DependencyObject) (PhoneApplicationPage.GetActivePage() ?? throw new InvalidOperationException("To set SystemTray ProgressIndicator the RootVisual must be a PhoneApplicationFrame and its Content must be a PhoneApplicationPage")), value);
    }
  }
}
