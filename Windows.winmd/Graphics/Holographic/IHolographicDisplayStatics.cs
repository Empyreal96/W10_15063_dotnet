// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicDisplayStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [Guid(3409398147, 59312, 18497, 131, 85, 58, 229, 181, 54, 233, 164)]
  [ExclusiveTo(typeof (HolographicDisplay))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IHolographicDisplayStatics
  {
    HolographicDisplay GetDefault();
  }
}
