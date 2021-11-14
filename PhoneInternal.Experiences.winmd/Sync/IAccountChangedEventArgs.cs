// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.IAccountChangedEventArgs
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Guid(3227730964, 28090, 18124, 160, 176, 51, 175, 223, 143, 63, 137)]
  [Version(100859904)]
  [ExclusiveTo(typeof (AccountChangedEventArgs))]
  internal interface IAccountChangedEventArgs
  {
    Guid AccountId { get; }

    AccountChangeType Type { get; }

    IVector<string> ChangedPropertyIds { get; }
  }
}
