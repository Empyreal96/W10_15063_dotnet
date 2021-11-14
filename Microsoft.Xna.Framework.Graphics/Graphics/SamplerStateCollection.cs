// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.SamplerStateCollection
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
  [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
  public sealed class SamplerStateCollection
  {
    private GraphicsDevice _parent;
    private SamplerState[] samplerList;
    private int samplerOffset;

    internal SamplerStateCollection(
      GraphicsDevice graphicsDevice,
      int samplerOffset,
      int maxSamplers)
    {
      this._parent = graphicsDevice;
      this.samplerOffset = samplerOffset;
      this.samplerList = new SamplerState[maxSamplers];
    }

    internal void InitializeDeviceState()
    {
      for (int index = 0; index < this.samplerList.Length; ++index)
      {
        this.samplerList[index] = (SamplerState) null;
        this[index] = SamplerState.LinearWrap;
      }
    }

    internal void ClearState(int index)
    {
      if (index < 0 || index >= this.samplerList.Length)
        return;
      this.samplerList[index] = (SamplerState) null;
    }

    public SamplerState this[int index]
    {
      get
      {
        if (index < 0 || index >= this.samplerList.Length)
          throw new ArgumentOutOfRangeException(nameof (index));
        return this.samplerList[index];
      }
      set
      {
        if (index < 0 || index >= this.samplerList.Length)
          throw new ArgumentOutOfRangeException(nameof (index));
        if (value == null)
          throw new ArgumentNullException(nameof (value), FrameworkResources.NullNotAllowed);
        if (value == this.samplerList[index])
          return;
        if (value._isDisposed)
          throw new ObjectDisposedException(typeof (SamplerState).Name);
        if (value._parent != this._parent)
          value.Bind(this._parent);
        PacketHelpers.SendSetTexturePacket(this._parent, HLCBPacketType.SetSamplerState, (GraphicsResource) value, index + this.samplerOffset);
        this.samplerList[index] = value;
      }
    }
  }
}
