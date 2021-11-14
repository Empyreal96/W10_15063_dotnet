// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ILanguageStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (Language))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2990331223, 2149, 18132, 137, 184, 213, 155, 232, 153, 15, 13)]
  internal interface ILanguageStatics
  {
    bool IsWellFormed(string languageTag);

    string CurrentInputMethodLanguageTag { get; }
  }
}
