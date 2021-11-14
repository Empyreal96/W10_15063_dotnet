// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCard
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCard))]
  [Guid(460425329, 25652, 17396, 181, 90, 106, 41, 98, 56, 112, 170)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmartCard
  {
    SmartCardReader Reader { get; }

    [RemoteAsync]
    IAsyncOperation<SmartCardStatus> GetStatusAsync();

    [RemoteAsync]
    IAsyncOperation<IBuffer> GetAnswerToResetAsync();
  }
}
