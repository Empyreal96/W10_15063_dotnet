// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.IAlternateWordForm
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Guid(1194945566, 20921, 16903, 145, 70, 36, 142, 99, 106, 29, 29)]
  [ExclusiveTo(typeof (AlternateWordForm))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAlternateWordForm
  {
    TextSegment SourceTextSegment { get; }

    string AlternateText { get; }

    AlternateNormalizationFormat NormalizationFormat { get; }
  }
}
