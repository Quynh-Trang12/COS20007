using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_1_Identifiable_Object
{
    public class Identifiable_Object
    {
        private List<string> _identifiers;

        public Identifiable_Object(string[] idents)
        {
            _identifiers = new List<string>(idents);
        }

        public bool AreYou(string id)
        {
            if (_identifiers.Contains(id))
            {
                return true;
            }
            else return false;
        }

        public string FirstID
        {
            get
            {
                return _identifiers.First();
            }
        }

        public void AddIdentifiers(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
