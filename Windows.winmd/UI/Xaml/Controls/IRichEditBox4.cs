// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1554681141, 51256, 19373, 160, 124, 32, 65, 131, 187, 117, 31)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (RichEditBox))]
  internal interface IRichEditBox4
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> GetLinguisticAlternativesAsync();

    RichEditClipboardFormat ClipboardCopyFormat { get; set; }
  }
}
