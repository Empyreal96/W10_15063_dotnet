// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IColorKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(3038610137, 2320, 17801, 162, 132, 176, 201, 32, 88, 88, 233)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ColorKeyFrame))]
  [WebHostHidden]
  internal interface IColorKeyFrame
  {
    Color Value { get; set; }

    KeyTime KeyTime { get; set; }
  }
}
