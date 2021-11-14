// Decompiled with JetBrains decompiler
// Type: Windows.Management.Workplace.IMdmPolicyStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Workplace
{
  [Guid(3382474022, 980, 18937, 169, 147, 67, 239, 204, 210, 101, 196)]
  [ExclusiveTo(typeof (MdmPolicy))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMdmPolicyStatics2
  {
    MessagingSyncPolicy GetMessagingSyncPolicy();
  }
}
