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
        private List<Contract> contracts;
      
        // constructor
        public ContractManager()
        {
			contractDAL = new ContractDAL();
            List<Contract> contracts = new List<Contract>();
		}

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
    }
}
