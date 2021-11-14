// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCard
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmartCard : ISmartCard, ISmartCardConnect
  {
    public extern SmartCardReader Reader { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardStatus> GetStatusAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> GetAnswerToResetAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardConnection> ConnectAsync();
  }
}
