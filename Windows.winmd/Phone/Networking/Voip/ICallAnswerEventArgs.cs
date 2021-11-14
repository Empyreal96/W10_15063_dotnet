// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.ICallAnswerEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [Guid(1643197098, 63786, 18682, 170, 143, 79, 58, 23, 102, 41, 128)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (CallAnswerEventArgs))]
  internal interface ICallAnswerEventArgs
  {
    VoipCallMedia AcceptedMedia { get; }
  }
}
