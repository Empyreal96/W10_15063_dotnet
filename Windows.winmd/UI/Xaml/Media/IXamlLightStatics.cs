// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlLightStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(3052051817, 46344, 20124, 189, 39, 107, 4, 75, 95, 120, 160)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (XamlLight))]
  internal interface IXamlLightStatics
  {
    void AddTargetElement(string lightId, UIElement element);

    void RemoveTargetElement(string lightId, UIElement element);

    void AddTargetBrush(string lightId, Brush brush);

    void RemoveTargetBrush(string lightId, Brush brush);
  }
}
