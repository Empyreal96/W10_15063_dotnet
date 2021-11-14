// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.ICallStateChangeEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CallStateChangeEventArgs))]
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  [Guid(3937547422, 26357, 18425, 159, 181, 69, 156, 81, 152, 199, 32)]
  internal interface ICallStateChangeEventArgs
  {
    VoipPhoneCallState State { get; }
  }
}
