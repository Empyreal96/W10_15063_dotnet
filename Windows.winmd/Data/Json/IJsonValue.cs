// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [Guid(2736889547, 61619, 19917, 190, 238, 25, 212, 140, 211, 237, 30)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IJsonValue
  {
    JsonValueType ValueType { get; }

    string Stringify();

    string GetString();

    double GetNumber();

    bool GetBoolean();

    JsonArray GetArray();

    JsonObject GetObject();
  }
}
