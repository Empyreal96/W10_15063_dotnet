// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.IPermilleFormatterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ExclusiveTo(typeof (PermilleFormatter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(725071020, 58936, 20181, 169, 152, 98, 246, 176, 106, 73, 174)]
  internal interface IPermilleFormatterFactory
  {
    PermilleFormatter CreatePermilleFormatter(
      IIterable<string> languages,
      string geographicRegion);
  }
}
