// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.SafeAvatarNativeMethods
// Assembly: Microsoft.Xna.Framework.Avatar, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8518E295-C4D7-45FF-B025-9F2E181C471E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFB9E~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal static class SafeAvatarNativeMethods
  {
    [SecuritySafeCritical]
    internal static unsafe uint AvatarDescription_CreateFromGamertag(
      string gamertag,
      out uint descriptionHandle,
      byte[] description)
    {
      if (description == null)
        throw new ArgumentNullException(nameof (description));
      GCHandle gcHandle = description.Length == 1020 ? GCHandle.Alloc((object) description, GCHandleType.Pinned) : throw new ArgumentOutOfRangeException(nameof (description));
      try
      {
        byte* pointer = (byte*) gcHandle.AddrOfPinnedObject().ToPointer();
        return UnsafeAvatarNativeMethods.AvatarDescription_CreateFromGamertag(gamertag, out descriptionHandle, pointer, (uint) description.Length);
      }
      finally
      {
        gcHandle.Free();
      }
    }

    [SecuritySafeCritical]
    internal static unsafe uint AvatarDescription_CreateFromDescription(
      byte[] description,
      out uint descriptionHandle)
    {
      if (description == null)
        throw new ArgumentNullException(nameof (description));
      GCHandle gcHandle = description.Length == 1020 ? GCHandle.Alloc((object) description, GCHandleType.Pinned) : throw new ArgumentOutOfRangeException(nameof (description));
      try
      {
        return UnsafeAvatarNativeMethods.AvatarDescription_CreateFromDescription((byte*) gcHandle.AddrOfPinnedObject().ToPointer(), (uint) description.Length, out descriptionHandle);
      }
      finally
      {
        gcHandle.Free();
      }
    }

    [SecuritySafeCritical]
    internal static unsafe uint AvatarDescription_CreateRandom(
      int bodyType,
      out uint descriptionHandle,
      byte[] description)
    {
      if (description == null)
        throw new ArgumentNullException(nameof (description));
      GCHandle gcHandle = description.Length == 1020 ? GCHandle.Alloc((object) description, GCHandleType.Pinned) : throw new ArgumentOutOfRangeException(nameof (description));
      try
      {
        byte* pointer = (byte*) gcHandle.AddrOfPinnedObject().ToPointer();
        return UnsafeAvatarNativeMethods.AvatarDescription_CreateRandom(bodyType, out descriptionHandle, pointer, (uint) description.Length);
      }
      finally
      {
        gcHandle.Free();
      }
    }

    [SecuritySafeCritical]
    internal static uint AvatarDescription_GetHeight(uint descriptionHandle, out float height) => UnsafeAvatarNativeMethods.AvatarDescription_GetHeight(descriptionHandle, out height);

    [SecuritySafeCritical]
    internal static uint AvatarDescription_GetBodyType(uint descriptionHandle, out int bodyTypeNum) => UnsafeAvatarNativeMethods.AvatarDescription_GetBodyType(descriptionHandle, out bodyTypeNum);

    [SecuritySafeCritical]
    internal static uint AvatarDescription_HasProp(uint descriptionHandle, out bool hasProp) => UnsafeAvatarNativeMethods.AvatarDescription_HasProp(descriptionHandle, out hasProp);

    [SecuritySafeCritical]
    internal static uint AvatarDescription_ValidateComponents(
      uint descriptionHandle,
      uint rendererHandle,
      out bool equal)
    {
      return UnsafeAvatarNativeMethods.AvatarDescription_ValidateComponents(descriptionHandle, rendererHandle, out equal);
    }

    [SecuritySafeCritical]
    internal static uint AvatarDescription_Save(uint descriptionHandle) => UnsafeAvatarNativeMethods.AvatarDescription_Save(descriptionHandle);

    [SecuritySafeCritical]
    internal static uint AvatarDescription_AddRef(uint descriptionHandle) => UnsafeAvatarNativeMethods.AvatarDescription_AddRef(descriptionHandle);

    [SecuritySafeCritical]
    internal static uint AvatarDescription_ReleaseHandle(uint descriptionHandle, out int released) => UnsafeAvatarNativeMethods.AvatarDescription_ReleaseHandle(descriptionHandle, out released);

    [SecuritySafeCritical]
    internal static uint AvatarAnimation_Create(
      uint animationIndex,
      out uint animationHandle,
      out float animationLength)
    {
      return UnsafeAvatarNativeMethods.AvatarAnimation_Create(animationIndex, out animationHandle, out animationLength);
    }

    [SecuritySafeCritical]
    internal static uint AvatarAnimation_CreatePropAnimation(
      uint descriptionHandle,
      out uint animationHandle,
      out float animationLength)
    {
      return UnsafeAvatarNativeMethods.AvatarAnimation_CreatePropAnimation(descriptionHandle, out animationHandle, out animationLength);
    }

    [SecuritySafeCritical]
    internal static uint AvatarAnimation_ReleaseHandle(uint animaitonHandle) => UnsafeAvatarNativeMethods.AvatarAnimation_ReleaseHandle(animaitonHandle);

    [SecuritySafeCritical]
    internal static unsafe uint AvatarAnimation_Update(
      uint animationHandle,
      float currentTime,
      Matrix[] avatarBones,
      out AvatarUnsafeNativeStructures.AVATAR_EXPRESSION expression)
    {
      if (avatarBones == null)
        throw new ArgumentNullException(nameof (avatarBones));
      GCHandle gcHandle = avatarBones.Length == 71 ? GCHandle.Alloc((object) avatarBones, GCHandleType.Pinned) : throw new ArgumentOutOfRangeException(nameof (avatarBones));
      try
      {
        void* pointer = gcHandle.AddrOfPinnedObject().ToPointer();
        return UnsafeAvatarNativeMethods.AvatarAnimation_Update(animationHandle, currentTime, pointer, (uint) avatarBones.Length, out expression);
      }
      finally
      {
        gcHandle.Free();
      }
    }

    [SecuritySafeCritical]
    internal static uint AvatarAnimation_GetBoundingBox(
      uint animaitonHandle,
      out AvatarUnsafeNativeStructures.AVATAR_BOUNDINGBOX bounds)
    {
      return UnsafeAvatarNativeMethods.AvatarAnimation_GetBoundingBox(animaitonHandle, out bounds);
    }

    [SecuritySafeCritical]
    internal static uint AvatarRenderer_Create(
      uint graphicsDeviceHandle,
      uint descriptionHandle,
      out uint handle)
    {
      return UnsafeAvatarNativeMethods.AvatarRenderer_Create(graphicsDeviceHandle, descriptionHandle, out handle);
    }

    [SecuritySafeCritical]
    internal static uint AvatarRenderer_ReleaseHandle(
      uint graphicsDeviceHandle,
      uint rendererHandle)
    {
      return UnsafeAvatarNativeMethods.AvatarRenderer_ReleaseHandle(graphicsDeviceHandle, rendererHandle);
    }

    [SecuritySafeCritical]
    internal static unsafe uint AvatarRenderer_Draw(
      uint graphicsDeviceHandle,
      uint rendererHandle,
      ref AvatarUnsafeNativeStructures.AVATAR_DRAW_PARAMS drawParams,
      Matrix[] drawBones)
    {
      if (drawBones == null)
        throw new ArgumentNullException(nameof (drawBones));
      GCHandle gcHandle = drawBones.Length == 71 ? GCHandle.Alloc((object) drawBones, GCHandleType.Pinned) : throw new ArgumentOutOfRangeException(nameof (drawBones));
      try
      {
        void* pointer = gcHandle.AddrOfPinnedObject().ToPointer();
        return UnsafeAvatarNativeMethods.AvatarRenderer_Draw(graphicsDeviceHandle, rendererHandle, ref drawParams, pointer, (uint) drawBones.Length);
      }
      finally
      {
        gcHandle.Free();
      }
    }

    [SecuritySafeCritical]
    internal static uint AvatarRenderer_DrawWithProp(
      uint graphicsDeviceHandle,
      uint rendererHandle,
      uint propAnimationHandle,
      ref AvatarUnsafeNativeStructures.AVATAR_DRAW_PARAMS drawParams)
    {
      return UnsafeAvatarNativeMethods.AvatarRenderer_DrawWithProp(graphicsDeviceHandle, rendererHandle, propAnimationHandle, ref drawParams);
    }

    [SecuritySafeCritical]
    internal static unsafe uint AvatarRenderer_GetBindPose(uint handle, Matrix[] bindPoses)
    {
      if (bindPoses == null)
        throw new ArgumentNullException(nameof (bindPoses));
      GCHandle gcHandle = bindPoses.Length == 71 ? GCHandle.Alloc((object) bindPoses, GCHandleType.Pinned) : throw new ArgumentOutOfRangeException(nameof (bindPoses));
      try
      {
        void* pointer = gcHandle.AddrOfPinnedObject().ToPointer();
        return UnsafeAvatarNativeMethods.AvatarRenderer_GetBindPose(handle, pointer, (uint) bindPoses.Length);
      }
      finally
      {
        gcHandle.Free();
      }
    }
  }
}
