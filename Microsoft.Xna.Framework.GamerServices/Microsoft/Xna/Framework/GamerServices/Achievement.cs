// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.Achievement
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.IO;

namespace Microsoft.Xna.Framework.GamerServices
{
  public sealed class Achievement
  {
    private const int pictureSize = 64;
    internal int Id;
    private bool isDisposed;
    private byte[] pictureBuffer;

    internal void Dispose()
    {
      this.isDisposed = true;
      this.pictureBuffer = (byte[]) null;
    }

    public string Key { get; internal set; }

    public string Name { get; internal set; }

    public string Description { get; internal set; }

    public string HowToEarn { get; internal set; }

    public int GamerScore { get; internal set; }

    public bool IsEarned { get; internal set; }

    public bool EarnedOnline { get; internal set; }

    public bool DisplayBeforeEarned { get; internal set; }

    public DateTime EarnedDateTime { get; internal set; }

    public Stream GetPicture()
    {
      if (this.isDisposed)
        throw new ObjectDisposedException(this.GetType().Name, FrameworkResources.ObjectDisposedException);
      return (Stream) new MemoryStream(this.PictureBuffer, false);
    }

    internal byte[] PictureBuffer
    {
      get => this.pictureBuffer;
      set => this.pictureBuffer = value;
    }
  }
}
