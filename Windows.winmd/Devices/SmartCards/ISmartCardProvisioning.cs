// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardProvisioning
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmartCardProvisioning))]
  [Guid(435088829, 8107, 18300, 183, 18, 26, 44, 90, 241, 253, 110)]
  internal interface ISmartCardProvisioning
  {
    SmartCard SmartCard { get; }

    [RemoteAsync]
    IAsyncOperation<Guid> GetIdAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetNameAsync();

    [RemoteAsync]
    IAsyncOperation<SmartCardChallengeContext> GetChallengeContextAsync();

    IAsyncOperation<bool> RequestPinChangeAsync();

    IAsyncOperation<bool> RequestPinResetAsync(SmartCardPinResetHandler handler);
  }
}
