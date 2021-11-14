// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.ContentSerializerAttribute
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;

namespace Microsoft.Xna.Framework.Content
{
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class ContentSerializerAttribute : Attribute
  {
    private string elementName;
    private bool flattenContent;
    private bool optional;
    private bool allowNull = true;
    private bool sharedResource;
    private string collectionItemName;

    public string ElementName
    {
      get => this.elementName;
      set => this.elementName = value;
    }

    public bool FlattenContent
    {
      get => this.flattenContent;
      set => this.flattenContent = value;
    }

    public bool Optional
    {
      get => this.optional;
      set => this.optional = value;
    }

    public bool AllowNull
    {
      get => this.allowNull;
      set => this.allowNull = value;
    }

    public bool SharedResource
    {
      get => this.sharedResource;
      set => this.sharedResource = value;
    }

    public string CollectionItemName
    {
      get => string.IsNullOrEmpty(this.collectionItemName) ? "Item" : this.collectionItemName;
      set => this.collectionItemName = !string.IsNullOrEmpty(value) ? value : throw new ArgumentNullException(nameof (value));
    }

    public bool HasCollectionItemName => !string.IsNullOrEmpty(this.collectionItemName);

    public ContentSerializerAttribute Clone() => new ContentSerializerAttribute()
    {
      elementName = this.elementName,
      flattenContent = this.flattenContent,
      optional = this.optional,
      allowNull = this.allowNull,
      sharedResource = this.sharedResource,
      collectionItemName = this.collectionItemName
    };
  }
}
