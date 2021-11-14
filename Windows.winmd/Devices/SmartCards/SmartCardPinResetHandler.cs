// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardPinResetHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(328031808, 62396, 19036, 180, 29, 75, 78, 246, 132, 226, 55)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void SmartCardPinResetHandler(
    SmartCardProvisioning sender,
    SmartCardPinResetRequest request);
}
