// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.LayoutInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ILayoutInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class LayoutInformation : ILayoutInformation
  {
    [MethodImpl]
    public static extern UIElement GetLayoutExceptionElement(object dispatcher);

    [MethodImpl]
    public static extern Rect GetLayoutSlot(FrameworkElement element);
  }
}
