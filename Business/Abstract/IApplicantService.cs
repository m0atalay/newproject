using newproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Users users);
        List<Users> GetList();

        bool CheckPerson(Users users);
    }
}
