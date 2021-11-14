// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.DynamicSoundEffectInstance
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Xna.Framework.Audio
{
  public sealed class DynamicSoundEffectInstance : SoundEffectInstance
  {
    private static Dictionary<uint, WeakReference> allInstances = new Dictionary<uint, WeakReference>();
    private AudioFormat format;

    static DynamicSoundEffectInstance()
    {
      SoundEffect.CreateFinalizerHelper();
      UserAsyncDispatcher.Initialize();
    }

    public DynamicSoundEffectInstance(int sampleRate, AudioChannels channels)
    {
      if (sampleRate < 8000 || sampleRate > 48000)
        throw new ArgumentOutOfRangeException(nameof (sampleRate));
      this.format = channels >= AudioChannels.Mono && channels <= AudioChannels.Stereo ? AudioFormat.Create(sampleRate, channels, (short) 16) : throw new ArgumentOutOfRangeException(nameof (channels));
      this.AllocateVoice();
    }

    protected override void Dispose(bool disposing)
    {
      lock (this.VoiceHandleLock)
      {
        if (!this.IsDisposed)
        {
          lock (DynamicSoundEffectInstance.allInstances)
            DynamicSoundEffectInstance.allInstances.Remove(this.VoiceHandle);
        }
        base.Dispose(disposing);
      }
    }

    [SecuritySafeCritical]
    internal override unsafe void AllocateVoice()
    {
      lock (this.VoiceHandleLock)
      {
        if (this.VoiceHandle != uint.MaxValue)
          throw new InvalidOperationException();
        fixed (byte* format = this.format.RawBuffer)
        {
          uint num;
          Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.CreateDynamicSoundEffectInstance(format, (uint) this.format.RawBuffer.Length, &num));
          this.VoiceHandle = num;
        }
        lock (DynamicSoundEffectInstance.allInstances)
          DynamicSoundEffectInstance.allInstances.Add(this.VoiceHandle, new WeakReference((object) this));
      }
    }

    public void SubmitBuffer(byte[] buffer) => this.SubmitBuffer(buffer, 0, buffer.Length);

    [SecuritySafeCritical]
    public void SubmitBuffer(byte[] buffer, int offset, int count)
    {
      lock (this.VoiceHandleLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
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
            if (count <= 0 || num > buffer.Length || !this.format.IsAligned(count))
              throw new ArgumentException(FrameworkResources.InvalidOffsetCountLength);
            this.AllocateData(buffer, offset, count);
            return;
          }
        }
        throw new ArgumentException(FrameworkResources.InvalidAudioBufferOffset);
      }
    }

    public TimeSpan GetSampleDuration(int sizeInBytes)
    {
      lock (this.VoiceHandleLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (sizeInBytes < 0)
          throw new ArgumentException(FrameworkResources.InvalidBufferSize);
        return sizeInBytes == 0 ? TimeSpan.Zero : this.format.DurationFromSize(sizeInBytes);
      }
    }

    public int GetSampleSizeInBytes(TimeSpan duration)
    {
      lock (this.VoiceHandleLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
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

    [SecurityCritical]
    private unsafe void AllocateData(byte[] buffer, int offset, int count)
    {
      fixed (byte* numPtr = buffer)
      {
        if (SoundEffectUnsafeNativeMethods.SubmitBuffer(this.VoiceHandle, numPtr + offset, (uint) count) != ErrorCodes.Success)
          throw new InvalidOperationException(FrameworkResources.OverTheInstancePacketLimit);
      }
    }

    public override bool IsLooped
    {
      get
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        return false;
      }
      set
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (value)
          throw new InvalidOperationException(FrameworkResources.InvalidDynamicIsLoopedCall);
      }
    }

    [SecuritySafeCritical]
    public override void Play()
    {
      lock (this.VoiceHandleLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.Play(this.VoiceHandle));
        this.isPacketSubmitted = true;
      }
    }

    public int PendingBufferCount
    {
      get
      {
        lock (this.VoiceHandleLock)
        {
          if (this.IsDisposed)
            throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
          return this.GetPendingBufferCount();
        }
      }
    }

    [SecuritySafeCritical]
    private unsafe int GetPendingBufferCount()
    {
      lock (this.VoiceHandleLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        int num = 0;
        Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.GetPendingBufferCount(this.VoiceHandle, &num));
        return num;
      }
    }

    internal static void RaiseBufferNeededOnInstance(uint handle)
    {
      lock (DynamicSoundEffectInstance.allInstances)
      {
        if (!DynamicSoundEffectInstance.allInstances.ContainsKey(handle) || !(DynamicSoundEffectInstance.allInstances[handle].Target is DynamicSoundEffectInstance target2))
          return;
        target2.OnBufferNeeded(EventArgs.Empty);
      }
    }

    public event EventHandler<EventArgs> BufferNeeded;

    internal void OnBufferNeeded(EventArgs args)
    {
      EventHandler<EventArgs> bufferNeeded = this.BufferNeeded;
      if (bufferNeeded == null)
        return;
      bufferNeeded((object) this, args);
    }
  }
}
