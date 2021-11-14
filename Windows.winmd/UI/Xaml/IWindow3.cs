// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IWindow3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml
{
  [Guid(3071007901, 7221, 17962, 155, 151, 128, 141, 90, 249, 242, 142)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (Window))]
  internal interface IWindow3
  {
    Compositor Compositor { get; }
  }
}
