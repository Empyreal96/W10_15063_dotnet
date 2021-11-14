// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ISpan
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [Guid(2553926825, 687, 18449, 170, 21, 107, 239, 58, 202, 201, 122)]
  [ExclusiveTo(typeof (Span))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpan
  {
    InlineCollection Inlines { get; set; }
  }
}
