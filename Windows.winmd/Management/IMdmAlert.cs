// Decompiled with JetBrains decompiler
// Type: Windows.Management.IMdmAlert
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  [Guid(2969289511, 10433, 19282, 165, 72, 197, 128, 124, 175, 112, 182)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MdmAlert))]
  internal interface IMdmAlert
  {
    string Data { get; set; }

    MdmAlertDataType Format { get; set; }

    MdmAlertMark Mark { get; set; }

    string Source { get; set; }

    uint Status { get; }

    string Target { get; set; }

    string Type { get; set; }
  }
}
