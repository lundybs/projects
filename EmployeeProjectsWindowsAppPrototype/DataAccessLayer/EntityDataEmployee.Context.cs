﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmployeeProjectsEntities : DbContext
    {
        public EmployeeProjectsEntities()
            : base("name=EmployeeProjectsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EmployeeProjectHour> EmployeeProjectHours { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ThisYearsDate> ThisYearsDates { get; set; }
        public virtual DbSet<ValidHourEntry> ValidHourEntries { get; set; }
    
        public virtual int pDelEmployeeProjectHours(string employeeID, string projectID, Nullable<System.DateTime> date)
        {
            var employeeIDParameter = employeeID != null ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(string));
    
            var projectIDParameter = projectID != null ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pDelEmployeeProjectHours", employeeIDParameter, projectIDParameter, dateParameter);
        }
    
        public virtual int pDelEmployees(Nullable<int> employeeId)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pDelEmployees", employeeIdParameter);
        }
    
        public virtual int pDelProjects(Nullable<int> projectId)
        {
            var projectIdParameter = projectId.HasValue ?
                new ObjectParameter("ProjectId", projectId) :
                new ObjectParameter("ProjectId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pDelProjects", projectIdParameter);
        }
    
        public virtual int pInsEmployeeProjectHours(string employeeID, string projectID, Nullable<System.DateTime> date, Nullable<decimal> hours)
        {
            var employeeIDParameter = employeeID != null ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(string));
    
            var projectIDParameter = projectID != null ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var hoursParameter = hours.HasValue ?
                new ObjectParameter("Hours", hours) :
                new ObjectParameter("Hours", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pInsEmployeeProjectHours", employeeIDParameter, projectIDParameter, dateParameter, hoursParameter);
        }
    
        public virtual int pInsEmployees(string employeeName, ObjectParameter newRowID)
        {
            var employeeNameParameter = employeeName != null ?
                new ObjectParameter("EmployeeName", employeeName) :
                new ObjectParameter("EmployeeName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pInsEmployees", employeeNameParameter, newRowID);
        }
    
        public virtual int pInsProjects(string projectName, string projectDescription, ObjectParameter newRowID)
        {
            var projectNameParameter = projectName != null ?
                new ObjectParameter("ProjectName", projectName) :
                new ObjectParameter("ProjectName", typeof(string));
    
            var projectDescriptionParameter = projectDescription != null ?
                new ObjectParameter("ProjectDescription", projectDescription) :
                new ObjectParameter("ProjectDescription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pInsProjects", projectNameParameter, projectDescriptionParameter, newRowID);
        }
    
        public virtual ObjectResult<pSelEmployeeProjectHours_Result> pSelEmployeeProjectHours()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pSelEmployeeProjectHours_Result>("pSelEmployeeProjectHours");
        }
    
        public virtual ObjectResult<pSelEmployees_Result> pSelEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pSelEmployees_Result>("pSelEmployees");
        }
    
        public virtual ObjectResult<pSelProjects_Result> pSelProjects()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pSelProjects_Result>("pSelProjects");
        }
    
        public virtual ObjectResult<pSelThisYearsDates_Result> pSelThisYearsDates()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pSelThisYearsDates_Result>("pSelThisYearsDates");
        }
    
        public virtual ObjectResult<pSelValidHours_Result> pSelValidHours()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pSelValidHours_Result>("pSelValidHours");
        }
    
        public virtual int pUpdEmployeeProjectHours(string employeeID, string projectID, Nullable<System.DateTime> date, Nullable<decimal> hours)
        {
            var employeeIDParameter = employeeID != null ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(string));
    
            var projectIDParameter = projectID != null ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var hoursParameter = hours.HasValue ?
                new ObjectParameter("Hours", hours) :
                new ObjectParameter("Hours", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pUpdEmployeeProjectHours", employeeIDParameter, projectIDParameter, dateParameter, hoursParameter);
        }
    
        public virtual int pUpdEmployees(Nullable<int> employeeId, string employeeName)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var employeeNameParameter = employeeName != null ?
                new ObjectParameter("EmployeeName", employeeName) :
                new ObjectParameter("EmployeeName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pUpdEmployees", employeeIdParameter, employeeNameParameter);
        }
    
        public virtual int pUpdProjects(Nullable<int> projectId, string projectName, string projectDescription)
        {
            var projectIdParameter = projectId.HasValue ?
                new ObjectParameter("ProjectId", projectId) :
                new ObjectParameter("ProjectId", typeof(int));
    
            var projectNameParameter = projectName != null ?
                new ObjectParameter("ProjectName", projectName) :
                new ObjectParameter("ProjectName", typeof(string));
    
            var projectDescriptionParameter = projectDescription != null ?
                new ObjectParameter("ProjectDescription", projectDescription) :
                new ObjectParameter("ProjectDescription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pUpdProjects", projectIdParameter, projectNameParameter, projectDescriptionParameter);
        }
    }
}
