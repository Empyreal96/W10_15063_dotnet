// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ILanguage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(3933841234, 63426, 16997, 177, 189, 196, 222, 196, 228, 240, 128)]
  [ExclusiveTo(typeof (Language))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILanguage
  {
    string LanguageTag { get; }

    string DisplayName { get; }

    string NativeName { get; }

    string Script { get; }
  }
}
