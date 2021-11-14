// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneLineWatcherEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [Guid(3497817406, 40466, 18999, 130, 183, 173, 83, 93, 173, 106, 103)]
  [ExclusiveTo(typeof (PhoneLineWatcherEventArgs))]
  internal interface IPhoneLineWatcherEventArgs
  {
    Guid LineId { get; }
  }
}
