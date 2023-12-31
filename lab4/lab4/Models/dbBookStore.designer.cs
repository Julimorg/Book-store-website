﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab4.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BookStore")]
	public partial class dbBookStoreDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertPublisher(Publisher instance);
    partial void UpdatePublisher(Publisher instance);
    partial void DeletePublisher(Publisher instance);
        #endregion

        public dbBookStoreDataContext() :
                base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BookStoreConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }

        public dbBookStoreDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbBookStoreDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbBookStoreDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<Publisher> Publishers
		{
			get
			{
				return this.GetTable<Publisher>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _book_id;
		
		private System.Nullable<int> _publisher_id;
		
		private string _book_name;
		
		private string _image;
		
		private System.Nullable<decimal> _price;
		
		private System.Nullable<System.DateTime> _update_date;
		
		private System.Nullable<int> _quantity_instock;
		
		private EntityRef<Publisher> _Publisher;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onbook_idChanging(int value);
    partial void Onbook_idChanged();
    partial void Onpublisher_idChanging(System.Nullable<int> value);
    partial void Onpublisher_idChanged();
    partial void Onbook_nameChanging(string value);
    partial void Onbook_nameChanged();
    partial void OnimageChanging(string value);
    partial void OnimageChanged();
    partial void OnpriceChanging(System.Nullable<decimal> value);
    partial void OnpriceChanged();
    partial void Onupdate_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onupdate_dateChanged();
    partial void Onquantity_instockChanging(System.Nullable<int> value);
    partial void Onquantity_instockChanged();
    #endregion
		
		public Book()
		{
			this._Publisher = default(EntityRef<Publisher>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_book_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int book_id
		{
			get
			{
				return this._book_id;
			}
			set
			{
				if ((this._book_id != value))
				{
					this.Onbook_idChanging(value);
					this.SendPropertyChanging();
					this._book_id = value;
					this.SendPropertyChanged("book_id");
					this.Onbook_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publisher_id", DbType="Int")]
		public System.Nullable<int> publisher_id
		{
			get
			{
				return this._publisher_id;
			}
			set
			{
				if ((this._publisher_id != value))
				{
					if (this._Publisher.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onpublisher_idChanging(value);
					this.SendPropertyChanging();
					this._publisher_id = value;
					this.SendPropertyChanged("publisher_id");
					this.Onpublisher_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_book_name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string book_name
		{
			get
			{
				return this._book_name;
			}
			set
			{
				if ((this._book_name != value))
				{
					this.Onbook_nameChanging(value);
					this.SendPropertyChanging();
					this._book_name = value;
					this.SendPropertyChanged("book_name");
					this.Onbook_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image", DbType="VarChar(50)")]
		public string image
		{
			get
			{
				return this._image;
			}
			set
			{
				if ((this._image != value))
				{
					this.OnimageChanging(value);
					this.SendPropertyChanging();
					this._image = value;
					this.SendPropertyChanged("image");
					this.OnimageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_update_date", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> update_date
		{
			get
			{
				return this._update_date;
			}
			set
			{
				if ((this._update_date != value))
				{
					this.Onupdate_dateChanging(value);
					this.SendPropertyChanging();
					this._update_date = value;
					this.SendPropertyChanged("update_date");
					this.Onupdate_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity_instock", DbType="Int")]
		public System.Nullable<int> quantity_instock
		{
			get
			{
				return this._quantity_instock;
			}
			set
			{
				if ((this._quantity_instock != value))
				{
					this.Onquantity_instockChanging(value);
					this.SendPropertyChanging();
					this._quantity_instock = value;
					this.SendPropertyChanged("quantity_instock");
					this.Onquantity_instockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Publisher_Book", Storage="_Publisher", ThisKey="publisher_id", OtherKey="publisher_id", IsForeignKey=true)]
		public Publisher Publisher
		{
			get
			{
				return this._Publisher.Entity;
			}
			set
			{
				Publisher previousValue = this._Publisher.Entity;
				if (((previousValue != value) 
							|| (this._Publisher.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Publisher.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._Publisher.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._publisher_id = value.publisher_id;
					}
					else
					{
						this._publisher_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Publisher");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Publisher")]
	public partial class Publisher : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _publisher_id;
		
		private string _publisher_name;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpublisher_idChanging(int value);
    partial void Onpublisher_idChanged();
    partial void Onpublisher_nameChanging(string value);
    partial void Onpublisher_nameChanged();
    #endregion
		
		public Publisher()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publisher_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int publisher_id
		{
			get
			{
				return this._publisher_id;
			}
			set
			{
				if ((this._publisher_id != value))
				{
					this.Onpublisher_idChanging(value);
					this.SendPropertyChanging();
					this._publisher_id = value;
					this.SendPropertyChanged("publisher_id");
					this.Onpublisher_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publisher_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string publisher_name
		{
			get
			{
				return this._publisher_name;
			}
			set
			{
				if ((this._publisher_name != value))
				{
					this.Onpublisher_nameChanging(value);
					this.SendPropertyChanging();
					this._publisher_name = value;
					this.SendPropertyChanged("publisher_name");
					this.Onpublisher_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Publisher_Book", Storage="_Books", ThisKey="publisher_id", OtherKey="publisher_id")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Publisher = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Publisher = null;
		}
	}
}
#pragma warning restore 1591
