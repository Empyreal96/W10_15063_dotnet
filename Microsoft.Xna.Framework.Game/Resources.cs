// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Resources
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Microsoft.Xna.Framework.Resources.resourceMan == null)
          Microsoft.Xna.Framework.Resources.resourceMan = new ResourceManager("Microsoft.Xna.Framework.Game.Resources", typeof (Microsoft.Xna.Framework.Resources).Assembly);
        return Microsoft.Xna.Framework.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Microsoft.Xna.Framework.Resources.resourceCulture;
      set => Microsoft.Xna.Framework.Resources.resourceCulture = value;
    }

    internal static string BackBufferDimMustBePositive => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (BackBufferDimMustBePositive), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string CannotAddSameComponentMultipleTimes => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (CannotAddSameComponentMultipleTimes), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string CannotSetItemsIntoGameComponentCollection => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (CannotSetItemsIntoGameComponentCollection), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string DefaultTitleName => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (DefaultTitleName), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string Direct3DCreateError => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (Direct3DCreateError), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string Direct3DInvalidCreateParameters => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (Direct3DInvalidCreateParameters), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string GameCannotBeNull => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (GameCannotBeNull), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string GameNotDerivedFromValidGameType => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (GameNotDerivedFromValidGameType), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string CannotCreateGameType => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (CannotCreateGameType), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string RunNotSupported => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (RunNotSupported), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string GraphicsComponentNotAttachedToGame => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (GraphicsComponentNotAttachedToGame), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string GraphicsDeviceManagerAlreadyPresent => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (GraphicsDeviceManagerAlreadyPresent), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string InactiveSleepTimeCannotBeZero => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (InactiveSleepTimeCannotBeZero), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string InvalidScreenAdapter => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (InvalidScreenAdapter), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string InvalidScreenDeviceName => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (InvalidScreenDeviceName), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string MissingGraphicsDeviceService => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (MissingGraphicsDeviceService), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string MustCallBeginDeviceChange => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (MustCallBeginDeviceChange), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string NoAudioHardware => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (NoAudioHardware), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string NoCompatibleDevices => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (NoCompatibleDevices), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string NoCompatibleDevicesAfterRanking => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (NoCompatibleDevicesAfterRanking), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string NoGraphicsDeviceService => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (NoGraphicsDeviceService), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string NoHighResolutionTimer => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (NoHighResolutionTimer), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string NoMultipleRuns => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (NoMultipleRuns), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string NoNullUseDefaultAdapter => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (NoNullUseDefaultAdapter), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string NoSuitableGraphicsDevice => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (NoSuitableGraphicsDevice), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string NullOrEmptyScreenDeviceName => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (NullOrEmptyScreenDeviceName), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string PreviousDrawThrew => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (PreviousDrawThrew), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string PropertyCannotBeCalledBeforeInitialize => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (PropertyCannotBeCalledBeforeInitialize), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string ServiceAlreadyPresent => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (ServiceAlreadyPresent), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string ServiceMustBeAssignable => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (ServiceMustBeAssignable), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string ServiceProviderCannotBeNull => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (ServiceProviderCannotBeNull), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string ServiceTypeCannotBeNull => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (ServiceTypeCannotBeNull), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string TargetElaspedCannotBeZero => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (TargetElaspedCannotBeZero), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string TitleCannotBeNull => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (TitleCannotBeNull), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string ValidateBackBufferDimsFullScreen => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (ValidateBackBufferDimsFullScreen), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string ValidateBackBufferDimsModeFullScreen => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (ValidateBackBufferDimsModeFullScreen), Microsoft.Xna.Framework.Resources.resourceCulture);
  }
}
