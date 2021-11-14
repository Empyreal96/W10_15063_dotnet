// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.Effect
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  public class Effect : GraphicsResource
  {
    private const uint MagicNumber = 4278126849;
    private const uint EffectFlagsMagicNumber = 3169848271;
    internal EffectTechnique _currentTechnique;
    private EffectTechniqueCollection _techniques;
    private EffectParameterCollection _parameters;

    [SecuritySafeCritical]
    public unsafe Effect(GraphicsDevice graphicsDevice, byte[] effectCode)
    {
      if (effectCode == null || effectCode.Length == 0)
        throw new ArgumentNullException(nameof (effectCode), FrameworkResources.NullNotAllowed);
      if (effectCode.Length % 4 != 0)
        throw new ArgumentException(string.Format(FrameworkResources.ArrayMultipleFour, (object) nameof (effectCode)), nameof (effectCode));
      if (graphicsDevice == null)
        throw new ArgumentNullException(nameof (graphicsDevice), FrameworkResources.DeviceCannotBeNullOnResourceCreate);
      int num1 = 0;
      if (effectCode.Length < 8)
      {
        num1 = 1;
      }
      else
      {
        fixed (byte* numPtr1 = &effectCode[0])
        {
          if (*(uint*) numPtr1 != 3169848271U)
          {
            num1 = 2;
            goto label_28;
          }
          else
          {
            uint* numPtr2;
            uint num2 = *(numPtr2 = (uint*) numPtr1 + 1);
            if (effectCode.Length < (int) num2 + 4)
            {
              num1 = 3;
              goto label_28;
            }
            else
            {
              void* pEffectCode = (void*) ((IntPtr) numPtr1 + (IntPtr) num2);
              if (*(uint*) pEffectCode != 4278126849U)
              {
                num1 = 4;
                goto label_28;
              }
              else
              {
                UnsafeNativeStructures.EFFECT_DESC desc;
                this.pComPtr = UnsafeNativeMethods.Effect.GetGlobal(graphicsDevice).CreateEffect(pEffectCode, (uint) ((ulong) effectCode.Length - (ulong) num2), graphicsDevice.pComPtr, out desc);
                num1 = 5;
                if (this.pComPtr == uint.MaxValue)
                  throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
                this._parent = graphicsDevice;
                this._techniques = new EffectTechniqueCollection(this, desc.Techniques);
                this._parameters = new EffectParameterCollection(this, 0U, desc.Parameters, D3DXEffectParameterType.Parameter);
                this.CurrentTechnique = this._techniques[0];
                foreach (EffectTechnique technique in this._techniques)
                {
                  foreach (EffectPass pass in technique.Passes)
                  {
                    if (numPtr2 + 1 < pEffectCode)
                    {
                      pass._stateFlags = (EffectStateFlags) *++numPtr2;
                      pass._textureFlags = *++numPtr2;
                    }
                    else
                      goto label_28;
                  }
                }
              }
            }
          }
        }
        this._parent.FireCreatedEvent((object) this, this.pComPtr);
        return;
      }
label_28:
      throw new InvalidOperationException(string.Format("{0} - {1}", (object) FrameworkResources.ShadersMustBeCompiled, (object) num1));
    }

    protected Effect(Effect cloneSource)
    {
      if (cloneSource == null)
        throw new ArgumentNullException(nameof (cloneSource), FrameworkResources.NullNotAllowed);
      GraphicsDevice dev = !cloneSource._isDisposed ? cloneSource.GraphicsDevice : throw new ObjectDisposedException(nameof (cloneSource));
      if (dev == null)
        throw new ArgumentNullException("graphicsDevice", FrameworkResources.DeviceCannotBeNullOnResourceCreate);
      UnsafeNativeStructures.EFFECT_DESC desc;
      this.pComPtr = UnsafeNativeMethods.Effect.GetGlobal(dev).CloneEffect(dev.pComPtr, cloneSource.pComPtr, out desc);
      if (this.pComPtr == uint.MaxValue)
        throw new OutOfMemoryException(FrameworkResources.CouldNotCreateResource);
      this._parent = dev;
      this._techniques = new EffectTechniqueCollection(this, desc.Techniques);
      this._parameters = new EffectParameterCollection(this, 0U, desc.Parameters, D3DXEffectParameterType.Parameter);
      this.CurrentTechnique = this._techniques[0];
      for (int index = 0; index < this._parameters.Count; ++index)
      {
        EffectParameter parameter = this._parameters[index];
        if (parameter.ElementCount > 1 && (parameter.ParameterType == EffectParameterType.Bool || parameter.ParameterType == EffectParameterType.Int32 || parameter.ParameterType == EffectParameterType.Single))
        {
          int count = parameter.ElementCount * parameter.RowCount * parameter.ColumnCount;
          if (count > 0)
          {
            float[] valueSingleArray = cloneSource.Parameters[index].GetValueSingleArray(count);
            parameter.SetValue(valueSingleArray);
          }
        }
      }
      this._parent.FireCreatedEvent((object) this, this.pComPtr);
    }

    public EffectTechniqueCollection Techniques => this._techniques;

    public EffectParameterCollection Parameters => this._parameters;

    public EffectTechnique CurrentTechnique
    {
      get => this._currentTechnique;
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value), FrameworkResources.NullNotAllowed);
        if (value == this._currentTechnique)
          return;
        if (value._parent != this)
          throw new InvalidOperationException();
        PacketHelpers.SendEffectSetTechniquePacket(this._parent, this, value);
        this._currentTechnique = value;
      }
    }

    public virtual Effect Clone() => new Effect(this);

    internal virtual bool WantParameter(EffectParameter parameter) => true;

    protected internal virtual void OnApply()
    {
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        if (this._isDisposed || this.pComPtr == uint.MaxValue)
          return;
        UnsafeNativeMethods.Effect.GetGlobal(this._parent).ReleaseHandle(this._parent != null ? this._parent.pComPtr : 0U, this.pComPtr);
        if (this._parent == null)
          return;
        this._parent.FireDestroyedEvent(this._name, this._tag, this.pComPtr);
      }
      finally
      {
        base.Dispose(disposing);
      }
    }
  }
}
