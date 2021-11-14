// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControlsHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (MediaTransportControlsHelper))]
  [WebHostHidden]
  [Guid(1517756487, 43425, 17957, 146, 112, 127, 73, 135, 93, 67, 148)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaTransportControlsHelperStatics
  {
    DependencyProperty DropoutOrderProperty { get; }

    IReference<int> GetDropoutOrder(UIElement element);

    void SetDropoutOrder(UIElement element, IReference<int> value);
  }
}
