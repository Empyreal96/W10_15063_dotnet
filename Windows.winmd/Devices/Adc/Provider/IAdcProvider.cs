// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Adc.Provider.IAdcProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Adc.Provider
{
  [Guid(680867432, 37721, 19543, 188, 136, 226, 117, 232, 22, 56, 201)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  public interface IAdcProvider
  {
    IVectorView<IAdcControllerProvider> GetControllers();
  }
}
