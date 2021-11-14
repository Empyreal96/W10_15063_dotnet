// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ILanguageExtensionSubtags
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2105388869, 13965, 17252, 133, 43, 222, 201, 39, 3, 123, 133)]
  [ExclusiveTo(typeof (Language))]
  internal interface ILanguageExtensionSubtags
  {
    IVectorView<string> GetExtensionSubtags(string singleton);
  }
}
