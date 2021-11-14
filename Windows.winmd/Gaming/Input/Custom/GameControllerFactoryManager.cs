// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.GameControllerFactoryManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IGameControllerFactoryManagerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGameControllerFactoryManagerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class GameControllerFactoryManager
  {
    [MethodImpl]
    public static extern IGameController TryGetFactoryControllerFromGameController(
      ICustomGameControllerFactory factory,
      IGameController gameController);

    [MethodImpl]
    public static extern void RegisterCustomFactoryForGipInterface(
      ICustomGameControllerFactory factory,
      Guid interfaceId);

    [MethodImpl]
    public static extern void RegisterCustomFactoryForHardwareId(
      ICustomGameControllerFactory factory,
      ushort hardwareVendorId,
      ushort hardwareProductId);

    [MethodImpl]
    public static extern void RegisterCustomFactoryForXusbType(
      ICustomGameControllerFactory factory,
      XusbDeviceType xusbType,
      XusbDeviceSubtype xusbSubtype);
  }
}
