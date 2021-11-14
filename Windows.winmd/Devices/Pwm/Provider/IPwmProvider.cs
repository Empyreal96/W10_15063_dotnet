// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Pwm.Provider.IPwmProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Pwm.Provider
{
  [Guid(2737836584, 21233, 18352, 147, 73, 102, 186, 67, 210, 89, 2)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  public interface IPwmProvider
  {
    IVectorView<IPwmControllerProvider> GetControllers();
  }
}
