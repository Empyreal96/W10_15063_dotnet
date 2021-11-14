// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAudio.AudioStreamingAgent
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;

namespace Microsoft.Phone.BackgroundAudio
{
  public class AudioStreamingAgent : BackgroundAgent
  {
    protected virtual void OnBeginStreaming(AudioTrack track, AudioStreamer streamer) => this.Abort();

    internal override void Invoke(Uri uri, ParameterPropertyBag parameters)
    {
      ParameterProperty property = parameters.GetProperty("Method");
      if (property == null || property.ValueType == ParameterPropertyValueType.ValueType_Invalid)
        throw new ArgumentException("Method property missing from parameter prop bag");
      if (property.UInt32Value != 4U)
        throw new ArgumentException("Unknown Method property AudioStreamingAgent");
      this.CallOnBeginStreaming(parameters);
    }

    private void CallOnBeginStreaming(ParameterPropertyBag parameters)
    {
      ParameterProperty property = parameters.GetProperty("Track");
      if (property == null || property.ValueType != ParameterPropertyValueType.ValueType_UInt32)
        throw new ArgumentException("Track");
      this.OnBeginStreaming(new AudioTrack(property.UInt32Value), AudioStreamer.Instance);
    }

    protected internal override void OnCancel() => AudioStreamer.Instance.Close();
  }
}
