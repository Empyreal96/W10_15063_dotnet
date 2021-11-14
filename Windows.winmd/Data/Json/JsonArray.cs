// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.JsonArray
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IJsonArrayStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class JsonArray : 
    IJsonArray,
    IJsonValue,
    IVector<IJsonValue>,
    IIterable<IJsonValue>,
    IStringable
  {
    [MethodImpl]
    public extern JsonArray();

    [MethodImpl]
    public extern JsonObject GetObjectAt(uint index);

    [MethodImpl]
    public extern JsonArray GetArrayAt(uint index);

    [MethodImpl]
    public extern string GetStringAt(uint index);

    [MethodImpl]
    public extern double GetNumberAt(uint index);

    [MethodImpl]
    public extern bool GetBooleanAt(uint index);

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
    public extern IJsonValue GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<IJsonValue> GetView();

    [MethodImpl]
    public extern bool IndexOf(IJsonValue value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, IJsonValue value);

    [MethodImpl]
    public extern void InsertAt(uint index, IJsonValue value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(IJsonValue value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] IJsonValue[] items);

    [MethodImpl]
    public extern void ReplaceAll(IJsonValue[] items);

    [MethodImpl]
    public extern IIterator<IJsonValue> First();

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern JsonArray Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(string input, out JsonArray result);
  }
}
