// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.UnsafeAvatarNativeMethods
// Assembly: Microsoft.Xna.Framework.Avatar, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8518E295-C4D7-45FF-B025-9F2E181C471E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFB9E~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal static class UnsafeAvatarNativeMethods
  {
    [DllImport("XnaFrameworkCore.dll", CharSet = CharSet.Unicode)]
    internal static extern unsafe uint AvatarDescription_CreateFromGamertag(
      [MarshalAs(UnmanagedType.LPWStr)] string gamertag,
      out uint descriptionHandle,
      byte* pOutDescription,
      uint sizeInBytes);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern unsafe uint AvatarDescription_CreateFromDescription(
      byte* pDescription,
      uint sizeInBytes,
      out uint descriptionHandle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern unsafe uint AvatarDescription_CreateRandom(
      int bodyType,
      out uint descriptionHandle,
      byte* pOutData,
      uint sizeInBytes);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarDescription_GetHeight(
      uint descriptionHandle,
      out float height);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarDescription_GetBodyType(
      uint descriptionHandle,
      out int bodyTypeNum);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarDescription_HasProp(uint descriptionHandle, out bool hasProp);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarDescription_ValidateComponents(
      uint descriptionHandle,
      uint rendererHandle,
      out bool equal);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarDescription_Save(uint descriptionHandle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarDescription_AddRef(uint descriptionHandle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarDescription_ReleaseHandle(
      uint descriptionHandle,
      out int released);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarAnimation_Create(
      uint animationIndex,
      out uint animationHandle,
      out float animationLength);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarAnimation_CreatePropAnimation(
      uint descriptionHandle,
      out uint animationHandle,
      out float animationLength);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarAnimation_ReleaseHandle(uint animationHandle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern unsafe uint AvatarAnimation_Update(
      uint animationHandle,
      float currentTime,
      void* pOutBones,
      uint numBones,
      out AvatarUnsafeNativeStructures.AVATAR_EXPRESSION expression);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarAnimation_GetBoundingBox(
      uint animationHandle,
      out AvatarUnsafeNativeStructures.AVATAR_BOUNDINGBOX bounds);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarRenderer_Create(
      uint graphicsDeviceHandle,
      uint descriptionHandle,
      out uint handle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarRenderer_ReleaseHandle(
      uint graphicsHandle,
      uint rendererHandle);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern unsafe uint AvatarRenderer_Draw(
      uint graphicsDeviceHandle,
      uint rendererHandle,
      ref AvatarUnsafeNativeStructures.AVATAR_DRAW_PARAMS drawParams,
      void* pBones,
      uint numBones);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern uint AvatarRenderer_DrawWithProp(
      uint graphicsDeviceHandle,
      uint rendererHandle,
      uint propAnimationhandle,
      ref AvatarUnsafeNativeStructures.AVATAR_DRAW_PARAMS drawParams);

    [DllImport("XnaFrameworkCore.dll")]
    internal static extern unsafe uint AvatarRenderer_GetBindPose(
      uint handle,
      void* bindPoses,
      uint numPoses);
  }
}
