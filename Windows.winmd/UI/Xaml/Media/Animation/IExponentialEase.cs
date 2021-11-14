// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IExponentialEase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(2092557341, 61627, 19402, 157, 165, 155, 163, 161, 23, 52, 196)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ExponentialEase))]
  internal interface IExponentialEase
  {
    double Exponent { get; set; }
  }
}
