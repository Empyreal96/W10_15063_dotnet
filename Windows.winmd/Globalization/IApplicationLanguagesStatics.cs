// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.IApplicationLanguagesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(1974732871, 2636, 19090, 149, 101, 253, 99, 201, 95, 122, 237)]
  [ExclusiveTo(typeof (ApplicationLanguages))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IApplicationLanguagesStatics
  {
    string PrimaryLanguageOverride { get; set; }

    IVectorView<string> Languages { get; }

    IVectorView<string> ManifestLanguages { get; }
  }
}
