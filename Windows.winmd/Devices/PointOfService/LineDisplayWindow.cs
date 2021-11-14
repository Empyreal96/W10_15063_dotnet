// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayWindow
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class LineDisplayWindow : ILineDisplayWindow, IClosable
  {
    public extern Size SizeInCharacters { [MethodImpl] get; }

    public extern TimeSpan InterCharacterWaitInterval { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRefreshAsync();

    [RemoteAsync]
    [Overload("TryDisplayTextAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayTextAsync(
      string text,
      LineDisplayTextAttribute displayAttribute);

    [RemoteAsync]
    [Overload("TryDisplayTextAtPositionAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayTextAsync(
      string text,
      LineDisplayTextAttribute displayAttribute,
      Point startPosition);

    [RemoteAsync]
    [Overload("TryDisplayTextNormalAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisplayTextAsync(string text);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryScrollTextAsync(
      LineDisplayScrollDirection direction,
      uint numberOfColumnsOrRows);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryClearTextAsync();

    [MethodImpl]
    public extern void Close();
  }
}
