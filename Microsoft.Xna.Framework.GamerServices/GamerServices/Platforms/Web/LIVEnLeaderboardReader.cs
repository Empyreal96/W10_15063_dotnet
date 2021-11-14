// Decompiled with JetBrains decompiler
// Type: GamerServices.Platforms.Web.LIVEnLeaderboardReader
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.GamerServices.Stub;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace GamerServices.Platforms.Web
{
  internal class LIVEnLeaderboardReader : LIVEnTask
  {
    private const int MaxBlobSize = 10240;
    private int? pageStart;
    private string leaderboardName;
    private string dataGroup;
    private IAsyncResult leaderboardWriteAr;

    public List<LIVEnLeaderboardEntry> Entries { get; private set; }

    public LeaderboardIdentity LeaderboardId { get; private set; }

    public int TotalLeaderboardSize { get; private set; }

    public int PageSize { get; private set; }

    public LIVEnLeaderboardReader(
      IAsyncResult leaderboardWriteAr,
      LeaderboardIdentity leaderboardId,
      string leaderboardName,
      string dataGroup,
      int? pageStart,
      int pageSize)
    {
      this.LeaderboardId = leaderboardId;
      this.leaderboardName = leaderboardName;
      this.dataGroup = dataGroup;
      this.pageStart = pageStart;
      this.PageSize = pageSize;
      this.leaderboardWriteAr = leaderboardWriteAr;
    }

    public override void Do()
    {
      if (this.leaderboardWriteAr != null)
        this.leaderboardWriteAr.AsyncWaitHandle.WaitOne();
      List<LIVEnLeaderboardEntry> leaderboardEntryList = this.ReadLeaderboard(this.webService.ReadLeaderboard(this.LeaderboardId.GameMode, this.leaderboardName, this.dataGroup, this.pageStart, this.PageSize));
      byte[] buffer = new byte[10240];
      foreach (LIVEnLeaderboardEntry leaderboardEntry in leaderboardEntryList)
      {
        try
        {
          leaderboardEntry.BestScoreDatablob = this.CreateBlobStream(buffer, leaderboardEntry.BestScoreDatablobId);
          leaderboardEntry.BestTimeDatablob = this.CreateBlobStream(buffer, leaderboardEntry.BestTimeDatablobId);
        }
        catch (Exception ex)
        {
        }
      }
      this.Entries = leaderboardEntryList;
    }

    private List<LIVEnLeaderboardEntry> ReadLeaderboard(Stream stream)
    {
      XmlReader reader = XmlReader.Create(stream);
      List<LIVEnLeaderboardEntry> leaderboardEntryList = new List<LIVEnLeaderboardEntry>();
      LIVEnLeaderboardEntry entry = (LIVEnLeaderboardEntry) null;
      XmlReaderHelper.ReadUntil(reader, "LeaderboardResult");
      bool flag = false;
      while (!reader.EOF)
      {
        if (!flag)
          reader.Read();
        flag = false;
        switch (reader.NodeType)
        {
          case XmlNodeType.Element:
            string lower = reader.Name.ToLower();
            if (!(lower == "item"))
            {
              if (!(lower == "user"))
              {
                if (!(lower == "rank"))
                {
                  if (!(lower == "value"))
                  {
                    if (!(lower == "totalnumberofrows"))
                    {
                      if (lower == "statistics")
                      {
                        this.ReadStatistics(reader, entry);
                        continue;
                      }
                      continue;
                    }
                    this.TotalLeaderboardSize = reader.ReadElementContentAsInt();
                    flag = true;
                    continue;
                  }
                  if (entry != null)
                  {
                    entry.Value = reader.ReadElementContentAsLong();
                    flag = true;
                    continue;
                  }
                  continue;
                }
                if (entry != null)
                {
                  entry.Rank = reader.ReadElementContentAsInt();
                  flag = true;
                  continue;
                }
                continue;
              }
              this.ReadUserElement(reader, entry);
              continue;
            }
            entry = new LIVEnLeaderboardEntry();
            continue;
          case XmlNodeType.EndElement:
            if (reader.Name.ToLower() == "item" && entry != null)
            {
              leaderboardEntryList.Add(entry);
              entry = (LIVEnLeaderboardEntry) null;
              continue;
            }
            continue;
          default:
            continue;
        }
      }
      stream.Dispose();
      return leaderboardEntryList;
    }

    private void ReadUserElement(XmlReader reader, LIVEnLeaderboardEntry entry)
    {
      bool flag = false;
      while (!reader.EOF)
      {
        if (!flag)
          reader.Read();
        flag = false;
        if (reader.NodeType == XmlNodeType.Element)
        {
          string lower = reader.LocalName.ToLower();
          if (!(lower == "cid"))
          {
            if (!(lower == "gamertag"))
            {
              if (lower == "displayname")
              {
                entry.DisplayName = reader.ReadElementContentAsString();
                flag = true;
              }
            }
            else
            {
              entry.Gamertag = reader.ReadElementContentAsString();
              flag = true;
            }
          }
        }
        else if (reader.NodeType == XmlNodeType.EndElement && string.Compare("User", reader.LocalName, StringComparison.InvariantCultureIgnoreCase) == 0)
          return;
      }
      throw new InvalidOperationException();
    }

    private void ReadStatistics(XmlReader reader, LIVEnLeaderboardEntry entry)
    {
      while (reader.Read())
      {
        if (XmlReaderHelper.IsElement(reader, "Entry"))
        {
          if (XmlReaderHelper.ReadUntil(reader, "Name"))
          {
            string str = reader.ReadElementContentAsString();
            if (XmlReaderHelper.ReadUntil(reader, "Value"))
            {
              switch (str.ToLower())
              {
                case "averagescore":
                  entry.AverageScore = reader.ReadElementContentAsLong();
                  continue;
                case "averagetime":
                  entry.AverageTime = reader.ReadElementContentAsLong();
                  continue;
                case "bestscore":
                  entry.BestScore = reader.ReadElementContentAsLong();
                  continue;
                case "bestscoredatablobid":
                  entry.BestScoreDatablobId = reader.ReadElementContentAsString();
                  continue;
                case "besttime":
                  entry.BestTime = reader.ReadElementContentAsLong();
                  continue;
                case "besttimedatablobid":
                  entry.BestTimeDatablobId = reader.ReadElementContentAsString();
                  continue;
                case "cumulativescore":
                  entry.CumulativeScore = reader.ReadElementContentAsLong();
                  continue;
                case "cumulativetime":
                  entry.CumulativeTime = reader.ReadElementContentAsLong();
                  continue;
                case "gamesplayed":
                  entry.GamesPlayed = reader.ReadElementContentAsLong();
                  continue;
                case "lastplayeddatetime":
                  entry.LastPlayedDateTime = reader.ReadElementContentAsDateTime().Ticks;
                  continue;
                case "losses":
                  entry.Losses = reader.ReadElementContentAsLong();
                  continue;
                case "wins":
                  entry.Wins = reader.ReadElementContentAsLong();
                  continue;
                default:
                  continue;
              }
            }
          }
        }
        else if (reader.NodeType == XmlNodeType.EndElement && string.Compare("Statistics", reader.LocalName, StringComparison.InvariantCultureIgnoreCase) == 0)
          break;
      }
    }

    private int CreateBlobStream(byte[] buffer, string blobId)
    {
      int num = 0;
      if (!string.IsNullOrEmpty(blobId))
      {
        using (XmlReader reader = XmlReader.Create(this.webService.GetBlob(blobId)))
        {
          if (XmlReaderHelper.ReadUntil(reader, "blob"))
          {
            int length1 = reader.ReadElementContentAsBase64(buffer, 0, buffer.Length);
            if (length1 != 0)
            {
              byte[] numArray = new byte[length1];
              Array.Copy((Array) buffer, (Array) numArray, length1);
              IGamerServicesProvider gsp = GamerServicesDispatcher.Gsp;
              byte[] buffer1 = numArray;
              int length2 = buffer1.Length;
              num = gsp.CreateStream(buffer1, length2);
            }
          }
        }
      }
      else
      {
        byte[] numArray = new byte[0];
        IGamerServicesProvider gsp = GamerServicesDispatcher.Gsp;
        byte[] buffer1 = numArray;
        int length = buffer1.Length;
        num = gsp.CreateStream(buffer1, length);
      }
      return num;
    }
  }
}
