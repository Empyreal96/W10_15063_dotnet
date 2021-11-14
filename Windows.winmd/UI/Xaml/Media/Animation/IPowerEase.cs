// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPowerEase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (PowerEase))]
  [Guid(1774716281, 61151, 16475, 134, 128, 217, 96, 104, 128, 201, 55)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPowerEase
  {
    double Power { get; set; }
  }
}
