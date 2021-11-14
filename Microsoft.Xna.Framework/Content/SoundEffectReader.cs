// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.SoundEffectReader
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using Microsoft.Xna.Framework.Audio;
using System;

namespace Microsoft.Xna.Framework.Content
{
  internal class SoundEffectReader : ContentTypeReader<SoundEffect>
  {
    protected internal override SoundEffect Read(
      ContentReader input,
      SoundEffect existingInstance)
    {
      int count1 = input.ReadInt32();
      byte[] format = input.ReadBytes(count1);
      int count2 = input.ReadInt32();
      byte[] numArray = input.ReadBytes(count2);
      int num1 = input.ReadInt32();
      int num2 = input.ReadInt32();
      int num3 = input.ReadInt32();
      byte[] data = numArray;
      int loopStart = num1;
      int loopLength = num2;
      TimeSpan duration = TimeSpan.FromMilliseconds((double) num3);
      return new SoundEffect(format, data, loopStart, loopLength, duration);
    }
  }
}
