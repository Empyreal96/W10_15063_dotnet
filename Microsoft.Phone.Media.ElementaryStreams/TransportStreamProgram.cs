// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Media.ElementaryStreams.TransportStreamProgram
// Assembly: Microsoft.Phone.Media.ElementaryStreams, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: C4AB28B9-B09C-47FC-B326-6B155141A87A
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFD1A~1.DLL

namespace Microsoft.Phone.Media.ElementaryStreams
{
  public class TransportStreamProgram
  {
    public TransportStreamProgram(uint programPid, uint programNumber)
    {
      this.ProgramPid = programPid;
      this.ProgramNumber = programNumber;
    }

    public bool ParsedPmt { get; set; }

    public uint ProgramPid { get; set; }

    public uint ProgramNumber { get; set; }
  }
}
