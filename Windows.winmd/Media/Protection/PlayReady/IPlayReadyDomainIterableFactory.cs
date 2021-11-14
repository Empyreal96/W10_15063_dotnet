// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyDomainIterableFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyDomainIterable))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1307804910, 12577, 19955, 165, 232, 208, 194, 76, 5, 0, 252)]
  internal interface IPlayReadyDomainIterableFactory
  {
    PlayReadyDomainIterable CreateInstance(Guid domainAccountId);
  }
}
