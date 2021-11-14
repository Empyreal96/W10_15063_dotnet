// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextPredictionGeneratorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextPredictionGenerator))]
  [Guid(1918350358, 35746, 18257, 157, 48, 157, 133, 67, 86, 83, 162)]
  internal interface ITextPredictionGeneratorFactory
  {
    TextPredictionGenerator Create(string languageTag);
  }
}
