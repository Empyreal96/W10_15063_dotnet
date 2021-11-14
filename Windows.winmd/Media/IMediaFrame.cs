// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(3216322444, 22851, 18392, 142, 16, 5, 48, 138, 165, 251, 208)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMediaFrame : IClosable
  {
    string Type { get; }

    bool IsReadOnly { get; }

    IReference<TimeSpan> RelativeTime { set; get; }

    IReference<TimeSpan> SystemRelativeTime { set; get; }

    IReference<TimeSpan> Duration { set; get; }

    bool IsDiscontinuous { set; get; }

    IPropertySet ExtendedProperties { get; }
  }
}
