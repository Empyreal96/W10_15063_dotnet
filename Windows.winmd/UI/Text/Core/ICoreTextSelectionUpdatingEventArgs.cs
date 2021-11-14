// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextSelectionUpdatingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextSelectionUpdatingEventArgs))]
  [Guid(3561325471, 65151, 19413, 138, 38, 9, 34, 193, 179, 230, 57)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreTextSelectionUpdatingEventArgs
  {
    CoreTextRange Selection { get; }

    CoreTextSelectionUpdatingResult Result { get; set; }

    bool IsCanceled { get; }

    Deferral GetDeferral();
  }
}
