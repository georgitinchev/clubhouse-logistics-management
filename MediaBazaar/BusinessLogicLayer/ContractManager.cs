﻿using DTOLayer;
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
        public AvailabilityManager availabilityManager { get; private set; }
        public ContractDAL contractDAL { get; private set; }
        public List<Contract> contracts { get; private set; }

        public ContractManager()
        {
            contracts = new List<Contract>();
            contractDAL = new ContractDAL();
            //availabilityManager = new AvailabilityManager(); Might want to change this *
            GetAllContractsFromDB();
        }

        public void AddContract(Contract newContract)
        {
            if (contracts.Any(c => c.Id == newContract.Id))
            {
                throw new Exception("Contract already exists.");
            }
            contracts.Add(newContract);
            AddContractInDB(newContract);
        }

        public Contract GetContractFromDB(int employeeID)
        {
            ContractDTO foundContract = contractDAL.ReadContract(employeeID);
            if (foundContract != null)
            {
                Contract contract = TransformDTOToContract(foundContract);
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
                    contractDTO.Id, (EmployeeRoleEnum)contractDTO.Role, contractDTO.HourlyWage, contractDTO.WeeklyHours, contractDTO.StartDate, contractDTO.EndDate, contractDTO.IsActive, contractDTO.TerminationReason

                );
                return contract;
            }
            catch { }
            return null;

        }
        public ContractDTO TransformContractToDTO(Contract contract)
        {
            ContractDTO contractDTO = new ContractDTO(contract.Id, (int)contract.role, contract.hourlyWage, contract.weeklyHours,
                contract.startDate, contract.endDate, contract.isActive, contract.terminationReason);

            return contractDTO;
        }
        public void GetAllContractsFromDB()
        {
            contracts.Clear();
            foreach (ContractDTO dto in contractDAL.GetAllContracts())
            {
                contracts.Add(TransformDTOToContract(dto));
            }
        }
        public void UpdateContractInDB(Contract Contract)
        {
            if (contractDAL != null)
            {
                contractDAL.UpdateContract(TransformContractToDTO(Contract));
            }
        }

        public void DeleteContractFromDB(Contract contract)
        {
            contractDAL.DeleteContract(contract.Id);

        }
        public void AddContractInDB(Contract contract)
        {
            if (contract != null)
            {
                contractDAL.CreateContract(TransformContractToDTO(contract));
                contracts.Add(contract);
            }
        }
        public int GetNextContractId()
        {
            return contractDAL.GetNextId();
        }

        public List<AvailabilitySlot> GetContractAvailabilitySlots(int contractId)
        {
            return availabilityManager.GetContractSlots(contractId);
        }
    }
}
