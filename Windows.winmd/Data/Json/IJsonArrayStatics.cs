// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonArrayStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (JsonArray))]
  [Guid(3675534505, 57700, 18847, 147, 226, 138, 143, 73, 187, 144, 186)]
  internal interface IJsonArrayStatics
  {
    JsonArray Parse(string input);

    bool TryParse(string input, out JsonArray result);
  }
}
