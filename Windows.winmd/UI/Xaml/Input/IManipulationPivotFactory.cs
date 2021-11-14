// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationPivotFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(1829089337, 14082, 17302, 173, 155, 168, 37, 239, 166, 58, 59)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ManipulationPivot))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IManipulationPivotFactory
  {
    ManipulationPivot CreateInstanceWithCenterAndRadius(
      Point center,
      double radius);
  }
}
