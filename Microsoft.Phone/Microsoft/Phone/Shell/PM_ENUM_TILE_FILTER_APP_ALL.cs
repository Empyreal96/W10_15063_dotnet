// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.PM_ENUM_TILE_FILTER_APP_ALL
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Shell
{
  internal struct PM_ENUM_TILE_FILTER_APP_ALL
  {
    public uint FilterType;
    [MarshalAs(UnmanagedType.Struct)]
    public Guid TileProductID;
    public uint Padding;

    public void init()
    {
      this.FilterType = 11U;
      this.Padding = 0U;
    }
  }
}
