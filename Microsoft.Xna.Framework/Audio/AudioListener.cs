// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.AudioListener
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

namespace Microsoft.Xna.Framework.Audio
{
  public class AudioListener
  {
    internal UnsafeNativeStructures.XACT_LISTENER_DATA listenerData;

    public AudioListener()
    {
      this.listenerData._Position = Vector3.Zero;
      this.listenerData._Velocity = Vector3.Zero;
      this.listenerData._Forward = UnsafeNativeStructures.FlipHandedness(Vector3.Forward);
      this.listenerData._Up = UnsafeNativeStructures.FlipHandedness(Vector3.Up);
    }

    public Vector3 Position
    {
      get => UnsafeNativeStructures.FlipHandedness(this.listenerData._Position);
      set => this.listenerData._Position = UnsafeNativeStructures.FlipHandedness(value);
    }

    public Vector3 Velocity
    {
      get => UnsafeNativeStructures.FlipHandedness(this.listenerData._Velocity);
      set => this.listenerData._Velocity = UnsafeNativeStructures.FlipHandedness(value);
    }

    public Vector3 Forward
    {
      get => UnsafeNativeStructures.FlipHandedness(this.listenerData._Forward);
      set => this.listenerData._Forward = UnsafeNativeStructures.FlipHandedness(value);
    }

    public Vector3 Up
    {
      get => UnsafeNativeStructures.FlipHandedness(this.listenerData._Up);
      set => this.listenerData._Up = UnsafeNativeStructures.FlipHandedness(value);
    }
  }
}
