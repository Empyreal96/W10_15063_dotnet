// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IDataCue2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(3159759637, 38386, 18920, 150, 241, 141, 213, 218, 198, 141, 147)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (DataCue))]
  internal interface IDataCue2 : IDataCue, IMediaCue
  {
    PropertySet Properties { get; }
  }
}
