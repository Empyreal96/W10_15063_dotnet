// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextReverseConversionGeneratorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Guid(1673450278, 8154, 16886, 137, 213, 35, 221, 234, 60, 114, 154)]
  [ExclusiveTo(typeof (TextReverseConversionGenerator))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITextReverseConversionGeneratorFactory
  {
    TextReverseConversionGenerator Create(string languageTag);
  }
}
