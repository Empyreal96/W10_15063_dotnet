// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGattServiceProviderTriggerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (GattServiceProviderTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3021185898, 58004, 17809, 165, 166, 100, 137, 26, 130, 129, 83)]
  internal interface IGattServiceProviderTriggerStatics
  {
    [Overload("CreateAsync")]
    [RemoteAsync]
    IAsyncOperation<GattServiceProviderTriggerResult> CreateAsync(
      string triggerId,
      Guid serviceUuid);
  }
}
