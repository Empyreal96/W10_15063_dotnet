// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Resources
// Assembly: Microsoft.Xna.Framework.Interop, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: E258DF81-FBD7-4DF4-930E-981F36DBB495
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI20E9~1.DLL

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.Xna.Framework
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
          Microsoft.Xna.Framework.Resources.resourceMan = new ResourceManager("Microsoft.Xna.Framework.Interop.Resources", typeof (Microsoft.Xna.Framework.Resources).Assembly);
        return Microsoft.Xna.Framework.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Microsoft.Xna.Framework.Resources.resourceCulture;
      set => Microsoft.Xna.Framework.Resources.resourceCulture = value;
    }

    internal static string Direct3DCreateError => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (Direct3DCreateError), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string Direct3DInvalidCreateParameters => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (Direct3DInvalidCreateParameters), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string BackBufferDimMustBePositive => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (BackBufferDimMustBePositive), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string ValidateBackBufferDimsFullScreen => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (ValidateBackBufferDimsFullScreen), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string DirectRenderCannotChangeActiveRenderTargets => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (DirectRenderCannotChangeActiveRenderTargets), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string DirectRenderOnlyOneManager => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (DirectRenderOnlyOneManager), Microsoft.Xna.Framework.Resources.resourceCulture);

    internal static string UIElementNotInVisualTree => Microsoft.Xna.Framework.Resources.ResourceManager.GetString(nameof (UIElementNotInVisualTree), Microsoft.Xna.Framework.Resources.resourceCulture);
  }
}
