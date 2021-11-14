// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IAppDisplayInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(451612931, 58580, 16810, 164, 246, 196, 162, 118, 231, 158, 172)]
  [ExclusiveTo(typeof (AppDisplayInfo))]
  internal interface IAppDisplayInfo
  {
    string DisplayName { get; }

    string Description { get; }

    RandomAccessStreamReference GetLogo(Size size);
  }
}
