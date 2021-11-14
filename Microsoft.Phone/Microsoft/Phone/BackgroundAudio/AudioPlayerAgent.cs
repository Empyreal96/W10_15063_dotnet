// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAudio.AudioPlayerAgent
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;

namespace Microsoft.Phone.BackgroundAudio
{
  public class AudioPlayerAgent : BackgroundAgent
  {
    protected virtual void OnUserAction(
      BackgroundAudioPlayer player,
      AudioTrack track,
      UserAction action,
      object param)
    {
      this.Abort();
    }

    protected virtual void OnPlayStateChanged(
      BackgroundAudioPlayer player,
      AudioTrack track,
      PlayState playState)
    {
      this.NotifyComplete();
    }

    protected virtual void OnError(
      BackgroundAudioPlayer player,
      AudioTrack track,
      Exception error,
      bool isFatal)
    {
      if (isFatal)
        this.Abort();
      else
        this.NotifyComplete();
    }

    internal override void Invoke(Uri uri, ParameterPropertyBag parameters)
    {
      ParameterProperty property = parameters.GetProperty("Method");
      if (property == null || property.ValueType == ParameterPropertyValueType.ValueType_Invalid)
        throw new ArgumentException("Method property missing from parameter prop bag");
      switch (property.UInt32Value)
      {
        case 1:
          this.CallOnUserAction(parameters);
          break;
        case 2:
          this.CallOnPlayStateChanged(parameters);
          break;
        case 3:
          this.CallOnError(parameters);
          break;
        default:
          throw new ArgumentException("Unknown Method property AudioPlayerAgent");
      }
    }

    private void CallOnUserAction(ParameterPropertyBag parameters)
    {
      ParameterProperty property1 = parameters.GetProperty("Track");
      AudioTrack track = property1 != null && property1.ValueType == ParameterPropertyValueType.ValueType_UInt32 ? new AudioTrack(property1.UInt32Value) : throw new ArgumentException("Track");
      ParameterProperty property2 = parameters.GetProperty("action");
      UserAction action = property2 != null && property2.ValueType == ParameterPropertyValueType.ValueType_UInt32 ? (UserAction) property2.UInt32Value : throw new ArgumentException("action");
      ParameterProperty property3 = parameters.GetProperty("param");
      if (property3 == null || property3.ValueType != ParameterPropertyValueType.ValueType_UInt32)
        throw new ArgumentException("param");
      object obj = action != UserAction.Seek ? (object) null : (object) TimeSpan.FromMilliseconds((double) property3.UInt32Value);
      BackgroundAudioPlayer bapInstance = this.GetBapInstance();
      if (bapInstance == null)
        return;
      this.OnUserAction(bapInstance, track, action, obj);
    }

    private void CallOnPlayStateChanged(ParameterPropertyBag parameters)
    {
      ParameterProperty property1 = parameters.GetProperty("Track");
      AudioTrack track = property1 != null && property1.ValueType == ParameterPropertyValueType.ValueType_UInt32 ? new AudioTrack(property1.UInt32Value) : throw new ArgumentException("Track");
      ParameterProperty property2 = parameters.GetProperty("state");
      PlayState playState = property2 != null && property2.ValueType == ParameterPropertyValueType.ValueType_UInt32 ? (PlayState) property2.UInt32Value : throw new ArgumentException("state");
      BackgroundAudioPlayer bapInstance = this.GetBapInstance();
      if (bapInstance == null)
        return;
      this.OnPlayStateChanged(bapInstance, track, playState);
    }

    private void CallOnError(ParameterPropertyBag parameters)
    {
      ParameterProperty property1 = parameters.GetProperty("Track");
      AudioTrack track = property1 != null && property1.ValueType == ParameterPropertyValueType.ValueType_UInt32 ? new AudioTrack(property1.UInt32Value) : throw new ArgumentException("Track");
      ParameterProperty property2 = parameters.GetProperty("error");
      Exception error = property2 != null && property2.ValueType == ParameterPropertyValueType.ValueType_Int32 ? new Exception(property2.Int32Value.ToString()) : throw new ArgumentException("error");
      ParameterProperty property3 = parameters.GetProperty("isFatal");
      bool isFatal = property3 != null && property3.ValueType == ParameterPropertyValueType.ValueType_Bool ? property3.BoolValue : throw new ArgumentException("isFatal");
      BackgroundAudioPlayer bapInstance = this.GetBapInstance();
      if (bapInstance == null)
        return;
      this.OnError(bapInstance, track, error, isFatal);
    }

    private BackgroundAudioPlayer GetBapInstance()
    {
      BackgroundAudioPlayer backgroundAudioPlayer = (BackgroundAudioPlayer) null;
      try
      {
        backgroundAudioPlayer = BackgroundAudioPlayer.Instance;
      }
      catch (InvalidOperationException ex)
      {
        this.Abort();
      }
      catch (UnauthorizedAccessException ex)
      {
        this.Abort();
      }
      return backgroundAudioPlayer;
    }
  }
}
