// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.EffectTechnique
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class EffectTechnique
  {
    internal uint _handle;
    internal string _name = string.Empty;
    [SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal uint _index;
    internal Effect _parent;
    private EffectPassCollection _passes;
    private EffectAnnotationCollection _annotations;

    internal EffectTechnique(Effect parent, uint index)
    {
      StringBuilder sb = new StringBuilder(260);
      UnsafeNativeStructures.EFFECT_TECHNIQUE_DESC desc;
      this._handle = UnsafeNativeMethods.Effect.GetGlobal(parent.GraphicsDevice).GetTechnique(parent.GraphicsDevice.pComPtr, parent.pComPtr, index, out desc, sb);
      this._name = string.Intern(sb.ToString());
      this._index = index;
      this._parent = parent;
      this._passes = new EffectPassCollection(parent, this, desc.Passes);
      if (desc.Annotations <= 0U)
        return;
      this._annotations = new EffectAnnotationCollection(parent, this._handle, desc.Annotations);
    }

    public EffectPassCollection Passes => this._passes;

    public EffectAnnotationCollection Annotations => this._annotations == null ? EffectAnnotationCollection.Empty : this._annotations;

    public string Name => this._name;
  }
}
