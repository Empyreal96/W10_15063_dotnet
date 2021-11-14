// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.EffectPassCollection
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class EffectPassCollection : IEnumerable<EffectPass>, IEnumerable
  {
    private List<EffectPass> _passes;

    internal EffectPassCollection(Effect parent, EffectTechnique technique, uint totalCount)
    {
      this._passes = new List<EffectPass>((int) totalCount);
      for (uint index = 0; index < totalCount; ++index)
        this._passes.Add(new EffectPass(parent, technique, index));
    }

    public int Count => this._passes.Count;

    public EffectPass this[int index] => index < 0 || index >= this._passes.Count ? (EffectPass) null : this._passes[index];

    public EffectPass this[string name]
    {
      get
      {
        foreach (EffectPass pass in this._passes)
        {
          if (pass._name == name)
            return pass;
        }
        return (EffectPass) null;
      }
    }

    public List<EffectPass>.Enumerator GetEnumerator() => this._passes.GetEnumerator();

    IEnumerator<EffectPass> IEnumerable<EffectPass>.GetEnumerator() => (IEnumerator<EffectPass>) this._passes.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
  }
}
