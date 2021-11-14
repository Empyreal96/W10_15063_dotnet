// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.EffectAnnotationCollection
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class EffectAnnotationCollection : IEnumerable<EffectAnnotation>, IEnumerable
  {
    internal static readonly EffectAnnotationCollection Empty = new EffectAnnotationCollection((Effect) null, 0U, 0U);
    private List<EffectAnnotation> _annotations;

    internal EffectAnnotationCollection(Effect parent, uint parentHandle, uint totalCount)
    {
      this._annotations = new List<EffectAnnotation>((int) totalCount);
      for (uint index = 0; index < totalCount; ++index)
      {
        EffectAnnotation effectAnnotation = new EffectAnnotation(parent, parentHandle, index);
        if (effectAnnotation._parameter != null)
          this._annotations.Add(effectAnnotation);
      }
    }

    public int Count => this._annotations.Count;

    public EffectAnnotation this[int index] => index < 0 || index >= this._annotations.Count ? (EffectAnnotation) null : this._annotations[index];

    public EffectAnnotation this[string name]
    {
      get
      {
        foreach (EffectAnnotation annotation in this._annotations)
        {
          if (annotation._name == name)
            return annotation;
        }
        return (EffectAnnotation) null;
      }
    }

    public List<EffectAnnotation>.Enumerator GetEnumerator() => this._annotations.GetEnumerator();

    IEnumerator<EffectAnnotation> IEnumerable<EffectAnnotation>.GetEnumerator() => (IEnumerator<EffectAnnotation>) this._annotations.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
  }
}
