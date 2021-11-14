// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ICompositionTargetStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionTarget))]
  [Guid(723185725, 7890, 19289, 189, 0, 117, 148, 238, 146, 131, 43)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICompositionTargetStatics
  {
    event EventHandler<object> Rendering;

    event EventHandler<object> SurfaceContentsLost;
  }
}
