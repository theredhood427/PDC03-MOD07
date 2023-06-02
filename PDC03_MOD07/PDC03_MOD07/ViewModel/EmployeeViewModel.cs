using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.IO;
using PDC03_MOD07.Model;

using System.Threading.Tasks;


namespace PDC03_MOD07.ViewModel
{
    public class EmployeeViewModel
    {
        //CALL DATABASE
        private Services.DatabaseContext getContext()
        {
            return new Services.DatabaseContext();
        }

        //INSERT RECORDS
        public int InsertEmployee(EmployeeModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Employee.Add(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }

        //RETRIEVE RECORDS
        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            var _dbContext = getContext();
            var res = await _dbContext.Employee.ToListAsync();
            return res;

        }

        //DELETE RECORDS
        public int DeleteEmployee(EmployeeModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Employee.Remove(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }

        //UPDATE RECORDS
        public async Task<int> UpdateEmployee(EmployeeModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Employee.Update(obj);
            int c =await _dbContext.SaveChangesAsync();
            return c;
        }
    }
}
