// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarIsStencilButtonCheckedChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkToolbarIsStencilButtonCheckedChangedEventArgs))]
  [Guid(40820006, 54059, 20008, 160, 51, 213, 9, 118, 98, 178, 146)]
  [WebHostHidden]
  internal interface IInkToolbarIsStencilButtonCheckedChangedEventArgs
  {
    InkToolbarStencilButton StencilButton { get; }

    InkToolbarStencilKind StencilKind { get; }
  }
}
