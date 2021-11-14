// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneLineStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (PhoneLine))]
  [Guid(4085997347, 52912, 16463, 188, 242, 186, 159, 105, 125, 138, 223)]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  internal interface IPhoneLineStatics
  {
    [RemoteAsync]
    IAsyncOperation<PhoneLine> FromIdAsync(Guid lineId);
  }
}
