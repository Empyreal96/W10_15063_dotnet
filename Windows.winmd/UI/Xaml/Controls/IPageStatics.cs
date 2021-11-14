// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPageStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Page))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(929947249, 63269, 18141, 141, 128, 238, 234, 247, 218, 116, 229)]
  internal interface IPageStatics
  {
    DependencyProperty FrameProperty { get; }

    DependencyProperty TopAppBarProperty { get; }

    DependencyProperty BottomAppBarProperty { get; }
  }
}
