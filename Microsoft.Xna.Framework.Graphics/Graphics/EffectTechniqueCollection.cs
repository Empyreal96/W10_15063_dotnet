// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.EffectTechniqueCollection
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class EffectTechniqueCollection : IEnumerable<EffectTechnique>, IEnumerable
  {
    private List<EffectTechnique> _techniques;

    internal EffectTechniqueCollection(Effect parent, uint totalCount)
    {
      this._techniques = new List<EffectTechnique>((int) totalCount);
      for (uint index = 0; index < totalCount; ++index)
        this._techniques.Add(new EffectTechnique(parent, index));
    }

    public int Count => this._techniques.Count;

    public EffectTechnique this[int index] => index < 0 || index >= this._techniques.Count ? (EffectTechnique) null : this._techniques[index];

    public EffectTechnique this[string name]
    {
      get
      {
        foreach (EffectTechnique technique in this._techniques)
        {
          if (technique._name == name)
            return technique;
        }
        return (EffectTechnique) null;
      }
    }

    public List<EffectTechnique>.Enumerator GetEnumerator() => this._techniques.GetEnumerator();

    IEnumerator<EffectTechnique> IEnumerable<EffectTechnique>.GetEnumerator() => (IEnumerator<EffectTechnique>) this._techniques.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
  }
}
