// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardEmulatorConnectionProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmartCardEmulatorConnectionProperties : ISmartCardEmulatorConnectionProperties
  {
    public extern Guid Id { [MethodImpl] get; }

    public extern SmartCardEmulatorConnectionSource Source { [MethodImpl] get; }
  }
}
