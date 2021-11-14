// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteRestrictions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  [WebHostHidden]
  public enum MapRouteRestrictions : uint
  {
    None = 0,
    Highways = 1,
    TollRoads = 2,
    Ferries = 4,
    Tunnels = 8,
    DirtRoads = 16, // 0x00000010
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Motorail = 32, // 0x00000020
  }
}
