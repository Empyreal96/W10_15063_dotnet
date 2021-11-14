// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGameControllerFactoryManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(919299811, 53409, 18822, 162, 76, 64, 177, 55, 222, 186, 158)]
  [ExclusiveTo(typeof (GameControllerFactoryManager))]
  [WebHostHidden]
  internal interface IGameControllerFactoryManagerStatics
  {
    void RegisterCustomFactoryForGipInterface(
      ICustomGameControllerFactory factory,
      Guid interfaceId);

    void RegisterCustomFactoryForHardwareId(
      ICustomGameControllerFactory factory,
      ushort hardwareVendorId,
      ushort hardwareProductId);

    void RegisterCustomFactoryForXusbType(
      ICustomGameControllerFactory factory,
      XusbDeviceType xusbType,
      XusbDeviceSubtype xusbSubtype);
  }
}
