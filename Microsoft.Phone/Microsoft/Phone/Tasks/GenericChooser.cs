// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.GenericChooser
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.IO;

namespace Microsoft.Phone.Tasks
{
  internal sealed class GenericChooser : IChooser
  {
    public GenericChooser.GenericOnInvokeReturned OnInvokeReturnedHandler;
    public GenericChooser.GenericSerialize SerializeHandler;
    public GenericChooser.GenericDeserialize DeserializeHandler;
    public GenericChooser.GenericGetCorrelationBlob GetCorrelationBlobHandler;
    public GenericChooser.GenericGetTypeString GetTypeStringHandler;

    public void OnInvokeReturned(byte[] outputBuffer, Delegate d)
    {
      if (this.OnInvokeReturnedHandler == null)
        return;
      this.OnInvokeReturnedHandler(outputBuffer, d);
    }

    public void Serialize(Stream s)
    {
      if (this.SerializeHandler == null)
        return;
      this.SerializeHandler(s);
    }

    public void Deserialize(Stream s)
    {
      if (this.DeserializeHandler == null)
        return;
      this.DeserializeHandler(s);
    }

    public byte[] GetCorrelationBlob() => this.GetCorrelationBlobHandler != null ? this.GetCorrelationBlobHandler() : (byte[]) null;

    public string GetTypeString() => this.GetTypeStringHandler != null ? this.GetTypeStringHandler() : (string) null;

    public delegate void GenericOnInvokeReturned(byte[] outputBuffer, Delegate d);

    public delegate void GenericSerialize(Stream s);

    public delegate void GenericDeserialize(Stream s);

    public delegate byte[] GenericGetCorrelationBlob();

    public delegate string GenericGetTypeString();
  }
}
