// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlLightOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (XamlLight))]
  [WebHostHidden]
  [Guid(2086835911, 371, 18657, 183, 61, 127, 162, 22, 169, 172, 40)]
  internal interface IXamlLightOverrides
  {
    string GetId();

    void OnConnected(UIElement newElement);

    void OnDisconnected(UIElement oldElement);
  }
}
