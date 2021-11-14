// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IBackEase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(3833042663, 63493, 19087, 129, 201, 56, 230, 71, 44, 170, 148)]
  [ExclusiveTo(typeof (BackEase))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackEase
  {
    double Amplitude { get; set; }
  }
}
