// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ISpanFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(1536257884, 52525, 16576, 149, 106, 56, 100, 72, 50, 47, 121)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Span))]
  internal interface ISpanFactory
  {
    Span CreateInstance(object outer, out object inner);
  }
}
