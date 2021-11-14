// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.EffectAnnotation
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Microsoft.Xna.Framework.Graphics
{
  public sealed class EffectAnnotation
  {
    internal EffectParameter _parameter;
    internal string _name = string.Empty;
    internal string _semantic = string.Empty;
    private UnsafeNativeStructures.EFFECT_PARAMETER_DESC _desc;

    internal EffectAnnotation(Effect parent, uint parentHandle, uint index)
    {
      StringBuilder name = new StringBuilder(260);
      StringBuilder semantic = new StringBuilder(260);
      uint parameter = UnsafeNativeMethods.Effect.GetGlobal(parent.GraphicsDevice).GetParameter(parent.GraphicsDevice.pComPtr, UnsafeNativeStructures.D3DXPARAM_INPUT.GetStructure(parent.pComPtr, parentHandle, index, D3DXEffectParameterType.Annotation), out this._desc, name, semantic);
      if (parameter == uint.MaxValue)
        return;
      this._parameter = new EffectParameter(parent, parameter, ref this._desc);
      this._name = string.Intern(name.ToString());
      this._semantic = string.Intern(semantic.ToString());
    }

    public string Name => this._name;

    public string Semantic => this._semantic;

    public int ColumnCount => (int) this._desc.Columns;

    public int RowCount => (int) this._desc.Rows;

    public EffectParameterClass ParameterClass => this._desc.Class;

    public EffectParameterType ParameterType => this._desc.Type;

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public bool GetValueBoolean() => this._parameter.GetValueBoolean();

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public int GetValueInt32() => this._parameter.GetValueInt32();

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public float GetValueSingle() => this._parameter.GetValueSingle();

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public Vector2 GetValueVector2() => this._parameter.GetValueVector2();

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public Vector3 GetValueVector3() => this._parameter.GetValueVector3();

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public Vector4 GetValueVector4() => this._parameter.GetValueVector4();

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public Matrix GetValueMatrix() => this._parameter.GetValueMatrix();

    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public string GetValueString() => this._parameter.GetValueString();
  }
}
