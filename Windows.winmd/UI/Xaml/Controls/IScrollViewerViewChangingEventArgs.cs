// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewerViewChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1305497471, 31249, 19246, 153, 51, 87, 125, 243, 146, 82, 182)]
  [ExclusiveTo(typeof (ScrollViewerViewChangingEventArgs))]
  internal interface IScrollViewerViewChangingEventArgs
  {
    ScrollViewerView NextView { get; }

    ScrollViewerView FinalView { get; }

    bool IsInertial { get; }
  }
}
