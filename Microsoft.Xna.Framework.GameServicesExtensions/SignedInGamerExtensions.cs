// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.SignedInGamerExtensions
// Assembly: Microsoft.Xna.Framework.GamerServicesExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: F621E986-7AF4-4224-B54E-95BA3995AFC3
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI2199~1.DLL

using GamerServices.Platforms.Web;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.GamerServices
{
  public static class SignedInGamerExtensions
  {
    public static IAsyncResult BeginAwardAvatarAssets(
      this SignedInGamer gamer,
      string[] assetKeys,
      AsyncCallback callback,
      object state)
    {
      if (gamer.IsDisposed)
        throw new ObjectDisposedException(gamer.GetType().Name, FrameworkResources.ObjectDisposedException);
      if (assetKeys == null || assetKeys.Length == 0)
        throw new ArgumentNullException(nameof (assetKeys));
      if (Guide.IsTrialMode)
        throw new GamerPrivilegeException(FrameworkResources.TrialMode);
      XlastConfiguration instance = XlastConfiguration.Instance;
      int[] assetKeys1 = new int[assetKeys.Length];
      for (int index = 0; index < assetKeys.Length; ++index)
      {
        int num = 0;
        if (!instance.AvatarAssets.TryGetValue(assetKeys[index], out num))
          throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.XlastUnknown, (object) FrameworkResources.XlastAvatarAsset, (object) assetKeys[index]), nameof (assetKeys));
        assetKeys1[index] = num;
      }
      return GamerServicesDispatcher.Gsp.QueueAsyncTask((LIVEnTask) new SignedInGamerExtensions.AvatarAssetsGranter(assetKeys1), callback, state);
    }

    public static void EndAwardAvatarAssets(this SignedInGamer gamer, IAsyncResult result)
    {
      if (!(result is SignedInGamerExtensions.AvatarAssetsGranter avatarAssetsGranter))
        throw new InvalidOperationException();
      avatarAssetsGranter.EndProcess();
    }

    public static void AwardAvatarAssets(this SignedInGamer gamer, string[] assetKeys)
    {
      IAsyncResult result = gamer.BeginAwardAvatarAssets(assetKeys, (AsyncCallback) null, (object) null);
      gamer.EndAwardAvatarAssets(result);
    }

    private class AvatarAssetsGranter : LIVEnTask
    {
      private int[] assetKeys;

      public AvatarAssetsGranter(int[] assetKeys) => this.assetKeys = assetKeys;

      public override void Do() => ErrorHandler.ThrowExceptionFromResult(SignedInGamerExtensions.AvatarAssetsGranter.SafeNativeMethods.GameFoundation_AwardAvatarAssets(this.assetKeys));

      internal static class SafeNativeMethods
      {
        [SecuritySafeCritical]
        public static unsafe uint GameFoundation_AwardAvatarAssets(int[] assetKeys)
        {
          GCHandle gcHandle = GCHandle.Alloc((object) assetKeys, GCHandleType.Pinned);
          try
          {
            return SignedInGamerExtensions.AvatarAssetsGranter.UnsafeNativeMethods.GameFoundation_AwardAvatarAssets((int*) gcHandle.AddrOfPinnedObject().ToPointer(), assetKeys.Length);
          }
          finally
          {
            gcHandle.Free();
          }
        }
      }

      private static class UnsafeNativeMethods
      {
        [DllImport("XnaFrameworkCore.dll", EntryPoint = "System_GamerServices_GF_AwardAvatarAssets")]
        public static extern unsafe uint GameFoundation_AwardAvatarAssets(
          int* assetKeys,
          int numKeys);
      }
    }
  }
}
