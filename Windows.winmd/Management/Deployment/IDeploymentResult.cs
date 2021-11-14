// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IDeploymentResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [Guid(627292590, 46973, 19487, 138, 123, 32, 230, 173, 81, 94, 243)]
  [ExclusiveTo(typeof (DeploymentResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeploymentResult
  {
    string ErrorText { get; }

    Guid ActivityId { get; }

    HResult ExtendedErrorCode { get; }
  }
}
