// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.SemanticTextQuery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ISemanticTextQueryFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SemanticTextQuery : ISemanticTextQuery
  {
    [MethodImpl]
    public extern SemanticTextQuery(string aqsFilter);

    [MethodImpl]
    public extern SemanticTextQuery(string aqsFilter, string filterLanguage);

    [MethodImpl]
    public extern IVectorView<TextSegment> Find(string content);

    [MethodImpl]
    public extern IVectorView<TextSegment> FindInProperty(
      string propertyContent,
      string propertyName);
  }
}
