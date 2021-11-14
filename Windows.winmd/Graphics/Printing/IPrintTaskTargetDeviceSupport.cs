// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskTargetDeviceSupport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ExclusiveTo(typeof (PrintTask))]
  [Guid(693989568, 49867, 19325, 176, 234, 147, 9, 80, 145, 162, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrintTaskTargetDeviceSupport
  {
    bool IsPrinterTargetEnabled { set; get; }

    bool Is3DManufacturingTargetEnabled { set; get; }
  }
}
