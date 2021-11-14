// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Core.IRadialControllerIndependentInputSourceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Core
{
  [Guid(1029144309, 19694, 4582, 181, 53, 0, 27, 220, 6, 171, 59)]
  [ExclusiveTo(typeof (RadialControllerIndependentInputSource))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRadialControllerIndependentInputSourceStatics
  {
    RadialControllerIndependentInputSource CreateForView(
      CoreApplicationView view);
  }
}
