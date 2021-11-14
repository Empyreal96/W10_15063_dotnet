// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlCompositionBrushBaseOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3515951089, 14516, 20129, 143, 51, 132, 150, 41, 164, 201, 193)]
  [ExclusiveTo(typeof (XamlCompositionBrushBase))]
  internal interface IXamlCompositionBrushBaseOverrides
  {
    void OnConnected();

    void OnDisconnected();
  }
}
