using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using MediaBazaar.Classes;

namespace BusinessLogicLayer
{
    public class ContractManager
    {
        private ContractDAL contractDAL;
      

        public Contract GetContractFromDB(int employeeID)
        {
            ContractDTO foundContract= contractDAL.ReadContract(employeeID);
            if (foundContract == null)
            {
                Contract contract = TransformDTOToContract (foundContract);
                return contract;
            }
            throw new Exception("Contract not found");
        }  
        public Contract TransformDTOToContract(ContractDTO contractDTO)
        {
            try
            {
                Contract contract = new Contract
                (
                    contractDTO.Id, (EmployeeRoleEnum)contractDTO.Role, contractDTO.HourlyWage, contractDTO.WeeklyHours, contractDTO.StartDate, contractDTO.EndDate, contractDTO.IsActive, contractDTO.TerminationReason, contractDTO.Availability

                );
                return contract;
            }
            catch { }
            return null;

        }

        public ContractDTO TransformContractToDTO(Contract contract)
        {
            ContractDTO contractDTO = new ContractDTO(contract.Id,(int)contract.role,contract.hourlyWage,contract.weeklyHours,
                contract.startDate,contract.endDate,contract.isActive,contract.terminationReason,contract.availability);
            
            return contractDTO;
        }
    }
}
