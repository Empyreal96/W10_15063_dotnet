// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.ContentReadyEventArgs
// Assembly: Microsoft.Devices.Camera, Version=0.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: EF9A4555-242B-4723-B191-4FF24D598391
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI27EF~1.DLL

using System;
using System.IO;

namespace Microsoft.Devices
{
  public sealed class ContentReadyEventArgs : EventArgs
  {
    internal ContentReadyEventArgs(Stream s) => this.ImageStream = s;

    public Stream ImageStream { get; private set; }
  }
}
