// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IPinnedContactManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4133276798, 65017, 18538, 172, 233, 188, 49, 29, 10, 231, 240)]
  [ExclusiveTo(typeof (PinnedContactManager))]
  internal interface IPinnedContactManagerStatics
  {
    PinnedContactManager GetDefault();

    PinnedContactManager GetForUser(User user);

    bool IsSupported();
  }
}
