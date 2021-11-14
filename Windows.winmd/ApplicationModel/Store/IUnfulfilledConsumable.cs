// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.IUnfulfilledConsumable
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UnfulfilledConsumable))]
  [Guid(771226555, 7389, 19640, 160, 20, 123, 156, 248, 152, 105, 39)]
  internal interface IUnfulfilledConsumable
  {
    string ProductId { get; }

    Guid TransactionId { get; }

    string OfferId { get; }
  }
}
