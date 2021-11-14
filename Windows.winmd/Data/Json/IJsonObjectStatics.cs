// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonObjectStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (JsonObject))]
  [Guid(579465561, 21726, 17880, 171, 204, 34, 96, 63, 160, 102, 160)]
  internal interface IJsonObjectStatics
  {
    JsonObject Parse(string input);

    bool TryParse(string input, out JsonObject result);
  }
}
