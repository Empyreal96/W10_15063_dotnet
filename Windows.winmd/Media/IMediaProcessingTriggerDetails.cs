// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaProcessingTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(3951387820, 41809, 20302, 180, 240, 155, 242, 64, 137, 147, 219)]
  [ExclusiveTo(typeof (MediaProcessingTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaProcessingTriggerDetails
  {
    ValueSet Arguments { get; }
  }
}
