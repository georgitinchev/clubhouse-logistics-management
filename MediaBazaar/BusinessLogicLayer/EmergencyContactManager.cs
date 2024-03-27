﻿using DTOLayer;
using MediaBazaar.Classes;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class EmergencyContactManager
    {
        public EmergencyContact TransformDTOToEmergencyContact(EmergencyContactDTO dto)
        {
            return new EmergencyContact(dto.Id, dto.FirstName, dto.LastName, dto.PhoneNumber, dto.Email);
        }

        public EmergencyContact ReadEmergencyContact(int employeeId)
        {
            EmergencyContactDAL emergencyContactDAL = new EmergencyContactDAL();
            EmergencyContactDTO emergencyContactDTO = new EmergencyContactDTO();
            try
            {
                emergencyContactDTO = emergencyContactDAL.ReadEmergencyContact(employeeId);
                return TransformDTOToEmergencyContact(emergencyContactDTO);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
