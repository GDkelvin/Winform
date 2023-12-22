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

namespace MyHotel
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbMyHotel")]
	public partial class DBMyHotelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcustomer(customer instance);
    partial void Updatecustomer(customer instance);
    partial void Deletecustomer(customer instance);
    partial void Insertroom(room instance);
    partial void Updateroom(room instance);
    partial void Deleteroom(room instance);
    partial void Insertemployee(employee instance);
    partial void Updateemployee(employee instance);
    partial void Deleteemployee(employee instance);
    #endregion
		
		public DBMyHotelDataContext() : 
				base(global::MyHotel.Properties.Settings.Default.dbMyHotelConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBMyHotelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMyHotelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMyHotelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMyHotelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<customer> customers
		{
			get
			{
				return this.GetTable<customer>();
			}
		}
		
		public System.Data.Linq.Table<room> rooms
		{
			get
			{
				return this.GetTable<room>();
			}
		}
		
		public System.Data.Linq.Table<employee> employees
		{
			get
			{
				return this.GetTable<employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customer")]
	public partial class customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cid;
		
		private string _cname;
		
		private long _mobile;
		
		private string _nationality;
		
		private string _gender;
		
		private string _dob;
		
		private string _idproof;
		
		private string _address;
		
		private string _checkin;
		
		private string _checkout;
		
		private string _chekout;
		
		private int _roomid;
		
		private EntityRef<room> _room;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncidChanging(int value);
    partial void OncidChanged();
    partial void OncnameChanging(string value);
    partial void OncnameChanged();
    partial void OnmobileChanging(long value);
    partial void OnmobileChanged();
    partial void OnnationalityChanging(string value);
    partial void OnnationalityChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OndobChanging(string value);
    partial void OndobChanged();
    partial void OnidproofChanging(string value);
    partial void OnidproofChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OncheckinChanging(string value);
    partial void OncheckinChanged();
    partial void OncheckoutChanging(string value);
    partial void OncheckoutChanged();
    partial void OnchekoutChanging(string value);
    partial void OnchekoutChanged();
    partial void OnroomidChanging(int value);
    partial void OnroomidChanged();
    #endregion
		
		public customer()
		{
			this._room = default(EntityRef<room>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int cid
		{
			get
			{
				return this._cid;
			}
			set
			{
				if ((this._cid != value))
				{
					this.OncidChanging(value);
					this.SendPropertyChanging();
					this._cid = value;
					this.SendPropertyChanged("cid");
					this.OncidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cname", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string cname
		{
			get
			{
				return this._cname;
			}
			set
			{
				if ((this._cname != value))
				{
					this.OncnameChanging(value);
					this.SendPropertyChanging();
					this._cname = value;
					this.SendPropertyChanged("cname");
					this.OncnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mobile", DbType="BigInt NOT NULL")]
		public long mobile
		{
			get
			{
				return this._mobile;
			}
			set
			{
				if ((this._mobile != value))
				{
					this.OnmobileChanging(value);
					this.SendPropertyChanging();
					this._mobile = value;
					this.SendPropertyChanged("mobile");
					this.OnmobileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nationality", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string nationality
		{
			get
			{
				return this._nationality;
			}
			set
			{
				if ((this._nationality != value))
				{
					this.OnnationalityChanging(value);
					this.SendPropertyChanging();
					this._nationality = value;
					this.SendPropertyChanged("nationality");
					this.OnnationalityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dob", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string dob
		{
			get
			{
				return this._dob;
			}
			set
			{
				if ((this._dob != value))
				{
					this.OndobChanging(value);
					this.SendPropertyChanging();
					this._dob = value;
					this.SendPropertyChanged("dob");
					this.OndobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idproof", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string idproof
		{
			get
			{
				return this._idproof;
			}
			set
			{
				if ((this._idproof != value))
				{
					this.OnidproofChanging(value);
					this.SendPropertyChanging();
					this._idproof = value;
					this.SendPropertyChanged("idproof");
					this.OnidproofChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(350) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_checkin", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string checkin
		{
			get
			{
				return this._checkin;
			}
			set
			{
				if ((this._checkin != value))
				{
					this.OncheckinChanging(value);
					this.SendPropertyChanging();
					this._checkin = value;
					this.SendPropertyChanged("checkin");
					this.OncheckinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_checkout", DbType="VarChar(250)")]
		public string checkout
		{
			get
			{
				return this._checkout;
			}
			set
			{
				if ((this._checkout != value))
				{
					this.OncheckoutChanging(value);
					this.SendPropertyChanging();
					this._checkout = value;
					this.SendPropertyChanged("checkout");
					this.OncheckoutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_chekout", DbType="VarChar(250)")]
		public string chekout
		{
			get
			{
				return this._chekout;
			}
			set
			{
				if ((this._chekout != value))
				{
					this.OnchekoutChanging(value);
					this.SendPropertyChanging();
					this._chekout = value;
					this.SendPropertyChanged("chekout");
					this.OnchekoutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roomid", DbType="Int NOT NULL")]
		public int roomid
		{
			get
			{
				return this._roomid;
			}
			set
			{
				if ((this._roomid != value))
				{
					if (this._room.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnroomidChanging(value);
					this.SendPropertyChanging();
					this._roomid = value;
					this.SendPropertyChanged("roomid");
					this.OnroomidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="room_customer", Storage="_room", ThisKey="roomid", OtherKey="roomid", IsForeignKey=true)]
		public room room
		{
			get
			{
				return this._room.Entity;
			}
			set
			{
				room previousValue = this._room.Entity;
				if (((previousValue != value) 
							|| (this._room.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._room.Entity = null;
						previousValue.customers.Remove(this);
					}
					this._room.Entity = value;
					if ((value != null))
					{
						value.customers.Add(this);
						this._roomid = value.roomid;
					}
					else
					{
						this._roomid = default(int);
					}
					this.SendPropertyChanged("room");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.rooms")]
	public partial class room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _roomid;
		
		private string _roomNo;
		
		private string _roomType;
		
		private string _Description;
		
		private long _price;
		
		private string _booked;
		
		private EntitySet<customer> _customers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnroomidChanging(int value);
    partial void OnroomidChanged();
    partial void OnroomNoChanging(string value);
    partial void OnroomNoChanged();
    partial void OnroomTypeChanging(string value);
    partial void OnroomTypeChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnpriceChanging(long value);
    partial void OnpriceChanged();
    partial void OnbookedChanging(string value);
    partial void OnbookedChanged();
    #endregion
		
		public room()
		{
			this._customers = new EntitySet<customer>(new Action<customer>(this.attach_customers), new Action<customer>(this.detach_customers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roomid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int roomid
		{
			get
			{
				return this._roomid;
			}
			set
			{
				if ((this._roomid != value))
				{
					this.OnroomidChanging(value);
					this.SendPropertyChanging();
					this._roomid = value;
					this.SendPropertyChanged("roomid");
					this.OnroomidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roomNo", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string roomNo
		{
			get
			{
				return this._roomNo;
			}
			set
			{
				if ((this._roomNo != value))
				{
					this.OnroomNoChanging(value);
					this.SendPropertyChanging();
					this._roomNo = value;
					this.SendPropertyChanged("roomNo");
					this.OnroomNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roomType", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string roomType
		{
			get
			{
				return this._roomType;
			}
			set
			{
				if ((this._roomType != value))
				{
					this.OnroomTypeChanging(value);
					this.SendPropertyChanging();
					this._roomType = value;
					this.SendPropertyChanged("roomType");
					this.OnroomTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="BigInt NOT NULL")]
		public long price
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_booked", DbType="VarChar(50)")]
		public string booked
		{
			get
			{
				return this._booked;
			}
			set
			{
				if ((this._booked != value))
				{
					this.OnbookedChanging(value);
					this.SendPropertyChanging();
					this._booked = value;
					this.SendPropertyChanged("booked");
					this.OnbookedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="room_customer", Storage="_customers", ThisKey="roomid", OtherKey="roomid")]
		public EntitySet<customer> customers
		{
			get
			{
				return this._customers;
			}
			set
			{
				this._customers.Assign(value);
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
		
		private void attach_customers(customer entity)
		{
			this.SendPropertyChanging();
			entity.room = this;
		}
		
		private void detach_customers(customer entity)
		{
			this.SendPropertyChanging();
			entity.room = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employee")]
	public partial class employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _eid;
		
		private string _ename;
		
		private long _mobile;
		
		private string _gender;
		
		private string _emailid;
		
		private string _username;
		
		private string _pass;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OneidChanging(int value);
    partial void OneidChanged();
    partial void OnenameChanging(string value);
    partial void OnenameChanged();
    partial void OnmobileChanging(long value);
    partial void OnmobileChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OnemailidChanging(string value);
    partial void OnemailidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    #endregion
		
		public employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int eid
		{
			get
			{
				return this._eid;
			}
			set
			{
				if ((this._eid != value))
				{
					this.OneidChanging(value);
					this.SendPropertyChanging();
					this._eid = value;
					this.SendPropertyChanged("eid");
					this.OneidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ename", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string ename
		{
			get
			{
				return this._ename;
			}
			set
			{
				if ((this._ename != value))
				{
					this.OnenameChanging(value);
					this.SendPropertyChanging();
					this._ename = value;
					this.SendPropertyChanged("ename");
					this.OnenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mobile", DbType="BigInt NOT NULL")]
		public long mobile
		{
			get
			{
				return this._mobile;
			}
			set
			{
				if ((this._mobile != value))
				{
					this.OnmobileChanging(value);
					this.SendPropertyChanging();
					this._mobile = value;
					this.SendPropertyChanged("mobile");
					this.OnmobileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailid", DbType="VarChar(120) NOT NULL", CanBeNull=false)]
		public string emailid
		{
			get
			{
				return this._emailid;
			}
			set
			{
				if ((this._emailid != value))
				{
					this.OnemailidChanging(value);
					this.SendPropertyChanging();
					this._emailid = value;
					this.SendPropertyChanged("emailid");
					this.OnemailidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
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
}
#pragma warning restore 1591
