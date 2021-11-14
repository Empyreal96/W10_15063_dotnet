// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicSpaceCameraAddedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (HolographicSpaceCameraAddedEventArgs))]
  [Guid(1492245045, 48051, 15503, 153, 61, 108, 128, 231, 254, 185, 159)]
  internal interface IHolographicSpaceCameraAddedEventArgs
  {
    HolographicCamera Camera { get; }

    Deferral GetDeferral();
  }
}
