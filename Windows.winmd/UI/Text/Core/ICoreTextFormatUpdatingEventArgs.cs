// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextFormatUpdatingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreTextFormatUpdatingEventArgs))]
  [Guid(1930476851, 46248, 17329, 179, 123, 7, 36, 212, 172, 167, 171)]
  internal interface ICoreTextFormatUpdatingEventArgs
  {
    CoreTextRange Range { get; }

    IReference<UIElementType> TextColor { get; }

    IReference<UIElementType> BackgroundColor { get; }

    IReference<UIElementType> UnderlineColor { get; }

    IReference<global::Windows.UI.Text.UnderlineType> UnderlineType { get; }

    CoreTextFormatUpdatingReason Reason { get; }

    CoreTextFormatUpdatingResult Result { get; set; }

    bool IsCanceled { get; }

    Deferral GetDeferral();
  }
}
