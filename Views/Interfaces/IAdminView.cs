﻿using DataLayer.Entities.Administrators;
using Helper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Views.Interfaces
{
    public interface IAdminView
    {
        // Properties - Fields Related to DB Fields
        int AdminId { get; set; }
        string AdminFirstName { get; set; }
        string AdminLastName { get; set; }
        DateOnly AdminDateOfBirth { get; set; }
        GenderEnum AdminGender { get; set; }
        int AdminAge { get; set; }
        string AdminEmail { get; set; }
        string AdminTelephone { get; set; }
        WorkingTypeEnum AdminWorkingType { get; set; }
        WorkingSchedule AdminWorkingSchedule { get; set; }
        float AdminWorkingHours { get; set; }
        decimal AdminSalary { get; set; }

        // Properties - Related to Show Form Actions
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessfull { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchAdminEvent;
        event EventHandler AddNewAdminEvent;
        event EventHandler EditAdminEvent;
        event EventHandler DeleteAdminEvent;
        event EventHandler SaveAdminEvent;
        event EventHandler CancelAdminEvent;

        // Methods
        void SetAdminListBindingSource(BindingSource adminList);
        void SetWorkingScheduleListBindingSource(BindingSource workingScheduleList);
        void Show();
    }
}
