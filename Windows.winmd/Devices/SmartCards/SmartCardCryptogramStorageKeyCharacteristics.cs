// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramStorageKeyCharacteristics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(262144, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SmartCardCryptogramStorageKeyCharacteristics : 
    ISmartCardCryptogramStorageKeyCharacteristics
  {
    [MethodImpl]
    public extern SmartCardCryptogramStorageKeyCharacteristics();

    public extern string StorageKeyName { [MethodImpl] get; }

    public extern DateTime DateCreated { [MethodImpl] get; }

    public extern SmartCardCryptogramStorageKeyAlgorithm Algorithm { [MethodImpl] get; }

    public extern SmartCardCryptogramStorageKeyCapabilities Capabilities { [MethodImpl] get; }
  }
}
