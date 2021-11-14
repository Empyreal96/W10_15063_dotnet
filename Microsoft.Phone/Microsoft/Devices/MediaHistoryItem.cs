// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.MediaHistoryItem
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Collections.Generic;
using System.IO;

namespace Microsoft.Devices
{
  public class MediaHistoryItem
  {
    private Dictionary<string, string> _context;

    public MediaHistoryItem()
    {
      this._context = new Dictionary<string, string>();
      this.Source = "";
    }

    public string Title { get; set; }

    public string Source { get; set; }

    public Stream ImageStream { get; set; }

    public IDictionary<string, string> PlayerContext => (IDictionary<string, string>) this._context;

    public static int MaxImageSize => 76800;
  }
}
