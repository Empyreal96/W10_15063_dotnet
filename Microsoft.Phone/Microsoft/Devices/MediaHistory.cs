// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.MediaHistory
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security;
using System.Text;

namespace Microsoft.Devices
{
  public sealed class MediaHistory
  {
    public static MediaHistory Instance = new MediaHistory();
    private MediaHistoryItem _mostRecentNowPlaying;

    private MediaHistory()
    {
    }

    public MediaHistoryItem NowPlaying
    {
      get => this._mostRecentNowPlaying;
      set
      {
        this.CommonAddItem(HistorySet.NowPlaying, value);
        this._mostRecentNowPlaying = value;
      }
    }

    public void WriteRecentPlay(MediaHistoryItem item)
    {
      Console.WriteLine("in write recent play");
      this.CommonAddItem(HistorySet.RecentPlay, item);
    }

    [SecuritySafeCritical]
    public void WriteAcquiredItem(MediaHistoryItem item)
    {
      Console.WriteLine("in write acquired item");
      this.CommonAddItem(HistorySet.New, item);
    }

    private void CommonAddItem(HistorySet historyList, MediaHistoryItem item)
    {
      if (item == null)
        throw new ArgumentNullException(nameof (item));
      Console.WriteLine("in CommonAddItem");
      this.CommonAddItem(historyList, item.Title, item.Source, this.CopyStreamToBuffer(item.ImageStream), this.PackDictionary(item.PlayerContext));
    }

    [SecuritySafeCritical]
    private void CommonAddItem(
      HistorySet historyList,
      string title,
      string source,
      byte[] imageBuffer,
      string dictionary)
    {
      Console.WriteLine("in CommonAddItem native wrapper");
      Console.WriteLine("historyList =" + historyList.ToString());
      Console.WriteLine("title =" + title.ToString());
      Console.WriteLine("source =" + source.ToString());
      Console.WriteLine("dictionary =" + dictionary.ToString());
      int num = (int) historyList;
      string title1 = title;
      string context = source;
      string reactivation = dictionary;
      byte[] imageBuffer1 = imageBuffer;
      int length = imageBuffer1.Length;
      MediaApiNativeMethods.MediaApi_AddPlayHistory((uint) num, title1, context, reactivation, imageBuffer1, length);
    }

    private byte[] CopyStreamToBuffer(Stream stream)
    {
      int count = stream != null ? (int) stream.Length : throw new ArgumentException("null stream", "ImageStream");
      byte[] buffer = count <= MediaHistoryItem.MaxImageSize ? new byte[count] : throw new ArgumentException("image stream size bigger than maximum allowed " + (object) MediaHistoryItem.MaxImageSize, "ImageStream");
      if (count != stream.Read(buffer, 0, count))
        throw new InvalidOperationException("partial read?");
      return buffer;
    }

    private string PackDictionary(IDictionary<string, string> dict)
    {
      StringBuilder stringBuilder = new StringBuilder();
      bool flag = true;
      if (dict == null || dict.Count == 0)
      {
        Console.WriteLine("Warning: No reactivation params passed");
        return "EmptyKey=EmptyValue";
      }
      foreach (string key in (IEnumerable<string>) dict.Keys)
      {
        object obj = (object) dict[key];
        string str = obj != null ? HttpUtility.UrlEncode(obj.ToString()) : "";
        if (!flag)
          stringBuilder.Append('&');
        stringBuilder.AppendFormat((IFormatProvider) CultureInfo.InvariantCulture, "{0}={1}", (object) HttpUtility.UrlEncode(key.ToString()), (object) str);
        flag = false;
      }
      return stringBuilder.ToString();
    }
  }
}
