// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardPinResetDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmartCardPinResetDeferral))]
  [Guid(415845036, 30725, 16388, 133, 228, 187, 239, 172, 143, 104, 132)]
  internal interface ISmartCardPinResetDeferral
  {
    void Complete();
  }
}
