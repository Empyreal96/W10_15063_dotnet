// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.JournalEventArgs
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace System.Windows.Navigation
{
  internal sealed class JournalEventArgs : EventArgs
  {
    internal JournalEventArgs(string name, Uri uri, NavigationMode mode)
    {
      Guard.ArgumentNotNull((object) uri, nameof (uri));
      this.Name = name;
      this.Uri = uri;
      this.NavigationMode = mode;
      this.IsPaused = false;
    }

    internal JournalEventArgs(string name, Uri uri, NavigationMode mode, bool isPaused)
    {
      Guard.ArgumentNotNull((object) uri, nameof (uri));
      this.Name = name;
      this.Uri = uri;
      this.NavigationMode = mode;
      this.IsPaused = isPaused;
    }

    internal string Name { get; private set; }

    internal Uri Uri { get; private set; }

    internal NavigationMode NavigationMode { get; private set; }

    internal bool IsExternal { get; set; }

    internal bool CancelBack { get; set; }

    internal bool IsPaused { get; set; }
  }
}
