// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Common.NameValuePair
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Diagnostics;

namespace Microsoft.Phone.Data.Common
{
  internal sealed class NameValuePair
  {
    private readonly string _name;
    private readonly string _value;
    private readonly int _length;
    private NameValuePair _next;

    internal NameValuePair(string name, string value, int length)
    {
      Debug.Assert(!ADP.IsEmpty(name), "empty keyname");
      this._name = name;
      this._value = value;
      this._length = length;
    }

    internal int Length
    {
      get
      {
        Debug.Assert(0 < this._length, "NameValuePair zero Length usage");
        return this._length;
      }
    }

    internal string Name => this._name;

    internal NameValuePair Next
    {
      get => this._next;
      set => this._next = this._next == null && value != null ? value : throw ADP.InternalError(ADP.InternalErrorCode.NameValuePairNext);
    }

    internal string Value => this._value;
  }
}
