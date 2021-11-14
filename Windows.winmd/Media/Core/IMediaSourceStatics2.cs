// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(4007748004, 32531, 18582, 184, 203, 223, 13, 229, 188, 185, 241)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (MediaSource))]
  internal interface IMediaSourceStatics2
  {
    MediaSource CreateFromMediaBinder(MediaBinder binder);
  }
}
