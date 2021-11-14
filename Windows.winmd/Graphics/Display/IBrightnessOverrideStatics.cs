// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IBrightnessOverrideStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Guid(61323757, 57841, 19048, 161, 31, 148, 106, 216, 206, 83, 147)]
  [ExclusiveTo(typeof (BrightnessOverride))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IBrightnessOverrideStatics
  {
    BrightnessOverride GetDefaultForSystem();

    BrightnessOverride GetForCurrentView();

    [RemoteAsync]
    IAsyncOperation<bool> SaveForSystemAsync(BrightnessOverride value);
  }
}
