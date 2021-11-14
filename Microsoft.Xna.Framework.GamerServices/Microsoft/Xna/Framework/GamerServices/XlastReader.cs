// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.XlastReader
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Microsoft.Xna.Framework.GamerServices
{
  [SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses")]
  internal class XlastReader
  {
    public const int HeaderId = -1;
    public const int FileFormatVersion = 1;
    private BinaryReader reader;
    private string[] sharedStrings;
    private XlastProperty[] sharedProperties;

    public XlastConfiguration Read(Stream inputStream)
    {
      this.reader = new BinaryReader(inputStream);
      int num = 0;
      if (this.reader.ReadInt32() == -1)
        num = this.reader.ReadInt32();
      else
        this.reader.BaseStream.Seek(0L, SeekOrigin.Begin);
      this.sharedStrings = this.ReadArray<string>(new XlastReader.Reader<string>(this.reader.ReadString));
      this.sharedProperties = this.ReadArray<XlastProperty>(new XlastReader.Reader<XlastProperty>(this.ReadPropertyData));
      XlastConfiguration xlastConfiguration = new XlastConfiguration();
      xlastConfiguration.Achievements = this.ReadDictionary<int>(new XlastReader.Reader<int>(this.reader.ReadInt32));
      xlastConfiguration.GamerPictures = this.ReadDictionary<int>(new XlastReader.Reader<int>(this.reader.ReadInt32));
      if (num >= 1)
        xlastConfiguration.AvatarAssets = this.ReadDictionary<int>(new XlastReader.Reader<int>(this.reader.ReadInt32));
      xlastConfiguration.GameModes = this.ReadDictionary<int>(new XlastReader.Reader<int>(this.reader.ReadInt32));
      xlastConfiguration.PresenceModes = this.ReadDictionary<int>(new XlastReader.Reader<int>(this.reader.ReadInt32));
      xlastConfiguration.PresenceProperties = this.ReadDictionary<XlastProperty>(new XlastReader.Reader<XlastProperty>(this.ReadSharedProperty));
      xlastConfiguration.Leaderboards = this.ReadDictionary<XlastLeaderboard>(new XlastReader.Reader<XlastLeaderboard>(this.ReadLeaderboard));
      return xlastConfiguration;
    }

    private string ReadSharedString() => this.sharedStrings[this.reader.ReadInt32()];

    private XlastProperty ReadSharedProperty() => this.sharedProperties[this.reader.ReadInt32()];

    private XlastProperty ReadPropertyData()
    {
      XlastProperty xlastProperty = new XlastProperty();
      xlastProperty.PropertyId = this.reader.ReadInt32();
      xlastProperty.PropertyType = (XlastPropertyType) this.reader.ReadInt32();
      if (xlastProperty.PropertyType == XlastPropertyType.Context)
      {
        xlastProperty.ContextValues = this.ReadArray<string>(new XlastReader.Reader<string>(this.ReadSharedString));
        xlastProperty.ContextDefault = this.reader.ReadInt32();
      }
      return xlastProperty;
    }

    private XlastLeaderboard ReadLeaderboard() => new XlastLeaderboard()
    {
      BoardId = this.reader.ReadInt32(),
      RatingId = this.reader.ReadInt32(),
      IsArbitrated = this.reader.ReadBoolean(),
      Columns = this.ReadDictionary<XlastLeaderboardColumn>(new XlastReader.Reader<XlastLeaderboardColumn>(this.ReadLeaderboardColumn))
    };

    private XlastLeaderboardColumn ReadLeaderboardColumn() => new XlastLeaderboardColumn()
    {
      ColumnId = this.reader.ReadInt32(),
      Property = this.ReadSharedProperty()
    };

    private T[] ReadArray<T>(XlastReader.Reader<T> readValue)
    {
      int length = this.reader.ReadInt32();
      T[] objArray = new T[length];
      for (int index = 0; index < length; ++index)
        objArray[index] = readValue();
      return objArray;
    }

    private Dictionary<string, T> ReadDictionary<T>(XlastReader.Reader<T> readValue)
    {
      int capacity = this.reader.ReadInt32();
      Dictionary<string, T> dictionary = new Dictionary<string, T>(capacity);
      for (int index = 0; index < capacity; ++index)
      {
        string key = this.ReadSharedString();
        T obj = readValue();
        dictionary.Add(key, obj);
      }
      return dictionary;
    }

    private delegate T Reader<T>();
  }
}
