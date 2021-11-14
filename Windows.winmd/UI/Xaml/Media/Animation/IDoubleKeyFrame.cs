// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDoubleKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DoubleKeyFrame))]
  [Guid(1732531965, 59422, 20302, 180, 173, 10, 207, 237, 158, 205, 104)]
  [WebHostHidden]
  internal interface IDoubleKeyFrame
  {
    double Value { get; set; }

    KeyTime KeyTime { get; set; }
  }
}
