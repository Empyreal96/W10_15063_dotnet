// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IConnectedAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ConnectedAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(890790540, 62343, 19493, 172, 152, 68, 232, 108, 60, 173, 240)]
  [WebHostHidden]
  internal interface IConnectedAnimation
  {
    event TypedEventHandler<ConnectedAnimation, object> Completed;

    [Overload("TryStart")]
    bool TryStart(UIElement destination);

    void Cancel();
  }
}
