// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IUnifiedPosErrorData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(731483194, 21852, 18569, 142, 216, 197, 153, 187, 58, 113, 42)]
  [ExclusiveTo(typeof (UnifiedPosErrorData))]
  internal interface IUnifiedPosErrorData
  {
    string Message { get; }

    UnifiedPosErrorSeverity Severity { get; }

    UnifiedPosErrorReason Reason { get; }

    uint ExtendedReason { get; }
  }
}
