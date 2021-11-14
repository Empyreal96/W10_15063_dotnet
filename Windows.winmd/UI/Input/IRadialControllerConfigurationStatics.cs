// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerConfigurationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(2042015973, 1690, 17542, 169, 157, 141, 183, 114, 185, 100, 47)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RadialControllerConfiguration))]
  internal interface IRadialControllerConfigurationStatics
  {
    RadialControllerConfiguration GetForCurrentView();
  }
}
