// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextFormatUpdatingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

namespace Windows.UI.Text.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreTextFormatUpdatingEventArgs : ICoreTextFormatUpdatingEventArgs
  {
    public extern CoreTextRange Range { [MethodImpl] get; }

    public extern IReference<UIElementType> TextColor { [MethodImpl] get; }

    public extern IReference<UIElementType> BackgroundColor { [MethodImpl] get; }

    public extern IReference<UIElementType> UnderlineColor { [MethodImpl] get; }

    public extern IReference<global::Windows.UI.Text.UnderlineType> UnderlineType { [MethodImpl] get; }

    public extern CoreTextFormatUpdatingReason Reason { [MethodImpl] get; }

    public extern CoreTextFormatUpdatingResult Result { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCanceled { [MethodImpl] get; }

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
