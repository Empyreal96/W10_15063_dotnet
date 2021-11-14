// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramPlacementStep
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  [Activatable(131072, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  public sealed class SmartCardCryptogramPlacementStep : ISmartCardCryptogramPlacementStep
  {
    [MethodImpl]
    public extern SmartCardCryptogramPlacementStep();

    public extern SmartCardCryptogramAlgorithm Algorithm { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer SourceData { [MethodImpl] get; [MethodImpl] set; }

    public extern string CryptogramMaterialPackageName { [MethodImpl] get; [MethodImpl] set; }

    public extern string CryptogramMaterialName { [MethodImpl] get; [MethodImpl] set; }

    public extern int TemplateOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern int CryptogramOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern int CryptogramLength { [MethodImpl] get; [MethodImpl] set; }

    public extern SmartCardCryptogramPlacementOptions CryptogramPlacementOptions { [MethodImpl] get; [MethodImpl] set; }

    public extern SmartCardCryptogramPlacementStep ChainedOutputStep { [MethodImpl] get; [MethodImpl] set; }
  }
}
