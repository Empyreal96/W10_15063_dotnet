// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IHyperlink
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(266483259, 5353, 16722, 158, 88, 90, 234, 91, 33, 240, 141)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Hyperlink))]
  internal interface IHyperlink
  {
    Uri NavigateUri { get; set; }

    event TypedEventHandler<Hyperlink, HyperlinkClickEventArgs> Click;
  }
}
