// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.BuiltInEffectReader`1
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Content
{
  internal abstract class BuiltInEffectReader<T> : ContentTypeReader<T> where T : Effect
  {
    private static Dictionary<GraphicsDevice, T> sharedEffects = new Dictionary<GraphicsDevice, T>();

    protected static T GetClonedEffect(
      ContentReader input,
      Converter<GraphicsDevice, T> createEffect)
    {
      GraphicsDevice graphicsDevice = GraphicsContentHelper.GraphicsDeviceFromContentReader(input);
      T obj;
      if (!BuiltInEffectReader<T>.sharedEffects.TryGetValue(graphicsDevice, out obj))
      {
        obj = createEffect(graphicsDevice);
        BuiltInEffectReader<T>.sharedEffects.Add(graphicsDevice, obj);
        graphicsDevice.Disposing += new EventHandler<EventArgs>(BuiltInEffectReader<T>.RemoveDevice);
      }
      return (T) obj.Clone();
    }

    private static void RemoveDevice(object sender, EventArgs e)
    {
      GraphicsDevice key = (GraphicsDevice) sender;
      BuiltInEffectReader<T>.sharedEffects[key].Dispose();
      BuiltInEffectReader<T>.sharedEffects.Remove(key);
    }

    protected static TextureType ReadTexture<TextureType>(ContentReader input) where TextureType : Texture
    {
      Texture texture = input.ReadExternalReference<Texture>();
      if (texture == null)
        return default (TextureType);
      return texture is TextureType extureType ? extureType : throw input.CreateContentLoadException(FrameworkResources.BuiltInEffectWrongTextureType, (object) texture.GetType().Name, (object) typeof (T).Name, (object) typeof (TextureType).Name);
    }
  }
}
