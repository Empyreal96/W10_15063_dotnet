// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.DesignAppBarWrapper
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell.Interop;
using System;
using System.Windows.Media;

namespace Microsoft.Phone.Shell
{
  internal class DesignAppBarWrapper : IAppBarInterop
  {
    public void CreateBar(AppBarCallbackInfo callbacks)
    {
    }

    public IListInterop GetListInterop() => (IListInterop) new DesignAppBarListWrapper();

    public void SetOpacity(double opacity)
    {
    }

    public void SetBackgroundColor(Color backgroundColor)
    {
    }

    public void SetForegroundColor(Color foregroundColor)
    {
    }

    public void SetMode(Microsoft.Phone.Shell.Interop.ApplicationBarMode mode)
    {
    }

    public void SetMenuEnabled(bool enabled)
    {
    }

    public void SetVisibility(bool isVisible)
    {
    }

    public void MakeVisibleAppBar()
    {
    }

    public Color GetBackgroundColor() => throw new NotImplementedException();

    public Color GetForegroundColor() => throw new NotImplementedException();

    public bool GetVisible() => throw new NotImplementedException();

    public bool GetMenuEnabled() => throw new NotImplementedException();
  }
}
