// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.FrameworkUIResources
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

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
  internal class FrameworkUIResources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal FrameworkUIResources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (FrameworkUIResources.resourceMan == null)
          FrameworkUIResources.resourceMan = new ResourceManager("Microsoft.Xna.Framework.FrameworkUIResources", typeof (FrameworkUIResources).Assembly);
        return FrameworkUIResources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => FrameworkUIResources.resourceCulture;
      set => FrameworkUIResources.resourceCulture = value;
    }

    internal static string GamerServicesOkButton => FrameworkUIResources.ResourceManager.GetString(nameof (GamerServicesOkButton), FrameworkUIResources.resourceCulture);

    internal static string GamerServicesCancelButton => FrameworkUIResources.ResourceManager.GetString(nameof (GamerServicesCancelButton), FrameworkUIResources.resourceCulture);
  }
}
