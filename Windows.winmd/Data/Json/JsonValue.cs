// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.JsonValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IJsonValueStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IJsonValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public sealed class JsonValue : IJsonValue, IStringable
  {
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
    public new extern string ToString();

    [MethodImpl]
    public static extern JsonValue CreateNullValue();

    [MethodImpl]
    public static extern JsonValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(string input, out JsonValue result);

    [MethodImpl]
    public static extern JsonValue CreateBooleanValue(bool input);

    [MethodImpl]
    public static extern JsonValue CreateNumberValue(double input);

    [MethodImpl]
    public static extern JsonValue CreateStringValue(string input);
  }
}
