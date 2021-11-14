// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.ResourceLoader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [Static(typeof (IResourceLoaderStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IResourceLoaderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IResourceLoaderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ResourceLoader : IResourceLoader, IResourceLoader2
  {
    [Deprecated("ResourceLoader may be altered or unavailable for releases after Windows 8.1. Instead, use GetForCurrentView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern ResourceLoader(string name);

    [MethodImpl]
    public extern ResourceLoader();

    [MethodImpl]
    public extern string GetString(string resource);

    [MethodImpl]
    public extern string GetStringForUri(Uri uri);

    [Overload("GetForCurrentView")]
    [MethodImpl]
    public static extern ResourceLoader GetForCurrentView();

    [Overload("GetForCurrentViewWithName")]
    [MethodImpl]
    public static extern ResourceLoader GetForCurrentView(string name);

    [Overload("GetForViewIndependentUse")]
    [MethodImpl]
    public static extern ResourceLoader GetForViewIndependentUse();

    [Overload("GetForViewIndependentUseWithName")]
    [MethodImpl]
    public static extern ResourceLoader GetForViewIndependentUse(string name);

    [Deprecated("GetStringForReference may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use GetStringForUri.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern string GetStringForReference(Uri uri);
  }
}
