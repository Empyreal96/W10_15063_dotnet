﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPanelLaunchFullAppRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2295733262, 9140, 19432, 138, 252, 7, 44, 37, 164, 25, 13)]
  [ExclusiveTo(typeof (ContactPanelLaunchFullAppRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IContactPanelLaunchFullAppRequestedEventArgs
  {
    bool Handled { get; set; }
  }
}
