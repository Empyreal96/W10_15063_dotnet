// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.JournalEntryData
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System.Windows.Navigation
{
  [DataContract]
  internal class JournalEntryData
  {
    private IDictionary<string, object> _state = (IDictionary<string, object>) new Dictionary<string, object>();

    [DataMember]
    public Uri Source { get; set; }

    [DataMember]
    public IDictionary<string, object> State
    {
      get => this._state;
      set => this._state = value;
    }
  }
}
