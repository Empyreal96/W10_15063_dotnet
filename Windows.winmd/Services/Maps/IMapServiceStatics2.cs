﻿// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapServiceStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapService))]
  [Guid(4162404077, 40069, 16553, 136, 150, 15, 195, 253, 43, 124, 42)]
  internal interface IMapServiceStatics2
  {
    string WorldViewRegionCode { get; }
  }
}
