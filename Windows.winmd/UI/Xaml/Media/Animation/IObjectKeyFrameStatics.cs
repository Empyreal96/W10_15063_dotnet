// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IObjectKeyFrameStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(752265984, 21273, 17030, 142, 237, 78, 117, 94, 160, 207, 156)]
  [ExclusiveTo(typeof (ObjectKeyFrame))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IObjectKeyFrameStatics
  {
    DependencyProperty ValueProperty { get; }

    DependencyProperty KeyTimeProperty { get; }
  }
}
