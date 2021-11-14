// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IXusbGameControllerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (XusbGameControllerProvider))]
  [Guid(1848209899, 3835, 18612, 128, 139, 131, 118, 67, 178, 242, 22)]
  internal interface IXusbGameControllerProvider : IGameControllerProvider
  {
    void SetVibration(double lowFrequencyMotorSpeed, double highFrequencyMotorSpeed);
  }
}
