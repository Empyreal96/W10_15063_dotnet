// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ILanguageFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2600620716, 3111, 17656, 183, 146, 151, 147, 251, 102, 198, 62)]
  [ExclusiveTo(typeof (Language))]
  internal interface ILanguageFactory
  {
    Language CreateLanguage(string languageTag);
  }
}
