// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.IWordsSegmenterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (WordsSegmenter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3868684916, 64565, 17756, 139, 251, 109, 127, 70, 83, 202, 151)]
  internal interface IWordsSegmenterFactory
  {
    WordsSegmenter CreateWithLanguage(string language);
  }
}
