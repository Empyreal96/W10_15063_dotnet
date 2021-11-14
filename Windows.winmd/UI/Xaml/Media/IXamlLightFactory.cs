// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlLightFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2279528296, 12373, 17336, 142, 246, 121, 141, 196, 194, 50, 154)]
  [ExclusiveTo(typeof (XamlLight))]
  [WebHostHidden]
  internal interface IXamlLightFactory
  {
    XamlLight CreateInstance(object outer, out object inner);
  }
}
