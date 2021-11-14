// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2440720833, 34291, 19921, 176, 1, 165, 11, 253, 33, 200, 210)]
  [ExclusiveTo(typeof (SystemProperties))]
  internal interface ISystemProperties
  {
    string Author { get; }

    string Comment { get; }

    string ItemNameDisplay { get; }

    string Keywords { get; }

    string Rating { get; }

    string Title { get; }

    SystemAudioProperties Audio { get; }

    SystemGPSProperties GPS { get; }

    SystemMediaProperties Media { get; }

    SystemMusicProperties Music { get; }

    SystemPhotoProperties Photo { get; }

    SystemVideoProperties Video { get; }

    SystemImageProperties Image { get; }
  }
}
