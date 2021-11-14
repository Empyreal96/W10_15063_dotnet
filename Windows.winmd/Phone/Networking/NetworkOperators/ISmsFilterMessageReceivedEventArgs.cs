// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.NetworkOperators.ISmsFilterMessageReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.NetworkOperators
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (SmsFilterMessageReceivedEventArgs))]
  [Guid(2339687657, 18257, 16623, 163, 73, 14, 234, 197, 110, 37, 171)]
  internal interface ISmsFilterMessageReceivedEventArgs
  {
    string SenderPhoneNumber { get; }

    string Body { get; }

    SmsFilterAction Action { get; set; }
  }
}
