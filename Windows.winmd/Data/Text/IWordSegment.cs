// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.IWordSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (WordSegment))]
  [Guid(3537156717, 39036, 19648, 182, 189, 212, 154, 17, 179, 143, 154)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWordSegment
  {
    string Text { get; }

    TextSegment SourceTextSegment { get; }

    IVectorView<AlternateWordForm> AlternateForms { get; }
  }
}
