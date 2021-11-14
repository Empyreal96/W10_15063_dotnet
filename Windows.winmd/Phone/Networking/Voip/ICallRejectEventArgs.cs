// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.Voip.ICallRejectEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.Voip
{
  [ExclusiveTo(typeof (CallRejectEventArgs))]
  [Guid(1040451098, 52861, 18882, 162, 184, 127, 73, 182, 234, 235, 197)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface ICallRejectEventArgs
  {
    VoipCallRejectReason RejectReason { get; }
  }
}
