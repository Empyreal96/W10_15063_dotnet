// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ModuleCommandResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Devices
{
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class ModuleCommandResult : IModuleCommandResult
  {
    public extern SendCommandStatus Status { [MethodImpl] get; }

    public extern IBuffer Result { [MethodImpl] get; }
  }
}
