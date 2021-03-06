﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3655
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NerdDinner.Models
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="NerdDinner")]
	public partial class NerdDinnerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDinner(Dinner instance);
    partial void UpdateDinner(Dinner instance);
    partial void DeleteDinner(Dinner instance);
    partial void Insertrsvp(rsvp instance);
    partial void Updatersvp(rsvp instance);
    partial void Deletersvp(rsvp instance);
    #endregion
		
		public NerdDinnerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NerdDinnerConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Dinner> Dinners
		{
			get
			{
				return this.GetTable<Dinner>();
			}
		}
		
		public System.Data.Linq.Table<rsvp> rsvps
		{
			get
			{
				return this.GetTable<rsvp>();
			}
		}
	}
	
	[Table(Name="dbo.Dinners")]
	public partial class Dinner : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DinnerId;
		
		private string _Title;
		
		private System.Nullable<System.DateTime> _EventDate;
		
		private string _Description;
		
		private string _HostedBy;
		
		private string _ContactPhone;
		
		private string _Address;
		
		private string _Country;
		
		private System.Nullable<double> _Latitude;
		
		private System.Nullable<double> _Longitude;
		
		private EntitySet<rsvp> _rsvps;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDinnerIdChanging(int value);
    partial void OnDinnerIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnEventDateChanging(System.Nullable<System.DateTime> value);
    partial void OnEventDateChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnHostedByChanging(string value);
    partial void OnHostedByChanged();
    partial void OnContactPhoneChanging(string value);
    partial void OnContactPhoneChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnLatitudeChanging(System.Nullable<double> value);
    partial void OnLatitudeChanged();
    partial void OnLongitudeChanging(System.Nullable<double> value);
    partial void OnLongitudeChanged();
    #endregion
		
		public Dinner()
		{
			this._rsvps = new EntitySet<rsvp>(new Action<rsvp>(this.attach_rsvps), new Action<rsvp>(this.detach_rsvps));
			OnCreated();
		}
		
		[Column(Storage="_DinnerId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DinnerId
		{
			get
			{
				return this._DinnerId;
			}
			set
			{
				if ((this._DinnerId != value))
				{
					this.OnDinnerIdChanging(value);
					this.SendPropertyChanging();
					this._DinnerId = value;
					this.SendPropertyChanged("DinnerId");
					this.OnDinnerIdChanged();
				}
			}
		}
		
		[Column(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[Column(Storage="_EventDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> EventDate
		{
			get
			{
				return this._EventDate;
			}
			set
			{
				if ((this._EventDate != value))
				{
					this.OnEventDateChanging(value);
					this.SendPropertyChanging();
					this._EventDate = value;
					this.SendPropertyChanged("EventDate");
					this.OnEventDateChanged();
				}
			}
		}
		
		[Column(Storage="_Description", DbType="NVarChar(256)")]
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
		
		[Column(Storage="_HostedBy", DbType="NVarChar(20)")]
		public string HostedBy
		{
			get
			{
				return this._HostedBy;
			}
			set
			{
				if ((this._HostedBy != value))
				{
					this.OnHostedByChanging(value);
					this.SendPropertyChanging();
					this._HostedBy = value;
					this.SendPropertyChanged("HostedBy");
					this.OnHostedByChanged();
				}
			}
		}
		
		[Column(Storage="_ContactPhone", DbType="NVarChar(20)")]
		public string ContactPhone
		{
			get
			{
				return this._ContactPhone;
			}
			set
			{
				if ((this._ContactPhone != value))
				{
					this.OnContactPhoneChanging(value);
					this.SendPropertyChanging();
					this._ContactPhone = value;
					this.SendPropertyChanged("ContactPhone");
					this.OnContactPhoneChanged();
				}
			}
		}
		
		[Column(Storage="_Address", DbType="NVarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[Column(Storage="_Country", DbType="NVarChar(30)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[Column(Storage="_Latitude", DbType="Float")]
		public System.Nullable<double> Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[Column(Storage="_Longitude", DbType="Float")]
		public System.Nullable<double> Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[Association(Name="Dinner_rsvp", Storage="_rsvps", ThisKey="DinnerId", OtherKey="DinnerId")]
		public EntitySet<rsvp> rsvps
		{
			get
			{
				return this._rsvps;
			}
			set
			{
				this._rsvps.Assign(value);
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
		
		private void attach_rsvps(rsvp entity)
		{
			this.SendPropertyChanging();
			entity.Dinner = this;
		}
		
		private void detach_rsvps(rsvp entity)
		{
			this.SendPropertyChanging();
			entity.Dinner = null;
		}
	}
	
	[Table(Name="dbo.rsvp")]
	public partial class rsvp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RsvpId;
		
		private int _DinnerId;
		
		private string _AttendeeName;
		
		private EntityRef<Dinner> _Dinner;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRsvpIdChanging(int value);
    partial void OnRsvpIdChanged();
    partial void OnDinnerIdChanging(int value);
    partial void OnDinnerIdChanged();
    partial void OnAttendeeNameChanging(string value);
    partial void OnAttendeeNameChanged();
    #endregion
		
		public rsvp()
		{
			this._Dinner = default(EntityRef<Dinner>);
			OnCreated();
		}
		
		[Column(Storage="_RsvpId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RsvpId
		{
			get
			{
				return this._RsvpId;
			}
			set
			{
				if ((this._RsvpId != value))
				{
					this.OnRsvpIdChanging(value);
					this.SendPropertyChanging();
					this._RsvpId = value;
					this.SendPropertyChanged("RsvpId");
					this.OnRsvpIdChanged();
				}
			}
		}
		
		[Column(Storage="_DinnerId", DbType="Int NOT NULL")]
		public int DinnerId
		{
			get
			{
				return this._DinnerId;
			}
			set
			{
				if ((this._DinnerId != value))
				{
					if (this._Dinner.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDinnerIdChanging(value);
					this.SendPropertyChanging();
					this._DinnerId = value;
					this.SendPropertyChanged("DinnerId");
					this.OnDinnerIdChanged();
				}
			}
		}
		
		[Column(Storage="_AttendeeName", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string AttendeeName
		{
			get
			{
				return this._AttendeeName;
			}
			set
			{
				if ((this._AttendeeName != value))
				{
					this.OnAttendeeNameChanging(value);
					this.SendPropertyChanging();
					this._AttendeeName = value;
					this.SendPropertyChanged("AttendeeName");
					this.OnAttendeeNameChanged();
				}
			}
		}
		
		[Association(Name="Dinner_rsvp", Storage="_Dinner", ThisKey="DinnerId", OtherKey="DinnerId", IsForeignKey=true)]
		public Dinner Dinner
		{
			get
			{
				return this._Dinner.Entity;
			}
			set
			{
				Dinner previousValue = this._Dinner.Entity;
				if (((previousValue != value) 
							|| (this._Dinner.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Dinner.Entity = null;
						previousValue.rsvps.Remove(this);
					}
					this._Dinner.Entity = value;
					if ((value != null))
					{
						value.rsvps.Add(this);
						this._DinnerId = value.DinnerId;
					}
					else
					{
						this._DinnerId = default(int);
					}
					this.SendPropertyChanged("Dinner");
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
