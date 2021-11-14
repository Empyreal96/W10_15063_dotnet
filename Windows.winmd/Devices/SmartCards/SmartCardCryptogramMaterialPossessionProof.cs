// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramMaterialPossessionProof
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmartCardCryptogramMaterialPossessionProof : 
    ISmartCardCryptogramMaterialPossessionProof
  {
    public extern SmartCardCryptogramGeneratorOperationStatus OperationStatus { [MethodImpl] get; }

    public extern IBuffer Proof { [MethodImpl] get; }
  }
}
