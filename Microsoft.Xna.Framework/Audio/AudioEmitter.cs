// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.AudioEmitter
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework.Audio
{
  public class AudioEmitter
  {
    internal UnsafeNativeStructures.XACT_EMITTER_DATA emitterData;

    public AudioEmitter()
    {
      this.emitterData._Position = Vector3.Zero;
      this.emitterData._Velocity = Vector3.Zero;
      this.emitterData._Forward = UnsafeNativeStructures.FlipHandedness(Vector3.Forward);
      this.emitterData._Up = UnsafeNativeStructures.FlipHandedness(Vector3.Up);
      this.emitterData._DopplerScale = 1f;
      this.emitterData.ChannelCount = 1U;
      this.emitterData.ChannelRadius = 1f;
      this.emitterData.CurveDistanceScaler = 1f;
    }

    public Vector3 Position
    {
      get => UnsafeNativeStructures.FlipHandedness(this.emitterData._Position);
      set => this.emitterData._Position = UnsafeNativeStructures.FlipHandedness(value);
    }

    public Vector3 Velocity
    {
      get => UnsafeNativeStructures.FlipHandedness(this.emitterData._Velocity);
      set => this.emitterData._Velocity = UnsafeNativeStructures.FlipHandedness(value);
    }

    public Vector3 Forward
    {
      get => UnsafeNativeStructures.FlipHandedness(this.emitterData._Forward);
      set => this.emitterData._Forward = UnsafeNativeStructures.FlipHandedness(value);
    }

    public Vector3 Up
    {
      get => UnsafeNativeStructures.FlipHandedness(this.emitterData._Up);
      set => this.emitterData._Up = UnsafeNativeStructures.FlipHandedness(value);
    }

    public float DopplerScale
    {
      get => this.emitterData._DopplerScale;
      set => this.emitterData._DopplerScale = (double) value >= 0.0 ? value : throw new ArgumentOutOfRangeException(nameof (value), FrameworkResources.InvalidEmitterDopplerScale);
    }
  }
}
