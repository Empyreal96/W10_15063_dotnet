// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.EffectMaterialReader
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Content
{
  internal class EffectMaterialReader : ContentTypeReader<EffectMaterial>
  {
    protected internal override EffectMaterial Read(
      ContentReader input,
      EffectMaterial existingInstance)
    {
      EffectMaterial effectMaterial = input != null ? new EffectMaterial(input.ReadExternalReference<Effect>()) : throw new ArgumentNullException(nameof (input));
      foreach (KeyValuePair<string, object> keyValuePair in input.ReadObject<Dictionary<string, object>>())
        EffectMaterialReader.TryToSetParameter((Effect) effectMaterial, keyValuePair.Key, keyValuePair.Value);
      return effectMaterial;
    }

    private static void TryToSetParameter(Effect effect, string parameterName, object value)
    {
      EffectParameter parameter = effect.Parameters[parameterName];
      if (parameter == null)
        return;
      Type type = value.GetType();
      try
      {
        if (type == typeof (int[]))
          parameter.SetValue((int[]) value);
        else if (type == typeof (bool[]))
          parameter.SetValue((bool[]) value);
        else if (type == typeof (float[]))
          parameter.SetValue((float[]) value);
        else if (type == typeof (Vector2[]))
          parameter.SetValue((Vector2[]) value);
        else if (type == typeof (Vector3[]))
          parameter.SetValue((Vector3[]) value);
        else if (type == typeof (Vector4[]))
          parameter.SetValue((Vector4[]) value);
        else if (type == typeof (Matrix[]))
          parameter.SetValue((Matrix[]) value);
        else if (type == typeof (int))
          parameter.SetValue((int) value);
        else if (type == typeof (bool))
          parameter.SetValue((bool) value);
        else if (type == typeof (float))
          parameter.SetValue((float) value);
        else if (type == typeof (Vector2))
          parameter.SetValue((Vector2) value);
        else if (type == typeof (Vector3))
          parameter.SetValue((Vector3) value);
        else if (type == typeof (Vector4))
          parameter.SetValue((Vector4) value);
        else if (type == typeof (Matrix))
          parameter.SetValue((Matrix) value);
        else if (type == typeof (string))
        {
          parameter.SetValue((string) value);
        }
        else
        {
          if (!(value is Texture texture18))
            return;
          parameter.SetValue(texture18);
        }
      }
      catch (InvalidCastException ex)
      {
        if ((type == typeof (Vector2) || type == typeof (Vector3) || type == typeof (Vector4)) && EffectMaterialReader.IsAVectorOrASingle(parameter))
        {
          Vector4 vector4 = type != typeof (Vector2) ? (type != typeof (Vector3) ? (Vector4) value : new Vector4((Vector3) value, 1f)) : new Vector4((Vector2) value, 0.0f, 1f);
          if (parameter.ColumnCount == 1)
            parameter.SetValue(vector4.X);
          else if (parameter.ColumnCount == 2)
            parameter.SetValue(new Vector2(vector4.X, vector4.Y));
          else if (parameter.ColumnCount == 3)
            parameter.SetValue(new Vector3(vector4.X, vector4.Y, vector4.Z));
          else
            parameter.SetValue(vector4);
        }
        else
          throw;
      }
    }

    private static bool IsAVectorOrASingle(EffectParameter p) => ((p.ElementCount != 0 || p.ParameterClass != EffectParameterClass.Vector || (p.RowCount != 1 || p.ColumnCount < 2) ? 0 : (p.ColumnCount <= 4 ? 1 : 0)) | (p.ElementCount != 0 || p.ParameterClass != EffectParameterClass.Scalar || p.RowCount != 1 ? (false ? 1 : 0) : (p.ColumnCount == 1 ? 1 : 0))) != 0;
  }
}
