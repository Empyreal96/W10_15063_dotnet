// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.SoundEffectInstance
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Security;

namespace Microsoft.Xna.Framework.Audio
{
  public class SoundEffectInstance : IDisposable
  {
    private SoundEffect effect;
    private bool disposed;
    private bool looped;
    private float currentVolume = 1f;
    private float currentPitch;
    private float currentPan;
    private bool is3d;
    private bool isFireAndForget;
    internal bool isPacketSubmitted;
    private uint voiceHandle = uint.MaxValue;
    private object voiceHandleLock = new object();

    internal uint VoiceHandle
    {
      get => this.voiceHandle;
      set => this.voiceHandle = value;
    }

    internal object VoiceHandleLock => this.voiceHandleLock;

    internal SoundEffectInstance(SoundEffect parentEffect, bool fireAndForget)
    {
      this.effect = !parentEffect.IsDisposed ? parentEffect : throw new ObjectDisposedException(typeof (SoundEffect).Name, FrameworkResources.ObjectDisposedException);
      this.AllocateVoice();
      this.Volume = 1f;
      this.Pitch = 0.0f;
      this.Pan = 0.0f;
      this.looped = false;
      this.is3d = false;
      this.isFireAndForget = fireAndForget;
    }

    internal SoundEffectInstance()
    {
    }

    ~SoundEffectInstance() => this.Dispose(false);

    internal bool IsFireAndForget => this.isFireAndForget;

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void Dispose(bool disposing)
    {
      lock (this.voiceHandleLock)
      {
        if (this.IsDisposed)
          return;
        this.disposed = true;
        if (this.effect != null)
          this.effect.ChildDestroyed(this);
        this.DeallocateVoice();
      }
    }

    [SecuritySafeCritical]
    internal virtual unsafe void AllocateVoice()
    {
      lock (this.voiceHandleLock)
      {
        if (this.voiceHandle != uint.MaxValue)
          throw new InvalidOperationException();
        uint num;
        Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.CreateSoundEffectInstance(this.effect.Handle, &num));
        this.voiceHandle = num;
        this.isPacketSubmitted = false;
      }
    }

    [SecuritySafeCritical]
    internal void DeallocateVoice()
    {
      lock (this.voiceHandleLock)
      {
        if (this.voiceHandle != uint.MaxValue)
        {
          int num = (int) SoundEffectUnsafeNativeMethods.DestroySoundEffectInstance(this.voiceHandle);
        }
        this.voiceHandle = uint.MaxValue;
        this.isPacketSubmitted = false;
      }
    }

    public bool IsDisposed => this.disposed;

    [SecuritySafeCritical]
    public virtual void Play()
    {
      lock (this.voiceHandleLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (!this.isPacketSubmitted)
        {
          Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.SubmitPacket(this.voiceHandle, this.effect.Loop.Start, this.effect.Loop.Length, this.looped ? -1 : 0));
          this.isPacketSubmitted = true;
        }
        Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.Play(this.voiceHandle));
      }
    }

    public void Stop() => this.Stop(true);

    [SecuritySafeCritical]
    public void Stop(bool immediate)
    {
      lock (this.voiceHandleLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.Stop(this.voiceHandle, immediate));
      }
    }

    [SecuritySafeCritical]
    public void Pause()
    {
      lock (this.voiceHandleLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.Pause(this.voiceHandle));
      }
    }

    [SecuritySafeCritical]
    public void Resume()
    {
      lock (this.voiceHandleLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (!this.isPacketSubmitted)
        {
          this.Play();
        }
        else
        {
          if (this.State != SoundState.Paused && this.State != SoundState.Stopped)
            return;
          Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.Play(this.voiceHandle));
        }
      }
    }

    public void Apply3D(AudioListener listener, AudioEmitter emitter) => this.SafeApply3D(new AudioListener[1]
    {
      listener
    }, emitter);

    public void Apply3D(AudioListener[] listeners, AudioEmitter emitter) => this.SafeApply3D(listeners, emitter);

    [SecuritySafeCritical]
    private void SafeApply3D(AudioListener[] listeners, AudioEmitter emitter) => this.UnsafeApply3D(listeners, emitter);

    [SecurityCritical]
    private void UnsafeApply3D(AudioListener[] listeners, AudioEmitter emitter)
    {
      lock (this.voiceHandleLock)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (!this.isPacketSubmitted)
          this.is3d = true;
        if (!this.is3d)
          throw new InvalidOperationException(FrameworkResources.InvalidApply3DCall);
        float num1 = 0.0f;
        float num2 = 0.0f;
        float num3 = 0.0f;
        float num4 = emitter.DopplerScale * SoundEffect.DopplerScale;
        for (int index = 0; index < listeners.Length; ++index)
        {
          Vector3 vector2 = Vector3.Cross(listeners[index].Forward, listeners[index].Up);
          Vector3 vector3 = Vector3.Subtract(emitter.Position, listeners[index].Position);
          float num5 = vector3.Length();
          float num6 = 0.0f;
          float num7 = 1f;
          float num8 = 0.0f;
          if ((double) num5 > 1.40129846432482E-45)
          {
            num6 = Vector3.Dot(Vector3.Divide(vector3, num5), vector2);
            if ((double) num5 <= (double) SoundEffect.DistanceScale)
            {
              if ((double) num6 <= -1.0)
                num6 = -num5 / SoundEffect.DistanceScale;
              else if ((double) num6 >= 1.0)
                num6 = num5 / SoundEffect.DistanceScale;
            }
            if ((double) num5 > (double) SoundEffect.DistanceScale)
              num7 = SoundEffect.DistanceScale / num5;
            Vector3 vector1 = Vector3.Negate(vector3);
            float num9 = Vector3.Dot(vector1, listeners[index].Velocity) / num5;
            float num10 = Vector3.Dot(vector1, emitter.Velocity) / num5;
            if ((double) num4 != 0.0)
            {
              float num11 = num9 * num4;
              float num12 = num10 * num4;
              if ((double) num11 > (double) SoundEffect.MaxVelocityComponent)
                num11 = SoundEffect.MaxVelocityComponent;
              else if ((double) num11 < -(double) SoundEffect.MaxVelocityComponent)
                num11 = -SoundEffect.MaxVelocityComponent;
              if ((double) num12 > (double) SoundEffect.MaxVelocityComponent)
                num12 = SoundEffect.MaxVelocityComponent;
              else if ((double) num12 < -(double) SoundEffect.MaxVelocityComponent)
                num12 = -SoundEffect.MaxVelocityComponent;
              num8 = (float) (3.32192802429199 * Math.Log10(((double) SoundEffect.SpeedOfSound - (double) num11) / ((double) SoundEffect.SpeedOfSound - (double) num12)));
            }
          }
          num1 += num6;
          num2 += num7;
          num3 += num8;
        }
        if (listeners.Length != 1)
        {
          num1 /= (float) listeners.Length;
          num2 /= (float) listeners.Length;
          num3 /= (float) listeners.Length;
        }
        Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.SetPan(this.voiceHandle, MathHelper.Clamp(num1, -1f, 1f)));
        if ((double) num4 != 0.0)
          Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.SetPitch(this.voiceHandle, MathHelper.Clamp(num3 + this.Pitch, -1f, 1f)));
        Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.SetVolume(this.voiceHandle, MathHelper.Clamp(num2 * this.Volume, 0.0f, 1f)));
      }
    }

    internal SoundEffect SoundEffect
    {
      get => this.effect;
      set => this.effect = value;
    }

    public float Volume
    {
      get => this.currentVolume;
      [SecuritySafeCritical] set
      {
        lock (this.voiceHandleLock)
        {
          if (this.IsDisposed)
            throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
          if ((double) value < 0.0 || (double) value > 1.0)
            throw new ArgumentOutOfRangeException(nameof (value));
          Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.SetVolume(this.voiceHandle, value));
          this.currentVolume = value;
        }
      }
    }

    public float Pitch
    {
      get => this.currentPitch;
      [SecuritySafeCritical] set
      {
        lock (this.voiceHandleLock)
        {
          if (this.IsDisposed)
            throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
          if ((double) value < -1.0 || (double) value > 1.0)
            throw new ArgumentOutOfRangeException(nameof (value));
          Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.SetPitch(this.voiceHandle, value));
          this.currentPitch = value;
        }
      }
    }

    public float Pan
    {
      get => this.currentPan;
      [SecuritySafeCritical] set
      {
        lock (this.voiceHandleLock)
        {
          if (this.IsDisposed)
            throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
          if (!this.isPacketSubmitted)
            this.is3d = false;
          if (this.is3d)
            throw new InvalidOperationException(FrameworkResources.InvalidPanCall);
          if ((double) value < -1.0 || (double) value > 1.0)
            throw new ArgumentOutOfRangeException(nameof (value));
          Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.SetPan(this.voiceHandle, value));
          this.currentPan = value;
        }
      }
    }

    public virtual bool IsLooped
    {
      get => this.looped;
      set
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        if (this.isPacketSubmitted)
          throw new InvalidOperationException(FrameworkResources.InvalidIsLoopedCall);
        this.looped = value;
      }
    }

    public SoundState State
    {
      [SecuritySafeCritical] get
      {
        lock (this.voiceHandleLock)
        {
          if (this.IsDisposed)
            throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
          VoiceState state = VoiceState.Stopped;
          Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.GetState(this.voiceHandle, ref state));
          SoundState soundState = SoundState.Stopped;
          if ((state & VoiceState.Paused) != (VoiceState) 0)
            soundState = SoundState.Paused;
          if (state == VoiceState.Playing || state == VoiceState.Stopping)
            soundState = SoundState.Playing;
          return soundState;
        }
      }
    }
  }
}
