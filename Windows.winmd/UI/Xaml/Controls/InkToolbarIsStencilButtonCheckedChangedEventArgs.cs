// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarIsStencilButtonCheckedChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class InkToolbarIsStencilButtonCheckedChangedEventArgs : 
    IInkToolbarIsStencilButtonCheckedChangedEventArgs
  {
    [MethodImpl]
    public extern InkToolbarIsStencilButtonCheckedChangedEventArgs();

    public extern InkToolbarStencilButton StencilButton { [MethodImpl] get; }

    public extern InkToolbarStencilKind StencilKind { [MethodImpl] get; }
  }
}
