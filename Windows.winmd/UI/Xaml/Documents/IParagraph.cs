// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IParagraph
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [Guid(4164875674, 64097, 19439, 174, 51, 11, 10, 215, 86, 168, 77)]
  [ExclusiveTo(typeof (Paragraph))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IParagraph
  {
    InlineCollection Inlines { get; }

    double TextIndent { get; set; }
  }
}
