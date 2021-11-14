// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ISelectableWordsSegmenterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Guid(2356835912, 24663, 17209, 188, 112, 242, 16, 1, 10, 65, 80)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SelectableWordsSegmenter))]
  internal interface ISelectableWordsSegmenterFactory
  {
    SelectableWordsSegmenter CreateWithLanguage(string language);
  }
}
