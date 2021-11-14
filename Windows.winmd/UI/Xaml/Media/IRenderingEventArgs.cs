// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRenderingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RenderingEventArgs))]
  [Guid(1542968077, 38728, 19181, 131, 128, 215, 137, 14, 183, 118, 160)]
  internal interface IRenderingEventArgs
  {
    TimeSpan RenderingTime { get; }
  }
}
