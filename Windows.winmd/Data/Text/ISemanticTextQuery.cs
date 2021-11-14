// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ISemanticTextQuery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (SemanticTextQuery))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1780263761, 8114, 18697, 128, 184, 53, 115, 26, 43, 62, 127)]
  internal interface ISemanticTextQuery
  {
    IVectorView<TextSegment> Find(string content);

    IVectorView<TextSegment> FindInProperty(
      string propertyContent,
      string propertyName);
  }
}
