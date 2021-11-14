// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.ICallRejectEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (CallRejectEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  [Guid(3662150359, 5076, 19858, 161, 194, 183, 120, 17, 238, 55, 236)]
  internal interface ICallRejectEventArgs
  {
    VoipPhoneCallRejectReason RejectReason { get; }
  }
}
