// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Media.MediaStreamerFactory
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Media
{
  public static class MediaStreamerFactory
  {
    private static MediaStreamer _activeStreamer;

    public static MediaStreamer CreateMediaStreamer(int id)
    {
      MediaStreamerFactory._activeStreamer = MediaStreamerFactory._activeStreamer == null ? new MediaStreamer(id) : throw new InvalidOperationException("Only one MediaStreamer can be active at a time.");
      return MediaStreamerFactory._activeStreamer;
    }

    internal static void MakeInactive(MediaStreamer streamer)
    {
      if (MediaStreamerFactory._activeStreamer != streamer)
        return;
      MediaStreamerFactory._activeStreamer = (MediaStreamer) null;
    }
  }
}
