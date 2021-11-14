// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MediaTransportControlsHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaTransportControlsHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaTransportControlsHelper : IMediaTransportControlsHelper
  {
    public static extern DependencyProperty DropoutOrderProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern IReference<int> GetDropoutOrder(UIElement element);

    [MethodImpl]
    public static extern void SetDropoutOrder(UIElement element, IReference<int> value);
  }
}
