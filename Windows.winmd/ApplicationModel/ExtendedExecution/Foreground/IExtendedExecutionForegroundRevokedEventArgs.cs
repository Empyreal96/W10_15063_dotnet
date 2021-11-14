// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.Foreground.IExtendedExecutionForegroundRevokedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution.Foreground
{
  [Guid(2960972096, 38231, 44708, 44, 153, 189, 213, 109, 155, 228, 97)]
  [ExclusiveTo(typeof (ExtendedExecutionForegroundRevokedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IExtendedExecutionForegroundRevokedEventArgs
  {
    ExtendedExecutionForegroundRevokedReason Reason { get; }
  }
}
