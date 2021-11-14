// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2163306094, 37623, 17694, 151, 210, 175, 216, 7, 66, 218, 112)]
  public interface IMediaStreamDescriptor
  {
    bool IsSelected { get; }

    string Name { set; get; }

    string Language { set; get; }
  }
}
