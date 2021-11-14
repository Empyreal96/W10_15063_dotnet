// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrameStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3584880873, 55655, 18203, 132, 89, 200, 175, 67, 65, 81, 27)]
  [ExclusiveTo(typeof (Frame))]
  internal interface IFrameStatics
  {
    DependencyProperty CacheSizeProperty { get; }

    DependencyProperty CanGoBackProperty { get; }

    DependencyProperty CanGoForwardProperty { get; }

    DependencyProperty CurrentSourcePageTypeProperty { get; }

    DependencyProperty SourcePageTypeProperty { get; }

    DependencyProperty BackStackDepthProperty { get; }
  }
}
