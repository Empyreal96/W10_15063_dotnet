// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.ContentReader
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Security;

namespace Microsoft.Xna.Framework.Content
{
  public sealed class ContentReader : BinaryReader
  {
    private const char PlatformLabel = 'm';
    private const ushort XnbVersion = 5;
    private const ushort XnbCompressedVersion = 32773;
    private const ushort XnbVersionProfileMask = 32512;
    private const int XnbVersionProfileShift = 8;
    private const int XnbPrologueSize = 10;
    private const int XnbCompressedPrologueSize = 14;
    private ContentManager contentManager;
    private string assetName;
    private Action<IDisposable> recordDisposableObject;
    private ContentTypeReader[] typeReaders;
    private List<Action<object>>[] sharedResourceFixups;
    internal int graphicsProfile;

    internal static ContentReader Create(
      ContentManager contentManager,
      Stream input,
      string assetName,
      Action<IDisposable> recordDisposableObject)
    {
      int graphicsProfile;
      input = ContentReader.PrepareStream(input, assetName, out graphicsProfile);
      return new ContentReader(contentManager, input, assetName, recordDisposableObject, graphicsProfile);
    }

    private ContentReader(
      ContentManager contentManager,
      Stream input,
      string assetName,
      Action<IDisposable> recordDisposableObject,
      int graphicsProfile)
      : base(input)
    {
      this.contentManager = contentManager;
      this.assetName = assetName;
      this.recordDisposableObject = recordDisposableObject;
      this.graphicsProfile = graphicsProfile;
    }

    public ContentManager ContentManager => this.contentManager;

    public string AssetName => this.assetName;

    private static Stream PrepareStream(
      Stream input,
      string assetName,
      out int graphicsProfile)
    {
      try
      {
        BinaryReader binaryReader = new BinaryReader(input);
        if (binaryReader.ReadByte() != (byte) 88 || binaryReader.ReadByte() != (byte) 78 || binaryReader.ReadByte() != (byte) 66)
          throw ContentReader.CreateContentLoadException(assetName, (Exception) null, FrameworkResources.BadXnbMagic);
        int num1 = binaryReader.ReadByte() == (byte) 109 ? (int) binaryReader.ReadUInt16() : throw ContentReader.CreateContentLoadException(assetName, (Exception) null, FrameworkResources.BadXnbPlatform);
        graphicsProfile = (num1 & 32512) >> 8;
        bool flag;
        switch (num1 & -32513)
        {
          case 5:
            flag = false;
            break;
          case 32773:
            flag = true;
            break;
          default:
            throw ContentReader.CreateContentLoadException(assetName, (Exception) null, FrameworkResources.BadXnbVersion);
        }
        int num2 = binaryReader.ReadInt32();
        if (input.CanSeek && (long) (num2 - 10) > input.Length - input.Position)
          throw ContentReader.CreateContentLoadException(assetName, (Exception) null, FrameworkResources.BadXnbSize);
        if (flag)
          throw ContentReader.CreateContentLoadException(assetName, (Exception) null, FrameworkResources.BadXnbVersion);
        return input;
      }
      catch (IOException ex)
      {
        throw ContentReader.CreateContentLoadException(assetName, (Exception) ex, FrameworkResources.BadXnb);
      }
    }

    internal T ReadAsset<T>()
    {
      try
      {
        int sharedResourceCount = this.ReadHeader();
        T obj = this.ReadObject<T>();
        this.ReadSharedResources(sharedResourceCount);
        return obj;
      }
      catch (IOException ex)
      {
        throw this.CreateContentLoadException((Exception) ex, FrameworkResources.BadXnb);
      }
    }

    private int ReadHeader()
    {
      this.typeReaders = ContentTypeReaderManager.ReadTypeManifest(this.Read7BitEncodedInt(), this);
      int length = this.Read7BitEncodedInt();
      if (length > 0)
      {
        this.sharedResourceFixups = new List<Action<object>>[length];
        for (int index = 0; index < length; ++index)
          this.sharedResourceFixups[index] = new List<Action<object>>();
      }
      return length;
    }

    [SuppressMessage("Microsoft.Design", "CA1004")]
    public T ReadObject<T>() => this.ReadObjectInternal<T>((object) null);

    public T ReadObject<T>(T existingInstance) => this.ReadObjectInternal<T>((object) existingInstance);

    [SuppressMessage("Microsoft.Design", "CA1004")]
    public T ReadObject<T>(ContentTypeReader typeReader) => this.ReadObjectInternal<T>(typeReader, (object) null);

    public T ReadObject<T>(ContentTypeReader typeReader, T existingInstance) => this.ReadObjectInternal<T>(typeReader, (object) existingInstance);

    private T ReadObjectInternal<T>(object existingInstance)
    {
      int num = this.Read7BitEncodedInt();
      if (num == 0)
        return default (T);
      int index = num - 1;
      if ((long) (uint) index >= (long) this.typeReaders.Length)
        throw this.CreateContentLoadException(FrameworkResources.BadXnb);
      return this.InvokeReader<T>(this.typeReaders[index], existingInstance);
    }

    private T ReadObjectInternal<T>(ContentTypeReader typeReader, object existingInstance)
    {
      if (typeReader == null)
        throw new ArgumentNullException(nameof (typeReader));
      return typeReader.TargetIsValueType ? this.InvokeReader<T>(typeReader, existingInstance) : this.ReadObjectInternal<T>(existingInstance);
    }

    [SuppressMessage("Microsoft.Design", "CA1004")]
    public T ReadRawObject<T>() => this.InvokeReader<T>(ContentTypeReaderManager.GetTypeReader(typeof (T), this), (object) null);

    public T ReadRawObject<T>(T existingInstance) => this.InvokeReader<T>(ContentTypeReaderManager.GetTypeReader(typeof (T), this), (object) existingInstance);

    [SuppressMessage("Microsoft.Design", "CA1004")]
    public T ReadRawObject<T>(ContentTypeReader typeReader) => typeReader != null ? this.InvokeReader<T>(typeReader, (object) null) : throw new ArgumentNullException(nameof (typeReader));

    public T ReadRawObject<T>(ContentTypeReader typeReader, T existingInstance) => typeReader != null ? this.InvokeReader<T>(typeReader, (object) existingInstance) : throw new ArgumentNullException(nameof (typeReader));

    private T InvokeReader<T>(ContentTypeReader reader, object existingInstance)
    {
      if (reader is ContentTypeReader<T> contentTypeReader)
      {
        T existingInstance1 = existingInstance == null ? default (T) : (T) existingInstance;
        obj5 = contentTypeReader.Read(this, existingInstance1);
      }
      else
      {
        object obj1 = reader.Read(this, existingInstance);
        if (obj1 != null)
        {
          if (!(obj1 is T obj5))
            throw this.CreateContentLoadException(FrameworkResources.BadXnbWrongType, (object) obj1.GetType(), (object) typeof (T));
        }
        else
          obj5 = default (T);
      }
      if (existingInstance != null)
      {
        if (existingInstance != (object) obj5)
          throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.ReaderConstructedNewInstance, (object) reader.GetType()));
      }
      else if (!reader.TargetIsValueType && obj5 is IDisposable disposable2)
      {
        if (this.recordDisposableObject != null)
          this.recordDisposableObject(disposable2);
        else
          this.contentManager.RecordDisposableObject(disposable2);
      }
      return obj5;
    }

    public void ReadSharedResource<T>(Action<T> fixup)
    {
      if (fixup == null)
        throw new ArgumentNullException(nameof (fixup));
      int num = this.Read7BitEncodedInt();
      if (num == 0)
        return;
      int index = num - 1;
      if ((long) (uint) index >= (long) this.sharedResourceFixups.Length)
        throw this.CreateContentLoadException(FrameworkResources.BadXnb);
      this.sharedResourceFixups[index].Add((Action<object>) (value =>
      {
        if (!(value is T obj2))
          throw this.CreateContentLoadException(FrameworkResources.BadXnb);
        fixup(obj2);
      }));
    }

    private void ReadSharedResources(int sharedResourceCount)
    {
      if (sharedResourceCount <= 0)
        return;
      object[] objArray = new object[sharedResourceCount];
      for (int index = 0; index < sharedResourceCount; ++index)
        objArray[index] = this.ReadObject<object>();
      for (int index = 0; index < sharedResourceCount; ++index)
      {
        foreach (Action<object> action in this.sharedResourceFixups[index])
          action(objArray[index]);
      }
    }

    [SuppressMessage("Microsoft.Design", "CA1004")]
    public T ReadExternalReference<T>()
    {
      string referenceName = this.ReadString();
      return string.IsNullOrEmpty(referenceName) ? default (T) : this.contentManager.Load<T>(TitleContainer.GetCleanPath(this.GetPathToReference(referenceName)));
    }

    private string GetPathToReference(string referenceName)
    {
      int length = this.assetName.LastIndexOfAny(new char[3]
      {
        '\\',
        '/',
        Path.DirectorySeparatorChar
      });
      string path1 = "";
      if (length != -1)
        path1 = this.assetName.Substring(0, length);
      return Path.Combine(path1, referenceName);
    }

    internal string GetAbsolutePathToReference(string referenceName)
    {
      referenceName = this.GetPathToReference(referenceName);
      referenceName = Path.Combine(this.contentManager.fullRootDirectory, referenceName);
      referenceName = Path.Combine(TitleLocation.Path, referenceName);
      return TitleContainer.GetCleanPath(referenceName);
    }

    internal byte[] ReadByteBuffer(int size)
    {
      byte[] byteBuffer = this.contentManager.GetByteBuffer(size);
      int num;
      for (int index = 0; index < size; index += num)
      {
        num = this.Read(byteBuffer, index, size - index);
        if (num == 0)
          throw this.CreateContentLoadException(FrameworkResources.BadXnb);
      }
      return byteBuffer;
    }

    internal ContentLoadException CreateContentLoadException(
      string message,
      params object[] messageArgs)
    {
      return ContentReader.CreateContentLoadException(this.assetName, (Exception) null, message, messageArgs);
    }

    internal ContentLoadException CreateContentLoadException(
      Exception innerException,
      string message,
      params object[] messageArgs)
    {
      return ContentReader.CreateContentLoadException(this.assetName, innerException, message, messageArgs);
    }

    internal static ContentLoadException CreateContentLoadException(
      string assetName,
      Exception innerException,
      string message,
      params object[] messageArgs)
    {
      object[] objArray = new object[messageArgs.Length + 1];
      objArray[0] = (object) assetName;
      messageArgs.CopyTo((Array) objArray, 1);
      return new ContentLoadException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, message, objArray), innerException);
    }

    public Vector2 ReadVector2()
    {
      Vector2 vector2;
      vector2.X = this.ReadSingle();
      vector2.Y = this.ReadSingle();
      return vector2;
    }

    public Vector3 ReadVector3()
    {
      Vector3 vector3;
      vector3.X = this.ReadSingle();
      vector3.Y = this.ReadSingle();
      vector3.Z = this.ReadSingle();
      return vector3;
    }

    public Vector4 ReadVector4()
    {
      Vector4 vector4;
      vector4.X = this.ReadSingle();
      vector4.Y = this.ReadSingle();
      vector4.Z = this.ReadSingle();
      vector4.W = this.ReadSingle();
      return vector4;
    }

    public Matrix ReadMatrix()
    {
      Matrix matrix;
      matrix.M11 = this.ReadSingle();
      matrix.M12 = this.ReadSingle();
      matrix.M13 = this.ReadSingle();
      matrix.M14 = this.ReadSingle();
      matrix.M21 = this.ReadSingle();
      matrix.M22 = this.ReadSingle();
      matrix.M23 = this.ReadSingle();
      matrix.M24 = this.ReadSingle();
      matrix.M31 = this.ReadSingle();
      matrix.M32 = this.ReadSingle();
      matrix.M33 = this.ReadSingle();
      matrix.M34 = this.ReadSingle();
      matrix.M41 = this.ReadSingle();
      matrix.M42 = this.ReadSingle();
      matrix.M43 = this.ReadSingle();
      matrix.M44 = this.ReadSingle();
      return matrix;
    }

    public Quaternion ReadQuaternion()
    {
      Quaternion quaternion;
      quaternion.X = this.ReadSingle();
      quaternion.Y = this.ReadSingle();
      quaternion.Z = this.ReadSingle();
      quaternion.W = this.ReadSingle();
      return quaternion;
    }

    public Color ReadColor() => new Color()
    {
      PackedValue = this.ReadUInt32()
    };

    [SecuritySafeCritical]
    public override unsafe float ReadSingle() => *(float*) &this.ReadUInt32();

    [SecuritySafeCritical]
    public override unsafe double ReadDouble() => *(double*) &this.ReadUInt64();
  }
}
