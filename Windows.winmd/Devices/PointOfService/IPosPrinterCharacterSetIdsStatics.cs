// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterCharacterSetIdsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1550884607, 28826, 20455, 178, 21, 6, 167, 72, 163, 139, 57)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PosPrinterCharacterSetIds))]
  internal interface IPosPrinterCharacterSetIdsStatics
  {
    uint Utf16LE { get; }

    uint Ascii { get; }

    uint Ansi { get; }
  }
}
