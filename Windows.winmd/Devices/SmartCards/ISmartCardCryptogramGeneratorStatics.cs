// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramGeneratorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(160643344, 52124, 16405, 150, 125, 82, 52, 243, 176, 41, 0)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  [ExclusiveTo(typeof (SmartCardCryptogramGenerator))]
  internal interface ISmartCardCryptogramGeneratorStatics
  {
    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramGenerator> GetSmartCardCryptogramGeneratorAsync();
  }
}
