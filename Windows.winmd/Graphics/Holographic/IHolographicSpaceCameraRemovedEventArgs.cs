// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicSpaceCameraRemovedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicSpaceCameraRemovedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2153006248, 62126, 12846, 141, 169, 131, 106, 10, 149, 164, 193)]
  internal interface IHolographicSpaceCameraRemovedEventArgs
  {
    HolographicCamera Camera { get; }
  }
}
