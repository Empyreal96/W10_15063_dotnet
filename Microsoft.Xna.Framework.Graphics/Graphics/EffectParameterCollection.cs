// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.EffectParameterCollection
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class EffectParameterCollection : IEnumerable<EffectParameter>, IEnumerable
  {
    internal static readonly EffectParameterCollection Empty = new EffectParameterCollection((Effect) null, 0U, 0U, D3DXEffectParameterType.Parameter);
    private List<EffectParameter> _parameters;

    internal EffectParameterCollection(
      Effect parent,
      uint parentHandle,
      uint totalCount,
      D3DXEffectParameterType type)
    {
      this._parameters = new List<EffectParameter>((int) totalCount);
      for (uint index = 0; index < totalCount; ++index)
      {
        EffectParameter parameter = new EffectParameter(parent, parentHandle, index, type);
        if (parameter._handle != uint.MaxValue && parent.WantParameter(parameter))
          this._parameters.Add(parameter);
      }
    }

    public int Count => this._parameters.Count;

    public EffectParameter this[int index] => index < 0 || index >= this._parameters.Count ? (EffectParameter) null : this._parameters[index];

    public EffectParameter this[string name]
    {
      get
      {
        foreach (EffectParameter parameter in this._parameters)
        {
          if (parameter._name == name)
            return parameter;
        }
        return (EffectParameter) null;
      }
    }

    public EffectParameter GetParameterBySemantic(string semantic)
    {
      foreach (EffectParameter parameter in this._parameters)
      {
        if (string.Compare(parameter._semantic, semantic, StringComparison.OrdinalIgnoreCase) == 0)
          return parameter;
      }
      return (EffectParameter) null;
    }

    public List<EffectParameter>.Enumerator GetEnumerator() => this._parameters.GetEnumerator();

    IEnumerator<EffectParameter> IEnumerable<EffectParameter>.GetEnumerator() => (IEnumerator<EffectParameter>) this._parameters.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
  }
}
