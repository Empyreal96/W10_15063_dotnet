// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.AccountChangedEventArgs
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  [Activatable(100859904)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AccountChangedEventArgs : IAccountChangedEventArgs
  {
    [MethodImpl]
    public extern AccountChangedEventArgs();

    public extern Guid AccountId { [MethodImpl] get; }

    public extern AccountChangeType Type { [MethodImpl] get; }

    public extern IVector<string> ChangedPropertyIds { [MethodImpl] get; }
  }
}
