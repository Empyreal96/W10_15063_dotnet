﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.EffectHelpers
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

namespace Microsoft.Xna.Framework.Graphics
{
  internal static class EffectHelpers
  {
    internal static Vector3 EnableDefaultLighting(
      DirectionalLight light0,
      DirectionalLight light1,
      DirectionalLight light2)
    {
      light0.Direction = new Vector3(-0.5265408f, -0.5735765f, -0.6275069f);
      light0.DiffuseColor = new Vector3(1f, 0.9607844f, 0.8078432f);
      light0.SpecularColor = new Vector3(1f, 0.9607844f, 0.8078432f);
      light0.Enabled = true;
      light1.Direction = new Vector3(0.7198464f, 0.3420201f, 0.6040227f);
      light1.DiffuseColor = new Vector3(0.9647059f, 0.7607844f, 0.4078432f);
      light1.SpecularColor = Vector3.Zero;
      light1.Enabled = true;
      light2.Direction = new Vector3(0.4545195f, -0.7660444f, 0.4545195f);
      light2.DiffuseColor = new Vector3(0.3231373f, 0.3607844f, 0.3937255f);
      light2.SpecularColor = new Vector3(0.3231373f, 0.3607844f, 0.3937255f);
      light2.Enabled = true;
      return new Vector3(0.05333332f, 0.09882354f, 0.1819608f);
    }

    internal static EffectDirtyFlags SetWorldViewProjAndFog(
      EffectDirtyFlags dirtyFlags,
      ref Matrix world,
      ref Matrix view,
      ref Matrix projection,
      ref Matrix worldView,
      bool fogEnabled,
      float fogStart,
      float fogEnd,
      EffectParameter worldViewProjParam,
      EffectParameter fogVectorParam)
    {
      if ((dirtyFlags & EffectDirtyFlags.WorldViewProj) != ~EffectDirtyFlags.All)
      {
        Matrix.Multiply(ref world, ref view, out worldView);
        Matrix result;
        Matrix.Multiply(ref worldView, ref projection, out result);
        worldViewProjParam.SetValue(result);
        dirtyFlags &= ~EffectDirtyFlags.WorldViewProj;
      }
      if (fogEnabled)
      {
        if ((dirtyFlags & (EffectDirtyFlags.Fog | EffectDirtyFlags.FogEnable)) != ~EffectDirtyFlags.All)
        {
          EffectHelpers.SetFogVector(ref worldView, fogStart, fogEnd, fogVectorParam);
          dirtyFlags &= ~(EffectDirtyFlags.Fog | EffectDirtyFlags.FogEnable);
        }
      }
      else if ((dirtyFlags & EffectDirtyFlags.FogEnable) != ~EffectDirtyFlags.All)
      {
        fogVectorParam.SetValue(Vector4.Zero);
        dirtyFlags &= ~EffectDirtyFlags.FogEnable;
      }
      return dirtyFlags;
    }

    private static void SetFogVector(
      ref Matrix worldView,
      float fogStart,
      float fogEnd,
      EffectParameter fogVectorParam)
    {
      if ((double) fogStart == (double) fogEnd)
      {
        fogVectorParam.SetValue(new Vector4(0.0f, 0.0f, 0.0f, 1f));
      }
      else
      {
        float num = (float) (1.0 / ((double) fogStart - (double) fogEnd));
        Vector4 vector4;
        vector4.X = worldView.M13 * num;
        vector4.Y = worldView.M23 * num;
        vector4.Z = worldView.M33 * num;
        vector4.W = (worldView.M43 + fogStart) * num;
        fogVectorParam.SetValue(vector4);
      }
    }

    internal static EffectDirtyFlags SetLightingMatrices(
      EffectDirtyFlags dirtyFlags,
      ref Matrix world,
      ref Matrix view,
      EffectParameter worldParam,
      EffectParameter worldInverseTransposeParam,
      EffectParameter eyePositionParam)
    {
      if ((dirtyFlags & EffectDirtyFlags.World) != ~EffectDirtyFlags.All)
      {
        Matrix result1;
        Matrix.Invert(ref world, out result1);
        Matrix result2;
        Matrix.Transpose(ref result1, out result2);
        worldParam.SetValue(world);
        worldInverseTransposeParam.SetValue(result2);
        dirtyFlags &= ~EffectDirtyFlags.World;
      }
      if ((dirtyFlags & EffectDirtyFlags.EyePosition) != ~EffectDirtyFlags.All)
      {
        Matrix result;
        Matrix.Invert(ref view, out result);
        eyePositionParam.SetValue(result.Translation);
        dirtyFlags &= ~EffectDirtyFlags.EyePosition;
      }
      return dirtyFlags;
    }

    internal static void SetMaterialColor(
      bool lightingEnabled,
      float alpha,
      ref Vector3 diffuseColor,
      ref Vector3 emissiveColor,
      ref Vector3 ambientLightColor,
      EffectParameter diffuseColorParam,
      EffectParameter emissiveColorParam)
    {
      if (lightingEnabled)
      {
        Vector4 vector4;
        vector4.X = diffuseColor.X * alpha;
        vector4.Y = diffuseColor.Y * alpha;
        vector4.Z = diffuseColor.Z * alpha;
        vector4.W = alpha;
        Vector3 vector3;
        vector3.X = (emissiveColor.X + ambientLightColor.X * diffuseColor.X) * alpha;
        vector3.Y = (emissiveColor.Y + ambientLightColor.Y * diffuseColor.Y) * alpha;
        vector3.Z = (emissiveColor.Z + ambientLightColor.Z * diffuseColor.Z) * alpha;
        diffuseColorParam.SetValue(vector4);
        emissiveColorParam.SetValue(vector3);
      }
      else
      {
        Vector4 vector4;
        vector4.X = (diffuseColor.X + emissiveColor.X) * alpha;
        vector4.Y = (diffuseColor.Y + emissiveColor.Y) * alpha;
        vector4.Z = (diffuseColor.Z + emissiveColor.Z) * alpha;
        vector4.W = alpha;
        diffuseColorParam.SetValue(vector4);
      }
    }
  }
}
