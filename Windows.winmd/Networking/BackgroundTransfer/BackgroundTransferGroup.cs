// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundTransferGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBackgroundTransferGroupStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BackgroundTransferGroup : IBackgroundTransferGroup
  {
    public extern string Name { [MethodImpl] get; }

    public extern BackgroundTransferBehavior TransferBehavior { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern BackgroundTransferGroup CreateGroup(string name);
  }
}
