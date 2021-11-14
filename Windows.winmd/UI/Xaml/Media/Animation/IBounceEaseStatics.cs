// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IBounceEaseStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (BounceEase))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3228573090, 20339, 16841, 178, 203, 46, 163, 16, 81, 7, 255)]
  [WebHostHidden]
  internal interface IBounceEaseStatics
  {
    DependencyProperty BouncesProperty { get; }

    DependencyProperty BouncinessProperty { get; }
  }
}
