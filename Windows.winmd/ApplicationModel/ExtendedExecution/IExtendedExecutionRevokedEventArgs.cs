﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.IExtendedExecutionRevokedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution
{
  [Guid(3216809750, 25525, 19467, 170, 214, 130, 138, 245, 55, 62, 195)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ExtendedExecutionRevokedEventArgs))]
  internal interface IExtendedExecutionRevokedEventArgs
  {
    ExtendedExecutionRevokedReason Reason { get; }
  }
}