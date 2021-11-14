// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMultiSourceMediaFrameReference
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [Guid(563497754, 32738, 17622, 146, 229, 41, 142, 109, 40, 16, 233)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MultiSourceMediaFrameReference))]
  internal interface IMultiSourceMediaFrameReference : IClosable
  {
    MediaFrameReference TryGetFrameReferenceBySourceId(string sourceId);
  }
}
