// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.GipFirmwareUpdateResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class GipFirmwareUpdateResult : IGipFirmwareUpdateResult
  {
    public extern uint ExtendedErrorCode { [MethodImpl] get; }

    public extern uint FinalComponentId { [MethodImpl] get; }

    public extern GipFirmwareUpdateStatus Status { [MethodImpl] get; }
  }
}
