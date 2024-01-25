using Business.Abstract;
using newproject;
using ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager :IApplicantService
    {
        public void ApplyForMask(Users users)
        {
            
        }

        public List<Users> GetList()
        {
            return null;
        }

        public bool CheckPerson(Users users)
        {
            KPSPublicSoapClient client = KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap;
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody()));
        }
    }
}
