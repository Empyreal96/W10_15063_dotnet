// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IFocusSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(2039844715, 12899, 17013, 133, 214, 174, 174, 137, 28, 150, 238)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FocusSettings))]
  internal interface IFocusSettings
  {
    FocusMode Mode { get; set; }

    AutoFocusRange AutoFocusRange { get; set; }

    IReference<uint> Value { get; set; }

    IReference<ManualFocusDistance> Distance { get; set; }

    bool WaitForFocus { get; set; }

    bool DisableDriverFallback { get; set; }
  }
}
