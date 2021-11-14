// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardEmulatorConnectionProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCardEmulatorConnectionProperties))]
  [Guid(1311548910, 63849, 20605, 108, 249, 52, 226, 209, 141, 243, 17)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  internal interface ISmartCardEmulatorConnectionProperties
  {
    Guid Id { get; }

    SmartCardEmulatorConnectionSource Source { get; }
  }
}
