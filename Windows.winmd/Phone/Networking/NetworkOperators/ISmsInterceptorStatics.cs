// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.NetworkOperators.ISmsInterceptorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.NetworkOperators
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(3482391690, 48119, 16773, 190, 165, 107, 163, 7, 18, 36, 150)]
  [ExclusiveTo(typeof (SmsInterceptor))]
  internal interface ISmsInterceptorStatics
  {
    IVectorView<InterceptedSmsMessage> GetQueuedMessages();

    event EventHandler<object> SmsReceived;
  }
}
