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

namespace SRS.REST
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataSource")]
	public partial class DBAskDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_User(tbl_User instance);
    partial void Updatetbl_User(tbl_User instance);
    partial void Deletetbl_User(tbl_User instance);
    partial void Inserttbl_PasswordReset(tbl_PasswordReset instance);
    partial void Updatetbl_PasswordReset(tbl_PasswordReset instance);
    partial void Deletetbl_PasswordReset(tbl_PasswordReset instance);
    #endregion
		
		public DBAskDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DataSourceConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBAskDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBAskDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBAskDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBAskDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_User> tbl_Users
		{
			get
			{
				return this.GetTable<tbl_User>();
			}
		}
		
		public System.Data.Linq.Table<tbl_PasswordReset> tbl_PasswordResets
		{
			get
			{
				return this.GetTable<tbl_PasswordReset>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usp_CreateUserFromExistUser")]
		public int usp_CreateUserFromExistUser([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="NVarChar(50)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="NVarChar(50)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="NVarChar(50)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmailAddress", DbType="NVarChar(50)")] string emailAddress, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ContactTelephone", DbType="NVarChar(50)")] string contactTelephone, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(50)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ExistUser", DbType="NVarChar(50)")] string existUser)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), firstName, lastName, userName, emailAddress, contactTelephone, password, existUser);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usp_tbl_PasswordReset_GetLastEntry")]
		public ISingleResult<usp_tbl_PasswordReset_GetLastEntryResult> usp_tbl_PasswordReset_GetLastEntry([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(500)")] string whereClause)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), whereClause);
			return ((ISingleResult<usp_tbl_PasswordReset_GetLastEntryResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.usp_tbl_EmailMessage_Search")]
		public ISingleResult<usp_tbl_EmailMessage_SearchResult> usp_tbl_EmailMessage_Search([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(500)")] string whereClause)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), whereClause);
			return ((ISingleResult<usp_tbl_EmailMessage_SearchResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_User")]
	public partial class tbl_User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PK;
		
		private int _AccountID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.Nullable<int> _BussinesGroupID;
		
		private System.Nullable<int> _ApproverID;
		
		private string _EmailAddress;
		
		private System.Nullable<int> _LocationID;
		
		private System.Nullable<int> _HomeLocationID;
		
		private System.Nullable<int> _ApprovalLevel;
		
		private string _UserName;
		
		private System.Nullable<int> _LanguageID;
		
		private System.Nullable<int> _CurrencyFormatID;
		
		private System.Nullable<int> _DateFormatID;
		
		private string _Password;
		
		private string _ContactTelephone;
		
		private System.Nullable<int> _RoleID;
		
		private bool _Locked;
		
		private int _FailedLoginAttempts;
		
		private System.Nullable<System.DateTime> _LastLoginDate;
		
		private System.Nullable<int> _BusinessUnitID;
		
		private bool _NotificationEmail;
		
		private bool _RunCompanyReports;
		
		private bool _ChangeBusinessUnit;
		
		private System.Nullable<bool> _Leaver;
		
		private System.Nullable<System.DateTime> _LeavingDate;
		
		private string _TimeZone;
		
		private string _Locale;
		
		private string _CostCenter;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPKChanging(int value);
    partial void OnPKChanged();
    partial void OnAccountIDChanging(int value);
    partial void OnAccountIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnBussinesGroupIDChanging(System.Nullable<int> value);
    partial void OnBussinesGroupIDChanged();
    partial void OnApproverIDChanging(System.Nullable<int> value);
    partial void OnApproverIDChanged();
    partial void OnEmailAddressChanging(string value);
    partial void OnEmailAddressChanged();
    partial void OnLocationIDChanging(System.Nullable<int> value);
    partial void OnLocationIDChanged();
    partial void OnHomeLocationIDChanging(System.Nullable<int> value);
    partial void OnHomeLocationIDChanged();
    partial void OnApprovalLevelChanging(System.Nullable<int> value);
    partial void OnApprovalLevelChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnLanguageIDChanging(System.Nullable<int> value);
    partial void OnLanguageIDChanged();
    partial void OnCurrencyFormatIDChanging(System.Nullable<int> value);
    partial void OnCurrencyFormatIDChanged();
    partial void OnDateFormatIDChanging(System.Nullable<int> value);
    partial void OnDateFormatIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnContactTelephoneChanging(string value);
    partial void OnContactTelephoneChanged();
    partial void OnRoleIDChanging(System.Nullable<int> value);
    partial void OnRoleIDChanged();
    partial void OnLockedChanging(bool value);
    partial void OnLockedChanged();
    partial void OnFailedLoginAttemptsChanging(int value);
    partial void OnFailedLoginAttemptsChanged();
    partial void OnLastLoginDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastLoginDateChanged();
    partial void OnBusinessUnitIDChanging(System.Nullable<int> value);
    partial void OnBusinessUnitIDChanged();
    partial void OnNotificationEmailChanging(bool value);
    partial void OnNotificationEmailChanged();
    partial void OnRunCompanyReportsChanging(bool value);
    partial void OnRunCompanyReportsChanged();
    partial void OnChangeBusinessUnitChanging(bool value);
    partial void OnChangeBusinessUnitChanged();
    partial void OnLeaverChanging(System.Nullable<bool> value);
    partial void OnLeaverChanged();
    partial void OnLeavingDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLeavingDateChanged();
    partial void OnTimeZoneChanging(string value);
    partial void OnTimeZoneChanged();
    partial void OnLocaleChanging(string value);
    partial void OnLocaleChanged();
    partial void OnCostCenterChanging(string value);
    partial void OnCostCenterChanged();
    #endregion
		
		public tbl_User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PK", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PK
		{
			get
			{
				return this._PK;
			}
			set
			{
				if ((this._PK != value))
				{
					this.OnPKChanging(value);
					this.SendPropertyChanging();
					this._PK = value;
					this.SendPropertyChanged("PK");
					this.OnPKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountID", DbType="Int NOT NULL")]
		public int AccountID
		{
			get
			{
				return this._AccountID;
			}
			set
			{
				if ((this._AccountID != value))
				{
					this.OnAccountIDChanging(value);
					this.SendPropertyChanging();
					this._AccountID = value;
					this.SendPropertyChanged("AccountID");
					this.OnAccountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BussinesGroupID", DbType="Int")]
		public System.Nullable<int> BussinesGroupID
		{
			get
			{
				return this._BussinesGroupID;
			}
			set
			{
				if ((this._BussinesGroupID != value))
				{
					this.OnBussinesGroupIDChanging(value);
					this.SendPropertyChanging();
					this._BussinesGroupID = value;
					this.SendPropertyChanged("BussinesGroupID");
					this.OnBussinesGroupIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApproverID", DbType="Int")]
		public System.Nullable<int> ApproverID
		{
			get
			{
				return this._ApproverID;
			}
			set
			{
				if ((this._ApproverID != value))
				{
					this.OnApproverIDChanging(value);
					this.SendPropertyChanging();
					this._ApproverID = value;
					this.SendPropertyChanged("ApproverID");
					this.OnApproverIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="NVarChar(50)")]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				if ((this._EmailAddress != value))
				{
					this.OnEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._EmailAddress = value;
					this.SendPropertyChanged("EmailAddress");
					this.OnEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationID", DbType="Int")]
		public System.Nullable<int> LocationID
		{
			get
			{
				return this._LocationID;
			}
			set
			{
				if ((this._LocationID != value))
				{
					this.OnLocationIDChanging(value);
					this.SendPropertyChanging();
					this._LocationID = value;
					this.SendPropertyChanged("LocationID");
					this.OnLocationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HomeLocationID", DbType="Int")]
		public System.Nullable<int> HomeLocationID
		{
			get
			{
				return this._HomeLocationID;
			}
			set
			{
				if ((this._HomeLocationID != value))
				{
					this.OnHomeLocationIDChanging(value);
					this.SendPropertyChanging();
					this._HomeLocationID = value;
					this.SendPropertyChanged("HomeLocationID");
					this.OnHomeLocationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApprovalLevel", DbType="Int")]
		public System.Nullable<int> ApprovalLevel
		{
			get
			{
				return this._ApprovalLevel;
			}
			set
			{
				if ((this._ApprovalLevel != value))
				{
					this.OnApprovalLevelChanging(value);
					this.SendPropertyChanging();
					this._ApprovalLevel = value;
					this.SendPropertyChanged("ApprovalLevel");
					this.OnApprovalLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanguageID", DbType="Int")]
		public System.Nullable<int> LanguageID
		{
			get
			{
				return this._LanguageID;
			}
			set
			{
				if ((this._LanguageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._LanguageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrencyFormatID", DbType="Int")]
		public System.Nullable<int> CurrencyFormatID
		{
			get
			{
				return this._CurrencyFormatID;
			}
			set
			{
				if ((this._CurrencyFormatID != value))
				{
					this.OnCurrencyFormatIDChanging(value);
					this.SendPropertyChanging();
					this._CurrencyFormatID = value;
					this.SendPropertyChanged("CurrencyFormatID");
					this.OnCurrencyFormatIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateFormatID", DbType="Int")]
		public System.Nullable<int> DateFormatID
		{
			get
			{
				return this._DateFormatID;
			}
			set
			{
				if ((this._DateFormatID != value))
				{
					this.OnDateFormatIDChanging(value);
					this.SendPropertyChanging();
					this._DateFormatID = value;
					this.SendPropertyChanged("DateFormatID");
					this.OnDateFormatIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactTelephone", DbType="NVarChar(50)")]
		public string ContactTelephone
		{
			get
			{
				return this._ContactTelephone;
			}
			set
			{
				if ((this._ContactTelephone != value))
				{
					this.OnContactTelephoneChanging(value);
					this.SendPropertyChanging();
					this._ContactTelephone = value;
					this.SendPropertyChanged("ContactTelephone");
					this.OnContactTelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="Int")]
		public System.Nullable<int> RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					this.OnRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RoleID = value;
					this.SendPropertyChanged("RoleID");
					this.OnRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Locked", DbType="Bit NOT NULL")]
		public bool Locked
		{
			get
			{
				return this._Locked;
			}
			set
			{
				if ((this._Locked != value))
				{
					this.OnLockedChanging(value);
					this.SendPropertyChanging();
					this._Locked = value;
					this.SendPropertyChanged("Locked");
					this.OnLockedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FailedLoginAttempts", DbType="Int NOT NULL")]
		public int FailedLoginAttempts
		{
			get
			{
				return this._FailedLoginAttempts;
			}
			set
			{
				if ((this._FailedLoginAttempts != value))
				{
					this.OnFailedLoginAttemptsChanging(value);
					this.SendPropertyChanging();
					this._FailedLoginAttempts = value;
					this.SendPropertyChanged("FailedLoginAttempts");
					this.OnFailedLoginAttemptsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastLoginDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastLoginDate
		{
			get
			{
				return this._LastLoginDate;
			}
			set
			{
				if ((this._LastLoginDate != value))
				{
					this.OnLastLoginDateChanging(value);
					this.SendPropertyChanging();
					this._LastLoginDate = value;
					this.SendPropertyChanged("LastLoginDate");
					this.OnLastLoginDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessUnitID", DbType="Int")]
		public System.Nullable<int> BusinessUnitID
		{
			get
			{
				return this._BusinessUnitID;
			}
			set
			{
				if ((this._BusinessUnitID != value))
				{
					this.OnBusinessUnitIDChanging(value);
					this.SendPropertyChanging();
					this._BusinessUnitID = value;
					this.SendPropertyChanged("BusinessUnitID");
					this.OnBusinessUnitIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NotificationEmail", DbType="Bit NOT NULL")]
		public bool NotificationEmail
		{
			get
			{
				return this._NotificationEmail;
			}
			set
			{
				if ((this._NotificationEmail != value))
				{
					this.OnNotificationEmailChanging(value);
					this.SendPropertyChanging();
					this._NotificationEmail = value;
					this.SendPropertyChanged("NotificationEmail");
					this.OnNotificationEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RunCompanyReports", DbType="Bit NOT NULL")]
		public bool RunCompanyReports
		{
			get
			{
				return this._RunCompanyReports;
			}
			set
			{
				if ((this._RunCompanyReports != value))
				{
					this.OnRunCompanyReportsChanging(value);
					this.SendPropertyChanging();
					this._RunCompanyReports = value;
					this.SendPropertyChanged("RunCompanyReports");
					this.OnRunCompanyReportsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChangeBusinessUnit", DbType="Bit NOT NULL")]
		public bool ChangeBusinessUnit
		{
			get
			{
				return this._ChangeBusinessUnit;
			}
			set
			{
				if ((this._ChangeBusinessUnit != value))
				{
					this.OnChangeBusinessUnitChanging(value);
					this.SendPropertyChanging();
					this._ChangeBusinessUnit = value;
					this.SendPropertyChanged("ChangeBusinessUnit");
					this.OnChangeBusinessUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Leaver", DbType="Bit")]
		public System.Nullable<bool> Leaver
		{
			get
			{
				return this._Leaver;
			}
			set
			{
				if ((this._Leaver != value))
				{
					this.OnLeaverChanging(value);
					this.SendPropertyChanging();
					this._Leaver = value;
					this.SendPropertyChanged("Leaver");
					this.OnLeaverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LeavingDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LeavingDate
		{
			get
			{
				return this._LeavingDate;
			}
			set
			{
				if ((this._LeavingDate != value))
				{
					this.OnLeavingDateChanging(value);
					this.SendPropertyChanging();
					this._LeavingDate = value;
					this.SendPropertyChanged("LeavingDate");
					this.OnLeavingDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeZone", DbType="NVarChar(50)")]
		public string TimeZone
		{
			get
			{
				return this._TimeZone;
			}
			set
			{
				if ((this._TimeZone != value))
				{
					this.OnTimeZoneChanging(value);
					this.SendPropertyChanging();
					this._TimeZone = value;
					this.SendPropertyChanged("TimeZone");
					this.OnTimeZoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Locale", DbType="NVarChar(10)")]
		public string Locale
		{
			get
			{
				return this._Locale;
			}
			set
			{
				if ((this._Locale != value))
				{
					this.OnLocaleChanging(value);
					this.SendPropertyChanging();
					this._Locale = value;
					this.SendPropertyChanged("Locale");
					this.OnLocaleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CostCenter", DbType="NVarChar(30)")]
		public string CostCenter
		{
			get
			{
				return this._CostCenter;
			}
			set
			{
				if ((this._CostCenter != value))
				{
					this.OnCostCenterChanging(value);
					this.SendPropertyChanging();
					this._CostCenter = value;
					this.SendPropertyChanged("CostCenter");
					this.OnCostCenterChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_PasswordReset")]
	public partial class tbl_PasswordReset : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PK;
		
		private int _UserID;
		
		private string _TempPassword;
		
		private System.DateTime _ResetDate;
		
		private System.Nullable<System.DateTime> _LastAttemptDate;
		
		private int _ResetAttempts;
		
		private string _ValidationCode;
		
		private int _Status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPKChanging(int value);
    partial void OnPKChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnTempPasswordChanging(string value);
    partial void OnTempPasswordChanged();
    partial void OnResetDateChanging(System.DateTime value);
    partial void OnResetDateChanged();
    partial void OnLastAttemptDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastAttemptDateChanged();
    partial void OnResetAttemptsChanging(int value);
    partial void OnResetAttemptsChanged();
    partial void OnValidationCodeChanging(string value);
    partial void OnValidationCodeChanged();
    partial void OnStatusChanging(int value);
    partial void OnStatusChanged();
    #endregion
		
		public tbl_PasswordReset()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PK", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PK
		{
			get
			{
				return this._PK;
			}
			set
			{
				if ((this._PK != value))
				{
					this.OnPKChanging(value);
					this.SendPropertyChanging();
					this._PK = value;
					this.SendPropertyChanged("PK");
					this.OnPKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TempPassword", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TempPassword
		{
			get
			{
				return this._TempPassword;
			}
			set
			{
				if ((this._TempPassword != value))
				{
					this.OnTempPasswordChanging(value);
					this.SendPropertyChanging();
					this._TempPassword = value;
					this.SendPropertyChanged("TempPassword");
					this.OnTempPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResetDate", DbType="DateTime NOT NULL")]
		public System.DateTime ResetDate
		{
			get
			{
				return this._ResetDate;
			}
			set
			{
				if ((this._ResetDate != value))
				{
					this.OnResetDateChanging(value);
					this.SendPropertyChanging();
					this._ResetDate = value;
					this.SendPropertyChanged("ResetDate");
					this.OnResetDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastAttemptDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastAttemptDate
		{
			get
			{
				return this._LastAttemptDate;
			}
			set
			{
				if ((this._LastAttemptDate != value))
				{
					this.OnLastAttemptDateChanging(value);
					this.SendPropertyChanging();
					this._LastAttemptDate = value;
					this.SendPropertyChanged("LastAttemptDate");
					this.OnLastAttemptDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResetAttempts", DbType="Int NOT NULL")]
		public int ResetAttempts
		{
			get
			{
				return this._ResetAttempts;
			}
			set
			{
				if ((this._ResetAttempts != value))
				{
					this.OnResetAttemptsChanging(value);
					this.SendPropertyChanging();
					this._ResetAttempts = value;
					this.SendPropertyChanged("ResetAttempts");
					this.OnResetAttemptsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValidationCode", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string ValidationCode
		{
			get
			{
				return this._ValidationCode;
			}
			set
			{
				if ((this._ValidationCode != value))
				{
					this.OnValidationCodeChanging(value);
					this.SendPropertyChanging();
					this._ValidationCode = value;
					this.SendPropertyChanged("ValidationCode");
					this.OnValidationCodeChanged();
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
	
	public partial class usp_tbl_PasswordReset_GetLastEntryResult
	{
		
		private int _PK;
		
		private int _UserID;
		
		private string _TempPassword;
		
		private System.DateTime _ResetDate;
		
		private System.Nullable<System.DateTime> _LastAttemptDate;
		
		private int _ResetAttempts;
		
		private string _ValidationCode;
		
		private int _Status;
		
		public usp_tbl_PasswordReset_GetLastEntryResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PK", DbType="Int NOT NULL")]
		public int PK
		{
			get
			{
				return this._PK;
			}
			set
			{
				if ((this._PK != value))
				{
					this._PK = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TempPassword", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TempPassword
		{
			get
			{
				return this._TempPassword;
			}
			set
			{
				if ((this._TempPassword != value))
				{
					this._TempPassword = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResetDate", DbType="DateTime NOT NULL")]
		public System.DateTime ResetDate
		{
			get
			{
				return this._ResetDate;
			}
			set
			{
				if ((this._ResetDate != value))
				{
					this._ResetDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastAttemptDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastAttemptDate
		{
			get
			{
				return this._LastAttemptDate;
			}
			set
			{
				if ((this._LastAttemptDate != value))
				{
					this._LastAttemptDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResetAttempts", DbType="Int NOT NULL")]
		public int ResetAttempts
		{
			get
			{
				return this._ResetAttempts;
			}
			set
			{
				if ((this._ResetAttempts != value))
				{
					this._ResetAttempts = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValidationCode", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string ValidationCode
		{
			get
			{
				return this._ValidationCode;
			}
			set
			{
				if ((this._ValidationCode != value))
				{
					this._ValidationCode = value;
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
					this._Status = value;
				}
			}
		}
	}
	
	public partial class usp_tbl_EmailMessage_SearchResult
	{
		
		private int _PK;
		
		private string _UniqueTitle;
		
		private string _Title;
		
		private string _Subject;
		
		private string _Body;
		
		private string _ToAdd;
		
		private string _Cc;
		
		private int _AccountID;
		
		private int _LanguageID;
		
		private string _Language;
		
		private int _LanguageOrder;
		
		public usp_tbl_EmailMessage_SearchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PK", DbType="Int NOT NULL")]
		public int PK
		{
			get
			{
				return this._PK;
			}
			set
			{
				if ((this._PK != value))
				{
					this._PK = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UniqueTitle", DbType="NVarChar(255)")]
		public string UniqueTitle
		{
			get
			{
				return this._UniqueTitle;
			}
			set
			{
				if ((this._UniqueTitle != value))
				{
					this._UniqueTitle = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(255)")]
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
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="NVarChar(255)")]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					this._Subject = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(4000)")]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this._Body = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ToAdd", DbType="NVarChar(255)")]
		public string ToAdd
		{
			get
			{
				return this._ToAdd;
			}
			set
			{
				if ((this._ToAdd != value))
				{
					this._ToAdd = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cc", DbType="NVarChar(255)")]
		public string Cc
		{
			get
			{
				return this._Cc;
			}
			set
			{
				if ((this._Cc != value))
				{
					this._Cc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountID", DbType="Int NOT NULL")]
		public int AccountID
		{
			get
			{
				return this._AccountID;
			}
			set
			{
				if ((this._AccountID != value))
				{
					this._AccountID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanguageID", DbType="Int NOT NULL")]
		public int LanguageID
		{
			get
			{
				return this._LanguageID;
			}
			set
			{
				if ((this._LanguageID != value))
				{
					this._LanguageID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Language", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Language
		{
			get
			{
				return this._Language;
			}
			set
			{
				if ((this._Language != value))
				{
					this._Language = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanguageOrder", DbType="Int NOT NULL")]
		public int LanguageOrder
		{
			get
			{
				return this._LanguageOrder;
			}
			set
			{
				if ((this._LanguageOrder != value))
				{
					this._LanguageOrder = value;
				}
			}
		}
	}
}
#pragma warning restore 1591