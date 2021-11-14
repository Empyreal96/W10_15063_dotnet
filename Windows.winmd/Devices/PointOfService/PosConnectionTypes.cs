// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosConnectionTypes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Flags]
  public enum PosConnectionTypes : uint
  {
    Local = 1,
    IP = 2,
    Bluetooth = 4,
    All = 4294967295, // 0xFFFFFFFF
  }
}
