﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StoreLogOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum StoreLogOptions : uint
  {
    None = 0,
    TryElevate = 1,
  }
}
