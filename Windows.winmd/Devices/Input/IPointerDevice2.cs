// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IPointerDevice2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ExclusiveTo(typeof (PointerDevice))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4171682464, 50308, 18591, 174, 62, 48, 210, 238, 31, 253, 62)]
  internal interface IPointerDevice2
  {
    uint MaxPointersWithZDistance { get; }
  }
}
