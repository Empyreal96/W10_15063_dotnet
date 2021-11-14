// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextReverseConversionGenerator2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (TextReverseConversionGenerator))]
  [Guid(447730412, 34262, 18173, 130, 138, 58, 72, 48, 250, 110, 24)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ITextReverseConversionGenerator2
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<TextPhoneme>> GetPhonemesAsync(
      string input);
  }
}
