// Decompiled with JetBrains decompiler
// Type: Windows.Management.IMdmSessionManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3477789017, 63301, 19321, 155, 92, 222, 11, 248, 239, 228, 75)]
  [ExclusiveTo(typeof (MdmSessionManager))]
  internal interface IMdmSessionManagerStatics
  {
    IVectorView<string> SessionIds { get; }

    MdmSession TryCreateSession();

    void DeleteSessionById(string sessionId);

    MdmSession GetSessionById(string sessionId);
  }
}
