// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.Microphone
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections.ObjectModel;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Audio
{
  public sealed class Microphone
  {
    private AudioFormat format;
    internal readonly uint Handle = uint.MaxValue;
    private object microphoneLock = new object();
    internal static MicrophoneCollection microphones;
    private TimeSpan captureBufferDuration = TimeSpan.Zero;
    internal readonly int Id;
    private bool isHeadset;
    public readonly string Name;

    static Microphone()
    {
      UserAsyncDispatcher.Initialize();
      Microphone.microphones = new MicrophoneCollection();
    }

    internal Microphone(uint handle)
    {
      this.Handle = handle;
      this.format = AudioFormat.Create(this.GetSampleRate(), AudioChannels.Mono, (short) 16);
      this.Name = nameof (Microphone);
      this.isHeadset = true;
      this.captureBufferDuration = this.SafeGetCaptureBufferDuration();
    }

    [SecuritySafeCritical]
    ~Microphone()
    {
      if (this.Handle == uint.MaxValue)
        return;
      int num = (int) MicrophoneUnsafeNativeMethods.DestroyMicrophone(this.Handle);
    }

    [SecuritySafeCritical]
    private unsafe int GetSampleRate()
    {
      int num;
      Helpers.ThrowExceptionFromErrorCode(MicrophoneUnsafeNativeMethods.GetSampleRate(this.Handle, &num));
      return num;
    }

    [SecuritySafeCritical]
    private string GetName()
    {
      StringBuilder sb = new StringBuilder(260);
      Helpers.ThrowExceptionFromErrorCode(MicrophoneUnsafeNativeMethods.GetName(this.Handle, sb, 260));
      return sb.ToString();
    }

    public int GetSampleSizeInBytes(TimeSpan duration)
    {
      lock (this.microphoneLock)
      {
        if (duration.TotalMilliseconds < 0.0 || duration.TotalMilliseconds > (double) int.MaxValue)
          throw new ArgumentOutOfRangeException(nameof (duration));
        if (duration == TimeSpan.Zero)
          return 0;
        try
        {
          return this.format.SizeFromDuration(duration);
        }
        catch (OverflowException ex)
        {
          throw new ArgumentOutOfRangeException(nameof (duration));
        }
      }
    }

    public TimeSpan GetSampleDuration(int sizeInBytes)
    {
      lock (this.microphoneLock)
      {
        if (sizeInBytes < 0)
          throw new ArgumentException(FrameworkResources.InvalidBufferSize);
        return sizeInBytes == 0 ? TimeSpan.Zero : this.format.DurationFromSize(sizeInBytes);
      }
    }

    [SecuritySafeCritical]
    public void Start()
    {
      lock (this.microphoneLock)
        Helpers.ThrowExceptionFromErrorCode(MicrophoneUnsafeNativeMethods.Start(this.Handle));
    }

    [SecuritySafeCritical]
    public void Stop()
    {
      lock (this.microphoneLock)
        Helpers.ThrowExceptionFromErrorCode(MicrophoneUnsafeNativeMethods.Stop(this.Handle));
    }

    public int GetData(byte[] buffer)
    {
      if (buffer == null || buffer.Length == 0 || !this.format.IsAligned(buffer.Length))
        throw new ArgumentException(FrameworkResources.InvalidAudioBuffer);
      return this.GetData(buffer, 0, buffer.Length);
    }

    [SecuritySafeCritical]
    public int GetData(byte[] buffer, int offset, int count)
    {
      lock (this.microphoneLock)
      {
        if (buffer == null || buffer.Length == 0 || !this.format.IsAligned(buffer.Length))
          throw new ArgumentException(FrameworkResources.InvalidAudioBuffer);
        if (offset >= 0 && offset < buffer.Length)
        {
          if (this.format.IsAligned(offset))
          {
            int num;
            try
            {
              num = checked (offset + count);
            }
            catch (OverflowException ex)
            {
              throw new ArgumentException(FrameworkResources.InvalidOffsetCountLength);
            }
            if (count <= 0 || num <= 0 || (num > buffer.Length || !this.format.IsAligned(count)) || this.format.DurationFromSize(count) == TimeSpan.Zero)
              throw new ArgumentException(FrameworkResources.InvalidOffsetCountLength);
            return this.State != MicrophoneState.Started ? 0 : this.UnsafeGetData(buffer, offset, count);
          }
        }
        throw new ArgumentException(FrameworkResources.InvalidAudioBufferOffset);
      }
    }

    [SecurityCritical]
    private unsafe int UnsafeGetData(byte[] buffer, int offset, int count)
    {
      int num = 0;
      int data;
      fixed (byte* numPtr = buffer)
        data = (int) MicrophoneUnsafeNativeMethods.GetData(this.Handle, numPtr + offset, count, &num);
      Helpers.ThrowExceptionFromErrorCode((ErrorCodes) data);
      return num;
    }

    public static ReadOnlyCollection<Microphone> All => Microphone.microphones.All;

    public static Microphone Default => Microphone.microphones.Default;

    public MicrophoneState State
    {
      [SecuritySafeCritical] get
      {
        lock (this.microphoneLock)
        {
          MicrophoneCaptureState state = MicrophoneCaptureState.MicStopped;
          Helpers.ThrowExceptionFromErrorCode(MicrophoneUnsafeNativeMethods.GetState(this.Handle, ref state));
          MicrophoneState microphoneState = MicrophoneState.Stopped;
          if (state == MicrophoneCaptureState.MicStarted)
            microphoneState = MicrophoneState.Started;
          return microphoneState;
        }
      }
    }

    public TimeSpan BufferDuration
    {
      get
      {
        lock (this.microphoneLock)
          return this.captureBufferDuration;
      }
      [SecuritySafeCritical] set
      {
        lock (this.microphoneLock)
        {
          if (value.TotalMilliseconds < 100.0 || value.TotalMilliseconds > 1000.0 || value.TotalMilliseconds % 10.0 != 0.0)
            throw new ArgumentOutOfRangeException(nameof (value), FrameworkResources.InvalidMicrophoneBufferDuration);
          Helpers.ThrowExceptionFromErrorCode(MicrophoneUnsafeNativeMethods.SetCaptureBufferDuration(this.Handle, (int) value.TotalMilliseconds));
          this.captureBufferDuration = value;
        }
      }
    }

    [SecuritySafeCritical]
    private unsafe TimeSpan SafeGetCaptureBufferDuration()
    {
      int num;
      Helpers.ThrowExceptionFromErrorCode(MicrophoneUnsafeNativeMethods.GetCaptureBufferDuration(this.Handle, &num));
      return TimeSpan.FromMilliseconds((double) num);
    }

    public int SampleRate
    {
      get
      {
        lock (this.microphoneLock)
          return this.format.SampleRate;
      }
    }

    public bool IsHeadset => this.isHeadset;

    public event EventHandler<EventArgs> BufferReady;

    internal void OnBufferReady(EventArgs args)
    {
      lock (this.microphoneLock)
      {
        EventHandler<EventArgs> bufferReady = this.BufferReady;
        if (bufferReady == null)
          return;
        bufferReady((object) this, args);
      }
    }

    internal static MicrophoneCollection AllMicrophones => Microphone.microphones;
  }
}
