using Business.Abstract;
using newproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        public void ApplyForMask(Users users)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Users users)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
