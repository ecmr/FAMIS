using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;  
using FAMIS_DALL;

 
namespace FAMIS_BLL
{
    public class User
    {
        private FAMIS_DALL.User _User;

        public User()
        {
            if (_User == null)
                _User = new FAMIS_DALL.User();
        }

        public Model.User Validar(Model.User entity)
        {
            return _User.Validate(entity);   
        }

        public string Add(Model.User user)
        {
            return _User.Add(user);
        }

        public string Update(Model.User user)
        {
            return _User.Update(user);
        }

        public string Delete(Model.User user)
        {
            return _User.Delete(user);
        }

        public Model.User Select(Model.User user)
        {
            return _User.Select(user);
        }

        public List<Model.User> Select(string pWhere)
        {
            return _User.Select(pWhere);
        }

        public string Descriptografar(string _pwd)
        {
            return _User.Descriptografar(Convert.FromBase64String(_pwd), "pink floyd");
        }

        public string Criptografar(string _pwd)
        {
            return _User.Criptografar(_pwd, "pink floyd");
        }
    }
}
