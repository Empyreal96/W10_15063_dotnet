﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.Provider.ProviderI2cTransferResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c.Provider
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  public struct ProviderI2cTransferResult
  {
    public ProviderI2cTransferStatus Status;
    public uint BytesTransferred;
  }
}
