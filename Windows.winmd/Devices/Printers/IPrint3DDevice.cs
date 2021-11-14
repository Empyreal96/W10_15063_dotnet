// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IPrint3DDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [ContractVersion(typeof (PrintersContract), 65536)]
  [ExclusiveTo(typeof (Print3DDevice))]
  [Guid(68959513, 38675, 17058, 152, 19, 125, 195, 51, 116, 40, 211)]
  internal interface IPrint3DDevice
  {
    PrintSchema PrintSchema { get; }
  }
}
