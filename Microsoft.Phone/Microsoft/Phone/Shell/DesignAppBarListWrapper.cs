// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.DesignAppBarListWrapper
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Shell.Interop;
using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Shell
{
  internal class DesignAppBarListWrapper : IListInterop
  {
    public void InsertMenuItem(int idCommand, MenuBarItemType type, int index)
    {
    }

    public void RemoveMenuItem(MenuBarItemType type, int index)
    {
    }

    public void SetMenuItem(
      int id,
      MenuBarItemType type,
      bool enabled,
      string validatedText,
      UriInteropWrapper validatedUri)
    {
    }

    public IList<int> GetIds() => throw new NotImplementedException();

    public bool GetProperties(
      int index,
      MenuBarItemType type,
      out string text,
      out string uri,
      out bool enabled)
    {
      throw new NotImplementedException();
    }
  }
}
