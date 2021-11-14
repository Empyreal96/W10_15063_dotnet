// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IMuteChangeEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  [WebHostHidden]
  [Guid(2240143705, 3137, 17196, 129, 77, 197, 241, 253, 245, 48, 190)]
  [ExclusiveTo(typeof (MuteChangeEventArgs))]
  internal interface IMuteChangeEventArgs
  {
    bool Muted { get; }
  }
}
