// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Resources.ICustomXamlResourceLoaderFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Resources
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CustomXamlResourceLoader))]
  [Guid(1543339593, 30854, 17651, 142, 211, 111, 236, 4, 99, 237, 105)]
  [WebHostHidden]
  internal interface ICustomXamlResourceLoaderFactory
  {
    CustomXamlResourceLoader CreateInstance(object outer, out object inner);
  }
}
