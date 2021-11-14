// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IBounceEase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (BounceEase))]
  [WebHostHidden]
  [Guid(737232462, 64625, 18413, 133, 161, 59, 169, 87, 119, 24, 180)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBounceEase
  {
    int Bounces { get; set; }

    double Bounciness { get; set; }
  }
}
