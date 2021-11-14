// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallBlockingStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (PhoneCallBlocking))]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [Guid(426012548, 11129, 9969, 164, 111, 105, 75, 224, 67, 243, 19)]
  internal interface IPhoneCallBlockingStatics
  {
    bool BlockUnknownNumbers { get; set; }

    bool BlockPrivateNumbers { get; set; }

    [RemoteAsync]
    IAsyncOperation<bool> SetCallBlockingListAsync(IIterable<string> phoneNumberList);
  }
}
