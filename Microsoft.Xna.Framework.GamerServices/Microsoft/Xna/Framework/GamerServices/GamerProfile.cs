// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.GamerProfile
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.Globalization;
using System.IO;

namespace Microsoft.Xna.Framework.GamerServices
{
  public sealed class GamerProfile : IDisposable
  {
    private bool isDisposed;
    private string motto;
    private float reputation;
    private GamerZone gamerZone;
    private RegionInfo region;
    private int gamerScore;
    private int titlesPlayed;
    private int totalAchievements;
    private byte[] imageBuffer;

    internal GamerProfile()
    {
    }

    public void Dispose() => this.isDisposed = true;

    public bool IsDisposed
    {
      get => this.isDisposed;
      internal set => this.isDisposed = value;
    }

    public string Motto
    {
      get => this.motto;
      internal set => this.motto = value;
    }

    public float Reputation
    {
      get => this.reputation;
      internal set => this.reputation = value;
    }

    public GamerZone GamerZone
    {
      get => this.gamerZone;
      internal set => this.gamerZone = value;
    }

    public RegionInfo Region
    {
      get => this.region;
      internal set => this.region = value;
    }

    public int GamerScore
    {
      get => this.gamerScore;
      internal set => this.gamerScore = value;
    }

    public int TitlesPlayed
    {
      get => this.titlesPlayed;
      internal set => this.titlesPlayed = value;
    }

    public int TotalAchievements
    {
      get => this.totalAchievements;
      internal set => this.totalAchievements = value;
    }

    public Stream GetGamerPicture()
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      return (Stream) new MemoryStream(this.GamerPictureBuffer, false);
    }

    internal byte[] GamerPictureBuffer
    {
      get => this.imageBuffer;
      set => this.imageBuffer = value;
    }
  }
}
