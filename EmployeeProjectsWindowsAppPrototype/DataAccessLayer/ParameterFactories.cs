﻿//Lundy, Brad  lundybs
//CHSP 811 Assignment 08

//For EF and ADO.NET
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace DataAccessLayer
{
    public interface IParameterFactory
    {
        Dictionary<string, SqlParameter> Parmeters { get; set; }
    }

    public abstract class ParameterFactory : IParameterFactory
    {
        public ParameterFactory()
        {
            objParmeters = new Dictionary<string, SqlParameter>();
            SqlParameter objNewRowID = new SqlParameter("@NewRowID", SqlDbType.Int);
            objNewRowID.Direction = ParameterDirection.Output; //Needed since Output is not default
            Parmeters.Add("NewRowID", objNewRowID);

            SqlParameter objRC = new SqlParameter("@RC", SqlDbType.Int);
            //objRC.Direction = ParameterDirection.ReturnValue; EF does not support ReturnValue directly
            objRC.Direction = ParameterDirection.ReturnValue; //But you can use Output!
            Parmeters.Add("RC", objRC);
        }

        private Dictionary<string, SqlParameter> objParmeters;
        public Dictionary<string, SqlParameter> Parmeters
        {
            get
            {
                return objParmeters;
            }
            set
            {
                objParmeters = value;
            }
        }
    }

    public class EmployeesParameterFactory : ParameterFactory, IParameterFactory
    {
        //Employees
        public EmployeesParameterFactory(int EmployeeID = 0, string EmployeeName = "")
        {
            SqlParameter objEmployeeID = new SqlParameter();
            objEmployeeID.Direction = ParameterDirection.Input; //Note: Input is the default
            objEmployeeID.ParameterName = "@EmployeeID"; //The name must match the SQL argument's name!
            objEmployeeID.SqlDbType = SqlDbType.Int; // The data type must match what is in the database!
            objEmployeeID.Value = EmployeeID; // Value you want to pass in
            this.Parmeters.Add("EmployeeID", objEmployeeID);

            SqlParameter objEmployeeName = new SqlParameter("@EmployeeName", EmployeeName);
            objEmployeeName.SqlDbType = SqlDbType.NVarChar;
            objEmployeeName.Size = 100;
            objEmployeeName.Value = EmployeeName;
            this.Parmeters.Add("EmployeeName", objEmployeeName);

        }
    }//end class

    public class ProjectsParameterFactory : ParameterFactory, IParameterFactory
    {
        public ProjectsParameterFactory(int ProjectID = 0, string ProjectName = "", string ProjectDescription = "")
        {
            SqlParameter objProjectID = new SqlParameter("@ProjectID", ProjectID);
            //objProjectID.Direction = ParameterDirection.Input;
            //objProjectID.ParameterName = "@ProjectID";
            objProjectID.SqlDbType = SqlDbType.Int;
            //objProjectID.Value = ProjectID;
            this.Parmeters.Add("ProjectID", objProjectID);

            SqlParameter objProjectName = new SqlParameter("@ProjectName", ProjectName);
            objProjectID.SqlDbType = SqlDbType.NVarChar;
            objProjectID.Size = 100;
            //objProjectID.Value = ProjectName;
            this.Parmeters.Add("ProjectName", objProjectName);

            SqlParameter objProjectDescription = new SqlParameter("@ProjectDescription", ProjectDescription);
            objProjectDescription.SqlDbType = SqlDbType.NVarChar;
            objProjectDescription.Size = 3000;
            //objProjectDescription.Value = ProjectDescription;
            this.Parmeters.Add("ProjectDescription", objProjectDescription);
        }
    }

    public class  EmployeeProjectHoursParameterFactory : ParameterFactory, IParameterFactory
    {
        public EmployeeProjectHoursParameterFactory(int EmployeeID = 0, string EmployeeName =  "", int ProjectID = 0, string ProjectName= "", System.DateTime Date = default(System.DateTime), decimal Hours = 0.0m)
        {
            SqlParameter objEmployeeID = new SqlParameter("@EmployeeID", EmployeeID);
            //objEmployeeID.Direction = ParameterDirection.Input;
            //objEmployeeID.ParameterName = "@EmployeeID";
            objEmployeeID.SqlDbType = SqlDbType.Int;
            //objEmployeeID.Value = EmployeeID;
            this.Parmeters.Add("EmployeeID", objEmployeeID);

            SqlParameter objEmployeeName = new SqlParameter("@EmployeeName", EmployeeName);
            //objEmployeeName.Direction = ParameterDirection.Input;
            //objEmployeeName.ParameterName = "@EmployeeName";
            objEmployeeName.SqlDbType = SqlDbType.NVarChar;
            objEmployeeName.Size = 100;
            //objEmployeeName.Value = EmployeeName;
            this.Parmeters.Add("EmployeeName", objEmployeeName);

            SqlParameter objProjectID = new SqlParameter("@ProjectID", ProjectID);
            //objProjectID.Direction = ParameterDirection.Input;
            //objProjectID.ParameterName = "@ProjectID";
            objProjectID.SqlDbType = SqlDbType.Int;
            //objProjectID.Value = ProjectID;
            this.Parmeters.Add("ProjectID", objProjectID);

            SqlParameter objProjectName = new SqlParameter("@ProjectName", ProjectName);
            //objProjectName.Direction = ParameterDirection.Input;
            //objProjectName.ParameterName = "@ProjectName";
            objProjectName.SqlDbType = SqlDbType.NVarChar;
            objProjectName.Size = 100;
            //objProjectName.Value = ProjectName;
            this.Parmeters.Add("ProjectName", objProjectName);

            SqlParameter objDate = new SqlParameter("@Date", Date);
            //objDate.Direction = ParameterDirection.Input;
            //objDate.ParameterName = "@Date";
            objDate.SqlDbType = SqlDbType.DateTime;
            //objDate.Value = Date;
            this.Parmeters.Add("Date", objDate);

            SqlParameter objHour = new SqlParameter("@Hours", Hours);
            //objHour.Direction = ParameterDirection.Input;
            //objHour.ParameterName = "@Hours";
            objHour.SqlDbType = SqlDbType.Decimal;
            //objHour.Value = Hours;
            this.Parmeters.Add("Hours", objHour);
        }
    }

    public class ThisYearsDateParameterFactory : ParameterFactory, IParameterFactory
    {
        public ThisYearsDateParameterFactory() { }
    }

    public class ValidHourEntryParameterFactory : ParameterFactory, IParameterFactory
    {
        public ValidHourEntryParameterFactory() { }
    }
}//end namespace
