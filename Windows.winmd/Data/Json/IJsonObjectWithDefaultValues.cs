// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonObjectWithDefaultValues
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [WebHostHidden]
  [Guid(3647001250, 47088, 20224, 142, 68, 216, 44, 244, 21, 234, 19)]
  [ExclusiveTo(typeof (JsonObject))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IJsonObjectWithDefaultValues : IJsonObject, IJsonValue
  {
    [Overload("GetNamedValueOrDefault")]
    JsonValue GetNamedValue(string name, JsonValue defaultValue);

    [Overload("GetNamedObjectOrDefault")]
    JsonObject GetNamedObject(string name, JsonObject defaultValue);

    [Overload("GetNamedStringOrDefault")]
    string GetNamedString(string name, string defaultValue);

    [Overload("GetNamedArrayOrDefault")]
    JsonArray GetNamedArray(string name, JsonArray defaultValue);

    [Overload("GetNamedNumberOrDefault")]
    double GetNamedNumber(string name, double defaultValue);

    [Overload("GetNamedBooleanOrDefault")]
    bool GetNamedBoolean(string name, bool defaultValue);
  }
}
