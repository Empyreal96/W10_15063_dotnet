// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAudio.Interop.IAudioTrack
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Phone.BackgroundAudio.Interop
{
  [Guid("31538b59-0d1b-49d2-b36a-42a5184571e5")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IAudioTrack
  {
    string Uri { get; set; }

    string Title { get; set; }

    string Artist { get; set; }

    string Album { get; set; }

    string AlbumArtUri { get; set; }

    string Tag { get; set; }

    uint TrackId { get; set; }

    int Duration { get; }

    uint PlayerControls { get; set; }

    uint QueueId { set; }

    void Commit();

    void Initialize(uint zmi);

    void Uninitialize();
  }
}
