// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [Guid(1600869450, 12115, 18657, 145, 163, 247, 139, 80, 166, 52, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (JsonValue))]
  [WebHostHidden]
  internal interface IJsonValueStatics
  {
    JsonValue Parse(string input);

    bool TryParse(string input, out JsonValue result);

    JsonValue CreateBooleanValue(bool input);

    JsonValue CreateNumberValue(double input);

    JsonValue CreateStringValue(string input);
  }
}
