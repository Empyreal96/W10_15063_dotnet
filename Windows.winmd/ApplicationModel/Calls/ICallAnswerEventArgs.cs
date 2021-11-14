// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.ICallAnswerEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (CallAnswerEventArgs))]
  [WebHostHidden]
  [Guid(4252538391, 11735, 19596, 178, 189, 149, 209, 122, 91, 183, 51)]
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  internal interface ICallAnswerEventArgs
  {
    VoipPhoneCallMedia AcceptedMedia { get; }
  }
}
