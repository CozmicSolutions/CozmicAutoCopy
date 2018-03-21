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

namespace CozmicBackupDataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CIS_Backup_Database")]
	public partial class BackupDataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCIS_System(CIS_System instance);
    partial void UpdateCIS_System(CIS_System instance);
    partial void DeleteCIS_System(CIS_System instance);
    partial void InsertCIS_UserAccountActivity(CIS_UserAccountActivity instance);
    partial void UpdateCIS_UserAccountActivity(CIS_UserAccountActivity instance);
    partial void DeleteCIS_UserAccountActivity(CIS_UserAccountActivity instance);
    partial void InsertCIS_UserAccount(CIS_UserAccount instance);
    partial void UpdateCIS_UserAccount(CIS_UserAccount instance);
    partial void DeleteCIS_UserAccount(CIS_UserAccount instance);
    #endregion
		
		public BackupDataBaseDataContext() : 
				base(global::CozmicBackupDataAccess.Properties.Settings.Default.CIS_Backup_DatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BackupDataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BackupDataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BackupDataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BackupDataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CIS_System> CIS_Systems
		{
			get
			{
				return this.GetTable<CIS_System>();
			}
		}
		
		public System.Data.Linq.Table<CIS_UserAccountActivity> CIS_UserAccountActivities
		{
			get
			{
				return this.GetTable<CIS_UserAccountActivity>();
			}
		}
		
		public System.Data.Linq.Table<CIS_UserAccount> CIS_UserAccounts
		{
			get
			{
				return this.GetTable<CIS_UserAccount>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CIS_System")]
	public partial class CIS_System : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _SID;
		
		private System.Nullable<System.Guid> _KeyValue;
		
		private System.Nullable<int> _KeyType;
		
		private System.Nullable<System.DateTime> _StartDate;
		
		private System.Nullable<System.DateTime> _EndDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSIDChanging(System.Guid value);
    partial void OnSIDChanged();
    partial void OnKeyValueChanging(System.Nullable<System.Guid> value);
    partial void OnKeyValueChanged();
    partial void OnKeyTypeChanging(System.Nullable<int> value);
    partial void OnKeyTypeChanged();
    partial void OnStartDateChanging(System.Nullable<System.DateTime> value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.Nullable<System.DateTime> value);
    partial void OnEndDateChanged();
    #endregion
		
		public CIS_System()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid SID
		{
			get
			{
				return this._SID;
			}
			set
			{
				if ((this._SID != value))
				{
					this.OnSIDChanging(value);
					this.SendPropertyChanging();
					this._SID = value;
					this.SendPropertyChanged("SID");
					this.OnSIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KeyValue", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> KeyValue
		{
			get
			{
				return this._KeyValue;
			}
			set
			{
				if ((this._KeyValue != value))
				{
					this.OnKeyValueChanging(value);
					this.SendPropertyChanging();
					this._KeyValue = value;
					this.SendPropertyChanged("KeyValue");
					this.OnKeyValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KeyType", DbType="Int")]
		public System.Nullable<int> KeyType
		{
			get
			{
				return this._KeyType;
			}
			set
			{
				if ((this._KeyType != value))
				{
					this.OnKeyTypeChanging(value);
					this.SendPropertyChanging();
					this._KeyType = value;
					this.SendPropertyChanged("KeyType");
					this.OnKeyTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CIS_UserAccountActivity")]
	public partial class CIS_UserAccountActivity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _UAActivityID;
		
		private System.Guid _UserAccountID;
		
		private System.DateTime _LoginDate;
		
		private System.Nullable<System.DateTime> _LogoutDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUAActivityIDChanging(System.Guid value);
    partial void OnUAActivityIDChanged();
    partial void OnUserAccountIDChanging(System.Guid value);
    partial void OnUserAccountIDChanged();
    partial void OnLoginDateChanging(System.DateTime value);
    partial void OnLoginDateChanged();
    partial void OnLogoutDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLogoutDateChanged();
    #endregion
		
		public CIS_UserAccountActivity()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UAActivityID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid UAActivityID
		{
			get
			{
				return this._UAActivityID;
			}
			set
			{
				if ((this._UAActivityID != value))
				{
					this.OnUAActivityIDChanging(value);
					this.SendPropertyChanging();
					this._UAActivityID = value;
					this.SendPropertyChanged("UAActivityID");
					this.OnUAActivityIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserAccountID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid UserAccountID
		{
			get
			{
				return this._UserAccountID;
			}
			set
			{
				if ((this._UserAccountID != value))
				{
					this.OnUserAccountIDChanging(value);
					this.SendPropertyChanging();
					this._UserAccountID = value;
					this.SendPropertyChanged("UserAccountID");
					this.OnUserAccountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginDate", DbType="DateTime NOT NULL")]
		public System.DateTime LoginDate
		{
			get
			{
				return this._LoginDate;
			}
			set
			{
				if ((this._LoginDate != value))
				{
					this.OnLoginDateChanging(value);
					this.SendPropertyChanging();
					this._LoginDate = value;
					this.SendPropertyChanged("LoginDate");
					this.OnLoginDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogoutDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LogoutDate
		{
			get
			{
				return this._LogoutDate;
			}
			set
			{
				if ((this._LogoutDate != value))
				{
					this.OnLogoutDateChanging(value);
					this.SendPropertyChanging();
					this._LogoutDate = value;
					this.SendPropertyChanged("LogoutDate");
					this.OnLogoutDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CIS_UserAccount")]
	public partial class CIS_UserAccount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _UserAccountID;
		
		private System.Guid _SID;
		
		private string _Username;
		
		private string _Password;
		
		private bool _Active;
		
		private System.DateTime _CreateDate;
		
		private int _Status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserAccountIDChanging(System.Guid value);
    partial void OnUserAccountIDChanged();
    partial void OnSIDChanging(System.Guid value);
    partial void OnSIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnActiveChanging(bool value);
    partial void OnActiveChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    partial void OnStatusChanging(int value);
    partial void OnStatusChanged();
    #endregion
		
		public CIS_UserAccount()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserAccountID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid UserAccountID
		{
			get
			{
				return this._UserAccountID;
			}
			set
			{
				if ((this._UserAccountID != value))
				{
					this.OnUserAccountIDChanging(value);
					this.SendPropertyChanging();
					this._UserAccountID = value;
					this.SendPropertyChanged("UserAccountID");
					this.OnUserAccountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid SID
		{
			get
			{
				return this._SID;
			}
			set
			{
				if ((this._SID != value))
				{
					this.OnSIDChanging(value);
					this.SendPropertyChanging();
					this._SID = value;
					this.SendPropertyChanged("SID");
					this.OnSIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit NOT NULL")]
		public bool Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int NOT NULL")]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
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