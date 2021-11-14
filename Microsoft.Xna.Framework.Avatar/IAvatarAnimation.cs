// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.IAvatarAnimation
// Assembly: Microsoft.Xna.Framework.Avatar, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8518E295-C4D7-45FF-B025-9F2E181C471E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFB9E~1.DLL

using System;
using System.Collections.ObjectModel;

namespace Microsoft.Xna.Framework.GamerServices
{
  public interface IAvatarAnimation
  {
    ReadOnlyCollection<Matrix> BoneTransforms { get; }

    TimeSpan CurrentPosition { get; set; }

    TimeSpan Length { get; }

    AvatarExpression Expression { get; }

    void Update(TimeSpan elapsedAnimationTime, bool loop);
  }
}
