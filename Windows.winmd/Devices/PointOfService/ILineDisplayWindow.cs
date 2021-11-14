// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayWindow
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (LineDisplayWindow))]
  [Guid(3525308148, 9060, 19429, 190, 225, 133, 22, 128, 175, 73, 100)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ILineDisplayWindow : IClosable
  {
    Size SizeInCharacters { get; }

    TimeSpan InterCharacterWaitInterval { get; set; }

    [RemoteAsync]
    IAsyncOperation<bool> TryRefreshAsync();

    [RemoteAsync]
    [Overload("TryDisplayTextAsync")]
    IAsyncOperation<bool> TryDisplayTextAsync(
      string text,
      LineDisplayTextAttribute displayAttribute);

    [Overload("TryDisplayTextAtPositionAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryDisplayTextAsync(
      string text,
      LineDisplayTextAttribute displayAttribute,
      Point startPosition);

    [Overload("TryDisplayTextNormalAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryDisplayTextAsync(string text);

    [RemoteAsync]
    IAsyncOperation<bool> TryScrollTextAsync(
      LineDisplayScrollDirection direction,
      uint numberOfColumnsOrRows);

    [RemoteAsync]
    IAsyncOperation<bool> TryClearTextAsync();
  }
}
