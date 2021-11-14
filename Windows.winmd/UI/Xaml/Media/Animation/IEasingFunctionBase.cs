// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEasingFunctionBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EasingFunctionBase))]
  [Guid(3238541375, 11266, 16721, 142, 205, 104, 221, 170, 63, 13, 155)]
  [WebHostHidden]
  internal interface IEasingFunctionBase
  {
    EasingMode EasingMode { get; set; }

    double Ease(double normalizedTime);
  }
}
