// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardEmulatorConnectionDeactivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(562485459, 50667, 21090, 67, 223, 98, 160, 161, 181, 85, 87)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  [ExclusiveTo(typeof (SmartCardEmulatorConnectionDeactivatedEventArgs))]
  internal interface ISmartCardEmulatorConnectionDeactivatedEventArgs
  {
    SmartCardEmulatorConnectionProperties ConnectionProperties { get; }

    SmartCardEmulatorConnectionDeactivatedReason Reason { get; }
  }
}
