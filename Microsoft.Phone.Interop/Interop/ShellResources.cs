// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Interop.ShellResources
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.Phone.Interop
{
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [CompilerGenerated]
  internal class ShellResources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal ShellResources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (ShellResources.resourceMan == null)
          ShellResources.resourceMan = new ResourceManager("Microsoft.Phone.Interop.ShellResources", typeof (ShellResources).Assembly);
        return ShellResources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => ShellResources.resourceCulture;
      set => ShellResources.resourceCulture = value;
    }

    internal static string PageStackCanceled => ShellResources.ResourceManager.GetString(nameof (PageStackCanceled), ShellResources.resourceCulture);

    internal static string NavigateWhileInBackground => ShellResources.ResourceManager.GetString(nameof (NavigateWhileInBackground), ShellResources.resourceCulture);

    internal static string InvalidArgument => ShellResources.ResourceManager.GetString(nameof (InvalidArgument), ShellResources.resourceCulture);

    internal static string GeneralError => ShellResources.ResourceManager.GetString(nameof (GeneralError), ShellResources.resourceCulture);
  }
}
