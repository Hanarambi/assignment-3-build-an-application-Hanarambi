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

namespace russo50states
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FittyStates")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertState(State instance);
    partial void UpdateState(State instance);
    partial void DeleteState(State instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::russo50states.Properties.Settings.Default.FittyStatesConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<State> States
		{
			get
			{
				return this.GetTable<State>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.States")]
	public partial class State : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.Nullable<int> _Population;
		
		private string _FlagDescription;
		
		private string _StateFlower;
		
		private string _StateBird;
		
		private string _Colors;
		
		private string _LargestCities;
		
		private string _Capitol;
		
		private System.Nullable<decimal> _MedianIncome;
		
		private System.Nullable<double> _ComputerJobsPercentage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPopulationChanging(System.Nullable<int> value);
    partial void OnPopulationChanged();
    partial void OnFlagDescriptionChanging(string value);
    partial void OnFlagDescriptionChanged();
    partial void OnStateFlowerChanging(string value);
    partial void OnStateFlowerChanged();
    partial void OnStateBirdChanging(string value);
    partial void OnStateBirdChanged();
    partial void OnColorsChanging(string value);
    partial void OnColorsChanged();
    partial void OnLargestCitiesChanging(string value);
    partial void OnLargestCitiesChanged();
    partial void OnCapitolChanging(string value);
    partial void OnCapitolChanged();
    partial void OnMedianIncomeChanging(System.Nullable<decimal> value);
    partial void OnMedianIncomeChanged();
    partial void OnComputerJobsPercentageChanging(System.Nullable<double> value);
    partial void OnComputerJobsPercentageChanged();
    #endregion
		
		public State()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Population", DbType="Int")]
		public System.Nullable<int> Population
		{
			get
			{
				return this._Population;
			}
			set
			{
				if ((this._Population != value))
				{
					this.OnPopulationChanging(value);
					this.SendPropertyChanging();
					this._Population = value;
					this.SendPropertyChanged("Population");
					this.OnPopulationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FlagDescription", DbType="NVarChar(MAX)")]
		public string FlagDescription
		{
			get
			{
				return this._FlagDescription;
			}
			set
			{
				if ((this._FlagDescription != value))
				{
					this.OnFlagDescriptionChanging(value);
					this.SendPropertyChanging();
					this._FlagDescription = value;
					this.SendPropertyChanged("FlagDescription");
					this.OnFlagDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateFlower", DbType="NVarChar(100)")]
		public string StateFlower
		{
			get
			{
				return this._StateFlower;
			}
			set
			{
				if ((this._StateFlower != value))
				{
					this.OnStateFlowerChanging(value);
					this.SendPropertyChanging();
					this._StateFlower = value;
					this.SendPropertyChanged("StateFlower");
					this.OnStateFlowerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateBird", DbType="NVarChar(100)")]
		public string StateBird
		{
			get
			{
				return this._StateBird;
			}
			set
			{
				if ((this._StateBird != value))
				{
					this.OnStateBirdChanging(value);
					this.SendPropertyChanging();
					this._StateBird = value;
					this.SendPropertyChanged("StateBird");
					this.OnStateBirdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Colors", DbType="NVarChar(255)")]
		public string Colors
		{
			get
			{
				return this._Colors;
			}
			set
			{
				if ((this._Colors != value))
				{
					this.OnColorsChanging(value);
					this.SendPropertyChanging();
					this._Colors = value;
					this.SendPropertyChanged("Colors");
					this.OnColorsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LargestCities", DbType="NVarChar(MAX)")]
		public string LargestCities
		{
			get
			{
				return this._LargestCities;
			}
			set
			{
				if ((this._LargestCities != value))
				{
					this.OnLargestCitiesChanging(value);
					this.SendPropertyChanging();
					this._LargestCities = value;
					this.SendPropertyChanged("LargestCities");
					this.OnLargestCitiesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Capitol", DbType="NVarChar(100)")]
		public string Capitol
		{
			get
			{
				return this._Capitol;
			}
			set
			{
				if ((this._Capitol != value))
				{
					this.OnCapitolChanging(value);
					this.SendPropertyChanging();
					this._Capitol = value;
					this.SendPropertyChanged("Capitol");
					this.OnCapitolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedianIncome", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> MedianIncome
		{
			get
			{
				return this._MedianIncome;
			}
			set
			{
				if ((this._MedianIncome != value))
				{
					this.OnMedianIncomeChanging(value);
					this.SendPropertyChanging();
					this._MedianIncome = value;
					this.SendPropertyChanged("MedianIncome");
					this.OnMedianIncomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComputerJobsPercentage", DbType="Float")]
		public System.Nullable<double> ComputerJobsPercentage
		{
			get
			{
				return this._ComputerJobsPercentage;
			}
			set
			{
				if ((this._ComputerJobsPercentage != value))
				{
					this.OnComputerJobsPercentageChanging(value);
					this.SendPropertyChanging();
					this._ComputerJobsPercentage = value;
					this.SendPropertyChanged("ComputerJobsPercentage");
					this.OnComputerJobsPercentageChanged();
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
