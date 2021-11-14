// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Interop.Resources
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.Phone.Interop
{
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
        if (Microsoft.Phone.Interop.Resources.resourceMan == null)
          Microsoft.Phone.Interop.Resources.resourceMan = new ResourceManager("Microsoft.Phone.Interop.Resources", typeof (Microsoft.Phone.Interop.Resources).Assembly);
        return Microsoft.Phone.Interop.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Microsoft.Phone.Interop.Resources.resourceCulture;
      set => Microsoft.Phone.Interop.Resources.resourceCulture = value;
    }

    internal static string BusyException => Microsoft.Phone.Interop.Resources.ResourceManager.GetString(nameof (BusyException), Microsoft.Phone.Interop.Resources.resourceCulture);

    internal static string IllegalReentrancyException => Microsoft.Phone.Interop.Resources.ResourceManager.GetString(nameof (IllegalReentrancyException), Microsoft.Phone.Interop.Resources.resourceCulture);

    internal static string NativeExistsException => Microsoft.Phone.Interop.Resources.ResourceManager.GetString(nameof (NativeExistsException), Microsoft.Phone.Interop.Resources.resourceCulture);

    internal static string ThreadAccessException => Microsoft.Phone.Interop.Resources.ResourceManager.GetString(nameof (ThreadAccessException), Microsoft.Phone.Interop.Resources.resourceCulture);

    internal static UnmanagedMemoryStream tokenie_png => Microsoft.Phone.Interop.Resources.ResourceManager.GetStream("start.tile.ie.png", Microsoft.Phone.Interop.Resources.resourceCulture);

    internal static string UnknownHResultException => Microsoft.Phone.Interop.Resources.ResourceManager.GetString(nameof (UnknownHResultException), Microsoft.Phone.Interop.Resources.resourceCulture);

    internal static string UriArgumentException => Microsoft.Phone.Interop.Resources.ResourceManager.GetString(nameof (UriArgumentException), Microsoft.Phone.Interop.Resources.resourceCulture);

    internal static string WebBrowserAccessDeniedException => Microsoft.Phone.Interop.Resources.ResourceManager.GetString(nameof (WebBrowserAccessDeniedException), Microsoft.Phone.Interop.Resources.resourceCulture);

    internal static string NotSupportedBackgroundPropertyException => Microsoft.Phone.Interop.Resources.ResourceManager.GetString(nameof (NotSupportedBackgroundPropertyException), Microsoft.Phone.Interop.Resources.resourceCulture);
  }
}
