// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ProgressIndicator
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell.Interop;
using System;
using System.Windows;

namespace Microsoft.Phone.Shell
{
  public class ProgressIndicator : DependencyObject
  {
    public static readonly DependencyProperty IsVisibleProperty = DependencyProperty.Register(nameof (IsVisible), typeof (bool), typeof (ProgressIndicator), new PropertyMetadata((object) false, new PropertyChangedCallback(ProgressIndicator.OnIsVisiblePropertyChanged)));
    public static readonly DependencyProperty IsIndeterminateProperty = DependencyProperty.Register(nameof (IsIndeterminate), typeof (bool), typeof (ProgressIndicator), new PropertyMetadata((object) false, new PropertyChangedCallback(ProgressIndicator.OnIsIndeterminatePropertyChanged)));
    public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof (Text), typeof (string), typeof (ProgressIndicator), new PropertyMetadata((object) "", new PropertyChangedCallback(ProgressIndicator.OnTextPropertyChanged)));
    public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(nameof (Value), typeof (double), typeof (ProgressIndicator), new PropertyMetadata((object) 0.0, new PropertyChangedCallback(ProgressIndicator.OnValuePropertyChanged)));

    internal static ProgressIndicator GetActiveProgressIndicator()
    {
      ProgressIndicator progressIndicator = (ProgressIndicator) null;
      PhoneApplicationPage activePage = PhoneApplicationPage.GetActivePage();
      if (activePage != null)
        progressIndicator = activePage.ProgressIndicator;
      return progressIndicator;
    }

    public bool IsVisible
    {
      get => (bool) this.GetValue(ProgressIndicator.IsVisibleProperty);
      set => this.SetValue(ProgressIndicator.IsVisibleProperty, value);
    }

    private static void OnIsVisiblePropertyChanged(
      DependencyObject dependencyObject,
      DependencyPropertyChangedEventArgs e)
    {
      if (dependencyObject as ProgressIndicator != ProgressIndicator.GetActiveProgressIndicator())
        return;
      NativeSystemTrayInteropWrapper.ProgressIndicatorIsVisible = (bool) e.NewValue;
    }

    public bool IsIndeterminate
    {
      get => (bool) this.GetValue(ProgressIndicator.IsIndeterminateProperty);
      set => this.SetValue(ProgressIndicator.IsIndeterminateProperty, value);
    }

    private static void OnIsIndeterminatePropertyChanged(
      DependencyObject dependencyObject,
      DependencyPropertyChangedEventArgs e)
    {
      if (dependencyObject as ProgressIndicator != ProgressIndicator.GetActiveProgressIndicator())
        return;
      NativeSystemTrayInteropWrapper.ProgressIndicatorIsIndeterminate = (bool) e.NewValue;
    }

    public string Text
    {
      get => (string) this.GetValue(ProgressIndicator.TextProperty);
      set => this.SetValue(ProgressIndicator.TextProperty, (object) value);
    }

    private static void OnTextPropertyChanged(
      DependencyObject dependencyObject,
      DependencyPropertyChangedEventArgs e)
    {
      if (dependencyObject as ProgressIndicator != ProgressIndicator.GetActiveProgressIndicator())
        return;
      NativeSystemTrayInteropWrapper.ProgressIndicatorText = (string) e.NewValue;
    }

    public double Value
    {
      get => (double) this.GetValue(ProgressIndicator.ValueProperty);
      set => this.SetValue(ProgressIndicator.ValueProperty, value);
    }

    private static void OnValuePropertyChanged(
      DependencyObject dependencyObject,
      DependencyPropertyChangedEventArgs e)
    {
      ProgressIndicator progressIndicator = dependencyObject as ProgressIndicator;
      double newValue = (double) e.NewValue;
      if (newValue < 0.0 || newValue > 1.0)
      {
        progressIndicator.Value = ProgressIndicator.ClampedProgressValue(newValue);
      }
      else
      {
        if (progressIndicator != ProgressIndicator.GetActiveProgressIndicator())
          return;
        NativeSystemTrayInteropWrapper.ProgressIndicatorValue = (float) newValue;
      }
    }

    private static double ClampedProgressValue(double value) => Math.Min(Math.Max(value, 0.0), 1.0);
  }
}
