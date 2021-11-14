// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.SoundEffect
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security;

namespace Microsoft.Xna.Framework.Audio
{
  public sealed class SoundEffect : IDisposable
  {
    private bool disposed;
    private string effectName = string.Empty;
    private TimeSpan duration;
    private LoopRegion loopInfo;
    private object syncObject = new object();
    private uint handle = uint.MaxValue;
    private static float speedOfSound = 343.5f;
    private static float dopplerScale = 1f;
    private static float distanceScale = 1f;
    private static float maxVelocityComponent = 343.499f;
    private static float currentVolume = 1f;
    private const float defaultVolume = 1f;
    private static Dictionary<SoundEffectInstance, bool> fireAndForgetInstances = new Dictionary<SoundEffectInstance, bool>();
    private Stack<SoundEffectInstance> instancePool = new Stack<SoundEffectInstance>();
    private List<WeakReference> children = new List<WeakReference>();
    internal static SoundEffectFinalizerHelper finalizerHelper;
    private static List<SoundEffectInstance> instancesToDispose = new List<SoundEffectInstance>();

    static SoundEffect()
    {
      SoundEffect.CreateFinalizerHelper();
      UserAsyncDispatcher.Initialize();
    }

    internal static void CreateFinalizerHelper()
    {
      if (SoundEffect.finalizerHelper != null)
        return;
      SoundEffect.finalizerHelper = new SoundEffectFinalizerHelper();
    }

    public static SoundEffect FromStream(Stream stream) => stream != null ? new SoundEffect(stream) : throw new ArgumentNullException(nameof (stream));

    private SoundEffect(Stream stream)
    {
      WavFile wavFile = WavFile.Open(stream);
      this.Create(wavFile.Format.RawBuffer, wavFile.Data, 0, wavFile.Data.Length, wavFile.LoopStart, wavFile.LoopLength, wavFile.Duration);
    }

    public SoundEffect(byte[] buffer, int sampleRate, AudioChannels channels)
    {
      if (buffer == null || buffer.Length == 0)
        throw new ArgumentException(FrameworkResources.InvalidAudioBuffer);
      this.FromBuffer(buffer, 0, buffer.Length, sampleRate, channels, 0, 0);
    }

    public SoundEffect(
      byte[] buffer,
      int offset,
      int count,
      int sampleRate,
      AudioChannels channels,
      int loopStart,
      int loopLength)
    {
      this.FromBuffer(buffer, offset, count, sampleRate, channels, loopStart, loopLength);
    }

    private void FromBuffer(
      byte[] buffer,
      int offset,
      int count,
      int sampleRate,
      AudioChannels channels,
      int loopStart,
      int loopLength)
    {
      if (sampleRate < 8000 || sampleRate > 48000)
        throw new ArgumentOutOfRangeException(nameof (sampleRate));
      AudioFormat audioFormat = channels >= AudioChannels.Mono && channels <= AudioChannels.Stereo ? AudioFormat.Create(sampleRate, channels, (short) 16) : throw new ArgumentOutOfRangeException(nameof (channels));
      if (buffer == null || buffer.Length == 0 || !audioFormat.IsAligned(buffer.Length))
        throw new ArgumentException(FrameworkResources.InvalidAudioBuffer);
      if (offset >= 0 && offset < buffer.Length)
      {
        if (audioFormat.IsAligned(offset))
        {
          int num1;
          try
          {
            num1 = checked (offset + count);
          }
          catch (OverflowException ex)
          {
            throw new ArgumentException(FrameworkResources.InvalidOffsetCountLength);
          }
          if (num1 <= buffer.Length && count > 0)
          {
            if (audioFormat.IsAligned(count))
            {
              int num2;
              try
              {
                num2 = checked (loopStart + loopLength);
              }
              catch (OverflowException ex)
              {
                throw new ArgumentException(FrameworkResources.InvalidLoopRegion);
              }
              int num3 = count / (int) audioFormat.BlockAlign;
              if (loopStart < 0 || loopLength < 0 || num2 > num3)
                throw new ArgumentException(FrameworkResources.InvalidLoopRegion);
              if (loopLength == 0)
              {
                loopStart = 0;
                loopLength = num3;
              }
              this.Create(audioFormat.RawBuffer, buffer, offset, count, loopStart, loopLength, audioFormat.DurationFromSize(count));
              return;
            }
          }
          throw new ArgumentException(FrameworkResources.InvalidOffsetCountLength);
        }
      }
      throw new ArgumentException(FrameworkResources.InvalidAudioBufferOffset);
    }

    internal SoundEffect(
      byte[] format,
      byte[] data,
      int loopStart,
      int loopLength,
      TimeSpan duration)
    {
      this.Create(format, data, 0, data.Length, loopStart, loopLength, duration);
    }

    internal void Create(
      byte[] format,
      byte[] data,
      int offset,
      int count,
      int loopStart,
      int loopLength,
      TimeSpan duration)
    {
      this.AllocateFormatAndData(format, data, offset, count);
      this.loopInfo.Start = loopStart;
      this.loopInfo.Length = loopLength;
      this.duration = duration;
      SoundEffect.MasterVolume = SoundEffect.currentVolume;
    }

    ~SoundEffect() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public bool IsDisposed => this.disposed;

    [SecuritySafeCritical]
    private void Dispose(bool disposing)
    {
      lock (this.syncObject)
      {
        if (this.IsDisposed)
          return;
        this.disposed = true;
        List<WeakReference> weakReferenceList = (List<WeakReference>) null;
        lock (this.children)
          weakReferenceList = new List<WeakReference>((IEnumerable<WeakReference>) this.children);
        lock (SoundEffect.fireAndForgetInstances)
        {
          foreach (WeakReference weakReference in weakReferenceList)
          {
            if (weakReference.Target is SoundEffectInstance target5)
            {
              if (target5.IsFireAndForget)
                SoundEffect.fireAndForgetInstances.Remove(target5);
              target5.Dispose();
            }
          }
          lock (this.instancePool)
          {
            while (this.instancePool.Count > 0)
              this.instancePool.Pop().Dispose();
          }
        }
        if (this.handle == uint.MaxValue)
          return;
        int num = (int) SoundEffectUnsafeNativeMethods.ReleaseSoundEffectHandle(this.handle);
        this.handle = uint.MaxValue;
      }
    }

    internal void ChildDestroyed(SoundEffectInstance child)
    {
      lock (this.children)
      {
        for (int index = 0; index < this.children.Count; ++index)
        {
          WeakReference child1 = this.children[index];
          SoundEffectInstance target = child1.Target as SoundEffectInstance;
          if (!child1.IsAlive || target == null || target == child)
          {
            this.children.RemoveAt(index);
            --index;
          }
        }
      }
    }

    [SecuritySafeCritical]
    private unsafe void AllocateFormatAndData(byte[] format, byte[] data, int offset, int count)
    {
      lock (this.syncObject)
      {
        fixed (byte* format1 = format)
          fixed (byte* numPtr = data)
          {
            byte* data1 = numPtr + offset;
            uint num;
            Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.CreateSoundEffectHandle(format1, (uint) format.Length, data1, (uint) count, &num));
            this.handle = num;
          }
      }
    }

    public SoundEffectInstance CreateInstance()
    {
      lock (this.syncObject)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        SoundEffectInstance soundEffectInstance = new SoundEffectInstance(this, false);
        lock (this.children)
          this.children.Add(new WeakReference((object) soundEffectInstance));
        return soundEffectInstance;
      }
    }

    public bool Play() => this.Play(1f, 0.0f, 0.0f);

    public bool Play(float volume, float pitch, float pan)
    {
      if (!FrameworkDispatcher.UpdateCalledAtLeastOnce)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.CallFrameworkDispatcherUpdate));
      lock (this.syncObject)
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        SoundEffectInstance soundEffectInstance = (SoundEffectInstance) null;
        try
        {
          soundEffectInstance = this.GetFromInstancePool();
          if (soundEffectInstance != null)
          {
            soundEffectInstance.SoundEffect = this;
            soundEffectInstance.AllocateVoice();
          }
          else
            soundEffectInstance = new SoundEffectInstance(this, true);
          lock (this.children)
            this.children.Add(new WeakReference((object) soundEffectInstance));
          soundEffectInstance.Volume = volume;
          soundEffectInstance.Pitch = pitch;
          soundEffectInstance.Pan = pan;
          soundEffectInstance.Play();
          lock (SoundEffect.fireAndForgetInstances)
            SoundEffect.fireAndForgetInstances.Add(soundEffectInstance, true);
          return true;
        }
        catch (InstancePlayLimitException ex)
        {
          if (soundEffectInstance != null)
            this.AddToInstancePool(soundEffectInstance);
          return false;
        }
      }
    }

    public static int GetSampleSizeInBytes(
      TimeSpan duration,
      int sampleRate,
      AudioChannels channels)
    {
      if (duration.TotalMilliseconds < 0.0 || duration.TotalMilliseconds > (double) int.MaxValue)
        throw new ArgumentOutOfRangeException(nameof (duration));
      if (sampleRate < 8000 || sampleRate > 48000)
        throw new ArgumentOutOfRangeException(nameof (sampleRate));
      if (channels < AudioChannels.Mono || channels > AudioChannels.Stereo)
        throw new ArgumentOutOfRangeException(nameof (channels));
      if (duration == TimeSpan.Zero)
        return 0;
      try
      {
        return AudioHelper.GetSampleSizeInBytes(duration, sampleRate, channels);
      }
      catch (OverflowException ex)
      {
        throw new ArgumentOutOfRangeException(nameof (duration));
      }
    }

    public static TimeSpan GetSampleDuration(
      int sizeInBytes,
      int sampleRate,
      AudioChannels channels)
    {
      if (sizeInBytes < 0)
        throw new ArgumentException(FrameworkResources.InvalidBufferSize, nameof (sizeInBytes));
      if (sampleRate < 8000 || sampleRate > 48000)
        throw new ArgumentOutOfRangeException(nameof (sampleRate));
      if (channels < AudioChannels.Mono || channels > AudioChannels.Stereo)
        throw new ArgumentOutOfRangeException(nameof (channels));
      return sizeInBytes == 0 ? TimeSpan.Zero : AudioHelper.GetSampleDuration(sizeInBytes, sampleRate, channels);
    }

    internal static void RecycleStoppedFireAndForgetInstances()
    {
      lock (SoundEffect.fireAndForgetInstances)
      {
        foreach (SoundEffectInstance key in SoundEffect.fireAndForgetInstances.Keys)
        {
          if (SoundEffect.IsStoppedInstance(key))
            SoundEffect.instancesToDispose.Add(key);
        }
        foreach (SoundEffectInstance soundEffectInstance in SoundEffect.instancesToDispose)
        {
          SoundEffect.fireAndForgetInstances.Remove(soundEffectInstance);
          soundEffectInstance.SoundEffect.AddToInstancePool(soundEffectInstance);
        }
        SoundEffect.instancesToDispose.Clear();
      }
    }

    [SecuritySafeCritical]
    internal void AddToInstancePool(SoundEffectInstance instance)
    {
      if (!instance.IsFireAndForget)
        throw new InvalidOperationException();
      lock (this.instancePool)
      {
        instance.DeallocateVoice();
        instance.SoundEffect = (SoundEffect) null;
        this.instancePool.Push(instance);
      }
    }

    internal SoundEffectInstance GetFromInstancePool()
    {
      lock (this.instancePool)
        return this.instancePool.Count == 0 ? (SoundEffectInstance) null : this.instancePool.Pop();
    }

    private static bool IsStoppedInstance(SoundEffectInstance instance) => instance.State == SoundState.Stopped;

    internal LoopRegion Loop => this.loopInfo;

    public string Name
    {
      get => this.effectName;
      set
      {
        if (this.IsDisposed)
          throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
        this.effectName = !string.IsNullOrEmpty(value) ? value : throw new ArgumentNullException(nameof (value));
      }
    }

    public TimeSpan Duration => this.duration;

    public static float MasterVolume
    {
      get => SoundEffect.currentVolume;
      [SecuritySafeCritical] set
      {
        if ((double) value < 0.0 || (double) value > 1.0)
          throw new ArgumentOutOfRangeException(nameof (value));
        Helpers.ThrowExceptionFromErrorCode(SoundEffectUnsafeNativeMethods.SetMasterVolume(value));
        SoundEffect.currentVolume = value;
      }
    }

    internal uint Handle => this.handle;

    public static float SpeedOfSound
    {
      get => SoundEffect.speedOfSound;
      set
      {
        SoundEffect.speedOfSound = (double) value > 0.0 ? value : throw new ArgumentOutOfRangeException(nameof (value));
        SoundEffect.maxVelocityComponent = SoundEffect.speedOfSound - SoundEffect.speedOfSound / 1000f;
      }
    }

    public static float DopplerScale
    {
      get => SoundEffect.dopplerScale;
      set => SoundEffect.dopplerScale = (double) value >= 0.0 ? value : throw new ArgumentOutOfRangeException(nameof (value));
    }

    public static float DistanceScale
    {
      get => SoundEffect.distanceScale;
      set
      {
        if ((double) value < 0.0)
          throw new ArgumentOutOfRangeException(nameof (value));
        value = (double) value <= 1.40129846432482E-45 ? float.Epsilon : value;
        SoundEffect.distanceScale = value;
      }
    }

    internal static float MaxVelocityComponent => SoundEffect.maxVelocityComponent;
  }
}
