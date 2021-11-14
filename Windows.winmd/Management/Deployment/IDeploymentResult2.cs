// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IDeploymentResult2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4228804956, 23041, 19415, 188, 241, 56, 28, 140, 130, 224, 74)]
  [ExclusiveTo(typeof (DeploymentResult))]
  internal interface IDeploymentResult2
  {
    bool IsRegistered { get; }
  }
}
