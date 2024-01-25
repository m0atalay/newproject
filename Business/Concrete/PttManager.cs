using Business.Abstract;
using newproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
        {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService aplicantService)
        {
            _applicantService = aplicantService; 
        }
        public void GiveMask(Users users)
        {
            PersonManager personManager = new PersonManager();

            if (_applicantService.CheckPerson(users))
            {
                Console.WriteLine(users.Name +  "İçin maske verildi" );
            }

            
        }
    }
}
