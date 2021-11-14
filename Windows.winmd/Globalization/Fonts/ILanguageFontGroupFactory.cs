// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Fonts.ILanguageFontGroupFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Fonts
{
  [ExclusiveTo(typeof (LanguageFontGroup))]
  [Guid(4239305831, 20087, 18887, 184, 86, 221, 233, 52, 252, 115, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILanguageFontGroupFactory
  {
    LanguageFontGroup CreateLanguageFontGroup(string languageTag);
  }
}
