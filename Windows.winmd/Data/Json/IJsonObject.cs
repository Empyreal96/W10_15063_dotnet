// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [ExclusiveTo(typeof (JsonObject))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(105784541, 10690, 20355, 154, 193, 158, 225, 21, 120, 190, 179)]
  internal interface IJsonObject : IJsonValue
  {
    JsonValue GetNamedValue(string name);

    void SetNamedValue(string name, IJsonValue value);

    JsonObject GetNamedObject(string name);

    JsonArray GetNamedArray(string name);

    string GetNamedString(string name);

    double GetNamedNumber(string name);

    bool GetNamedBoolean(string name);
  }
}
