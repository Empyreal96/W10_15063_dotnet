// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.ChooserInfo
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Microsoft.Phone.Tasks
{
  [DataContract]
  public class ChooserInfo
  {
    [DataMember]
    public string ChooserType { get; set; }

    [DataMember]
    public Dictionary<string, bool> Observers { get; set; }

    internal static string ChooserTypeFromChooser(IChooser chooser) => chooser.GetTypeString();

    internal static string ObserverFromDelegate(Delegate d) => d.Method.DeclaringType.FullName + d.Method.Name;
  }
}
