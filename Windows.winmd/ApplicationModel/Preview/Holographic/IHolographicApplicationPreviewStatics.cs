// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Preview.Holographic.IHolographicApplicationPreviewStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Preview.Holographic
{
  [Guid(4261643921, 10810, 17833, 162, 8, 123, 237, 105, 25, 25, 243)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (HolographicApplicationPreview))]
  internal interface IHolographicApplicationPreviewStatics
  {
    bool IsCurrentViewPresentedOnHolographicDisplay();

    bool IsHolographicActivation(IActivatedEventArgs activatedEventArgs);
  }
}
