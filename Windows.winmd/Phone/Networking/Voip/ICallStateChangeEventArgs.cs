// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.ICallStateChangeEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [Guid(524191664, 54129, 17301, 139, 108, 23, 134, 164, 46, 47, 24)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (CallStateChangeEventArgs))]
  internal interface ICallStateChangeEventArgs
  {
    VoipCallState State { get; }
  }
}
