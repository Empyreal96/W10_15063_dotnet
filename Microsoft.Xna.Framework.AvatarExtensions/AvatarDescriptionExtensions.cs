// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AvatarDescriptionExtensions
// Assembly: Microsoft.Xna.Framework.AvatarExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4B8FF3A4-9C9B-4DC4-8C5B-7EE362249DCB
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB22~1.DLL

using System;

namespace Microsoft.Xna.Framework.GamerServices
{
  public static class AvatarDescriptionExtensions
  {
    public static bool GetHasProp(this AvatarDescription description)
    {
      if (description == null)
        throw new ArgumentNullException(nameof (description));
      bool hasProp = false;
      ErrorHandler.ThrowExceptionFromResult(SafeAvatarNativeMethods.AvatarDescription_HasProp(description.kernelHandle, out hasProp));
      return hasProp;
    }

    public static bool ValidateComponents(
      this AvatarDescription description,
      AvatarRenderer renderer)
    {
      if (description == null)
        throw new ArgumentNullException(nameof (description));
      if (renderer == null)
        throw new ArgumentNullException(nameof (renderer));
      bool equal = false;
      lock (renderer.disposeLock)
        ErrorHandler.ThrowExceptionFromResult(SafeAvatarNativeMethods.AvatarDescription_ValidateComponents(description.kernelHandle, renderer.handle, out equal));
      return equal;
    }

    public static void Save(this AvatarDescription description)
    {
      if (description == null)
        throw new ArgumentNullException(nameof (description));
      ErrorHandler.ThrowExceptionFromResult(SafeAvatarNativeMethods.AvatarDescription_Save(description.kernelHandle));
    }
  }
}
