// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.JsonObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IJsonObjectStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class JsonObject : 
    IJsonObject,
    IJsonValue,
    IMap<string, IJsonValue>,
    IIterable<IKeyValuePair<string, IJsonValue>>,
    IJsonObjectWithDefaultValues,
    IStringable
  {
    [MethodImpl]
    public extern JsonObject();

    [MethodImpl]
    public extern JsonValue GetNamedValue(string name);

    [MethodImpl]
    public extern void SetNamedValue(string name, IJsonValue value);

    [MethodImpl]
    public extern JsonObject GetNamedObject(string name);

    [MethodImpl]
    public extern JsonArray GetNamedArray(string name);

    [MethodImpl]
    public extern string GetNamedString(string name);

    [MethodImpl]
    public extern double GetNamedNumber(string name);

    [MethodImpl]
    public extern bool GetNamedBoolean(string name);

    public extern JsonValueType ValueType { [MethodImpl] get; }

    [MethodImpl]
    public extern string Stringify();

    [MethodImpl]
    public extern string GetString();

    [MethodImpl]
    public extern double GetNumber();

    [MethodImpl]
    public extern bool GetBoolean();

    [MethodImpl]
    public extern JsonArray GetArray();

    [MethodImpl]
    public extern JsonObject GetObject();

    [MethodImpl]
    public extern IJsonValue Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, IJsonValue> GetView();

    [MethodImpl]
    public extern bool Insert(string key, IJsonValue value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, IJsonValue>> First();

    [Overload("GetNamedValueOrDefault")]
    [MethodImpl]
    public extern JsonValue GetNamedValue(string name, JsonValue defaultValue);

    [Overload("GetNamedObjectOrDefault")]
    [MethodImpl]
    public extern JsonObject GetNamedObject(string name, JsonObject defaultValue);

    [Overload("GetNamedStringOrDefault")]
    [MethodImpl]
    public extern string GetNamedString(string name, string defaultValue);

    [Overload("GetNamedArrayOrDefault")]
    [MethodImpl]
    public extern JsonArray GetNamedArray(string name, JsonArray defaultValue);

    [Overload("GetNamedNumberOrDefault")]
    [MethodImpl]
    public extern double GetNamedNumber(string name, double defaultValue);

    [Overload("GetNamedBooleanOrDefault")]
    [MethodImpl]
    public extern bool GetNamedBoolean(string name, bool defaultValue);

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern JsonObject Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(string input, out JsonObject result);
  }
}
