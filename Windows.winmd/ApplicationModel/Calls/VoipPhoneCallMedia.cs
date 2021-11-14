// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.VoipPhoneCallMedia
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Flags]
  [WebHostHidden]
  [ContractVersion(typeof (CallsVoipContract), 65536)]
  public enum VoipPhoneCallMedia : uint
  {
    None = 0,
    Audio = 1,
    Video = 2,
  }
}
