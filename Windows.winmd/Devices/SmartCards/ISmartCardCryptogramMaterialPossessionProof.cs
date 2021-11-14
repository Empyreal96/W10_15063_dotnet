// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramMaterialPossessionProof
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  [ExclusiveTo(typeof (SmartCardCryptogramMaterialPossessionProof))]
  [Guid(3854150540, 41281, 16693, 154, 221, 176, 210, 227, 170, 31, 201)]
  internal interface ISmartCardCryptogramMaterialPossessionProof
  {
    SmartCardCryptogramGeneratorOperationStatus OperationStatus { get; }

    IBuffer Proof { get; }
  }
}
