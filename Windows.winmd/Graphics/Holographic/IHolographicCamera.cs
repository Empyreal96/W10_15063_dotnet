// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCamera
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [Guid(3840508997, 39917, 18816, 155, 160, 232, 118, 128, 209, 203, 116)]
  [ExclusiveTo(typeof (HolographicCamera))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IHolographicCamera
  {
    Size RenderTargetSize { get; }

    double ViewportScaleFactor { get; set; }

    bool IsStereo { get; }

    uint Id { get; }

    void SetNearPlaneDistance(double value);

    void SetFarPlaneDistance(double value);
  }
}
