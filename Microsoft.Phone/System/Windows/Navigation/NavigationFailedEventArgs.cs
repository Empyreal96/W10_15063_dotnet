// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.NavigationFailedEventArgs
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Diagnostics.CodeAnalysis;

namespace System.Windows.Navigation
{
  [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "Classes inheriting from EventArgs are supposed to have EventArgs in their name.")]
  public sealed class NavigationFailedEventArgs : EventArgs
  {
    internal NavigationFailedEventArgs(Uri uri, Exception error)
    {
      this.Uri = uri;
      this.Exception = error;
    }

    public Uri Uri { get; private set; }

    public Exception Exception { get; private set; }

    public bool Handled { get; set; }
  }
}
