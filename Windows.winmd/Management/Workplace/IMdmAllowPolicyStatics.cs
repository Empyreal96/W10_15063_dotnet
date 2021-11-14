// Decompiled with JetBrains decompiler
// Type: Windows.Management.Workplace.IMdmAllowPolicyStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Workplace
{
  [ExclusiveTo(typeof (MdmPolicy))]
  [Guid(3281455591, 29724, 16882, 164, 182, 49, 76, 49, 80, 37, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMdmAllowPolicyStatics
  {
    bool IsBrowserAllowed();

    bool IsCameraAllowed();

    bool IsMicrosoftAccountAllowed();

    bool IsStoreAllowed();
  }
}
