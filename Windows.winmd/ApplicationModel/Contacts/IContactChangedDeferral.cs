﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactChangedDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(3306437352, 6915, 18168, 182, 148, 165, 35, 232, 60, 252, 182)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactChangedDeferral))]
  internal interface IContactChangedDeferral
  {
    void Complete();
  }
}
