// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IValueAndLanguage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [Guid(3113306241, 41454, 19396, 146, 165, 70, 105, 104, 227, 4, 54)]
  [ExclusiveTo(typeof (ValueAndLanguage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IValueAndLanguage
  {
    string Language { get; set; }

    object Value { [return: Variant] get; [param: Variant] set; }
  }
}
