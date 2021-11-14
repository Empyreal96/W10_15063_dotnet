// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ScrollViewer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(869345709, 36222, 17056, 191, 50, 144, 92, 204, 208, 77, 65)]
  internal interface IScrollViewerStatics2
  {
    DependencyProperty TopLeftHeaderProperty { get; }

    DependencyProperty LeftHeaderProperty { get; }

    DependencyProperty TopHeaderProperty { get; }
  }
}
