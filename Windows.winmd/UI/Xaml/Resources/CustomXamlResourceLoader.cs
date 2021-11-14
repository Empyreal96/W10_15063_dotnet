// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Resources.CustomXamlResourceLoader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Resources
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ICustomXamlResourceLoaderFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICustomXamlResourceLoaderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class CustomXamlResourceLoader : 
    ICustomXamlResourceLoader,
    ICustomXamlResourceLoaderOverrides
  {
    [MethodImpl]
    public extern CustomXamlResourceLoader();

    [MethodImpl]
    extern object ICustomXamlResourceLoaderOverrides.GetResource(
      string resourceId,
      string objectType,
      string propertyName,
      string propertyType);

    public static extern CustomXamlResourceLoader Current { [MethodImpl] get; [MethodImpl] set; }
  }
}
