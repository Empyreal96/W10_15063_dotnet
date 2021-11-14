// Decompiled with JetBrains decompiler
// Type: System.Windows.Controls.Common.DependencyObjectExtensions
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Diagnostics.CodeAnalysis;

namespace System.Windows.Controls.Common
{
  internal static class DependencyObjectExtensions
  {
    private static bool _areHandlersSuspended;

    public static void SetValueNoCallback(
      this DependencyObject obj,
      DependencyProperty property,
      object value)
    {
      DependencyObjectExtensions._areHandlersSuspended = true;
      try
      {
        obj.SetValue(property, value);
      }
      finally
      {
        DependencyObjectExtensions._areHandlersSuspended = false;
      }
    }

    [SuppressMessage("Microsoft.Usage", "CA1801", Justification = "obj parameter is needed for the extension method.")]
    public static bool AreHandlersSuspended(this DependencyObject obj) => DependencyObjectExtensions._areHandlersSuspended;
  }
}
